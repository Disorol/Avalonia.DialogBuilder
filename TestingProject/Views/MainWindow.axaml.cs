using Avalonia.DialogBuilder.ViewModels;
using Avalonia.DialogBuilder.Views;
using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Threading.Tasks;
using TestingProject.ViewModels;

namespace TestingProject.Views
{
    public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
            
            this.WhenActivated(action => action(ViewModel!.ShowTestDialog.RegisterHandler(DoShowTestDialogAsync)));
        }

        private async Task DoShowTestDialogAsync(IInteractionContext<DialogBoxViewModel, DialogBoxResult?> interaction)
        {
            DialogBoxView dialog = new DialogBoxView()
            {
                DataContext = interaction.Input
            };

            DialogBoxResult? result = await dialog.ShowDialog<DialogBoxResult?>(this);
            interaction.SetOutput(result);
        }
    }
}