using System.Windows.Input;
using Avalonia.Threading;
using Avalonia.Controls;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Reactive.Linq;
using System.Reactive;
using Avalonia.Controls.Templates;

namespace Avalonia.DialogBuilder.Views;

public partial class DialogBoxView : ReactiveWindow<DialogBoxViewModel>
{
    public DialogBoxView()
    {
        InitializeComponent();

        this.WhenActivated(d =>
        {
            if (DataContext is DialogBoxViewModel vm)
            {
                foreach (var button in vm.ButtonViewModels)
                {
                    if (button.Command is ReactiveCommand<Unit, DialogBoxResult> reactiveCommand)
                    {
                        d(reactiveCommand.Subscribe(result => Close(result)));
                    }
                    else if (button.Command is ICommand command)
                    {
                        d(Observable.FromEventPattern(
                            h => command.CanExecuteChanged += h,
                            h => command.CanExecuteChanged -= h)
                        .Where(_ => command.CanExecute(null))
                        .Subscribe(_ => Close(new DialogBoxResult(button.CommandParameter))));
                    }
                }
            }
        });

        this.Opened += async (_, __) =>
        {
            var itemsControl = this.FindControl<ItemsControl>("ButtonItemsControl");

            if (itemsControl is not null)
            {
                await Task.Delay(1);
                itemsControl.IsVisible = false;
                await Dispatcher.UIThread.InvokeAsync(() =>
                {
                    itemsControl.IsVisible = true;
                }, DispatcherPriority.Render);
            }
        };
    }
}