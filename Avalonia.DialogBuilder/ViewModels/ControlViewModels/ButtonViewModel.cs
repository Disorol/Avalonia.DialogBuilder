using System.Windows.Input;

namespace Avalonia.DialogBuilder.ViewModels
{
    public class ButtonViewModel : ParameterizedTextButton, ICommandButton
    {
        public ICommand? Command { get; set; }
    }
}
