using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.Directors;
using Avalonia.DialogBuilder.ViewModels;
using PLCSoldier.UIServices.Directors;
using ReactiveUI;
using System.Reactive;
using System.Reactive.Linq;
using System.Resources;
using System.Windows.Input;

namespace TestingProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Interaction<DialogBoxViewModel, DialogBoxResult?> ShowTestDialog { get; } = new();

        public ICommand OpenTestDialogBoxCommand { get; }

        public MainWindowViewModel()
        {
            OpenTestDialogBoxCommand = ReactiveCommand.Create(ExecuteOpenTestDialogBox);
        }

        public async void ExecuteOpenTestDialogBox()
        {
            IDialogBoxViewModelBuilder builder = new DialogBoxViewModelBuilder().SetText("Some text")
                                                                    .SetButtons(new ParameterizedTextButton() { CommandParameter = true, Text = "Confirm" }, new ParameterizedTextButton() { CommandParameter = false, Text = "Cancel" });
            IDialogBoxDirector director = new WarningDialogBoxDirector();
            DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
            DialogBoxResult interactionResult = await ShowTestDialog.Handle(dialogBoxViewModel);

        }
    }
}
