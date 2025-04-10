using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.Directors;
using Avalonia.DialogBuilder.ViewModels;
using ReactiveUI;
using System.Reactive.Linq;
using System.Windows.Input;
using TestingProject.Views;

namespace TestingProject.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public Interaction<DialogBoxViewModel, DialogBoxResult?> ShowTestDialog { get; } = new();

        public ICommand OpenTestSaveDialogBoxCommand { get; }
        public ICommand OpenTestErrorMessageDialogBoxCommand { get; }
        public ICommand OpenTestCustomControlDialogBoxCommand { get; }

        public MainWindowViewModel()
        {
            OpenTestSaveDialogBoxCommand = ReactiveCommand.Create(ExecuteOpenTestSaveDialogBox);
            OpenTestErrorMessageDialogBoxCommand = ReactiveCommand.Create(ExecuteOpenTestErrorMessageDialogBox);
            OpenTestCustomControlDialogBoxCommand = ReactiveCommand.Create(ExecuteOpenTestCustomControlDialogBox);
        }

        public async void ExecuteOpenTestSaveDialogBox()
        {
            var builder = new DialogBoxViewModelBuilder().SetText("Do you want to save changes?")
                                                         .SetButtons(
                                                             new DialogButtonBase { Text = "Save", CommandParameter = true },
                                                             new DialogButtonBase { Text = "Cancel", CommandParameter = false });
            var director = new WarningDialogBoxDirector();
            DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
            DialogBoxResult result = await ShowTestDialog.Handle(dialogBoxViewModel);

            if (result.Parameter is true)
            {
                // Handle save
            }
        }

        public async void ExecuteOpenTestErrorMessageDialogBox()
        {
            var builder = new DialogBoxViewModelBuilder().SetText("Failed to connect to the server.")
                                             .SetButtons(
                                                 new DialogButtonBase { Text = "OK" });
            var director = new ErrorDialogBoxDirector();
            DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
            await ShowTestDialog.Handle(dialogBoxViewModel);
        }

        public async void ExecuteOpenTestCustomControlDialogBox()
        {
            var viewModel = new TestViewModel() { Text = "Button" };
            var view = new TextView();
            view.DataContext = viewModel;
            var builder = new DialogBoxViewModelBuilder().SetControl(view)
                                                         .SetButtons(new DialogButtonBase { Text = "Close" });
            var director = new InformationDialogBoxDirector();
            DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
            await ShowTestDialog.Handle(dialogBoxViewModel);
        }
    }
}
