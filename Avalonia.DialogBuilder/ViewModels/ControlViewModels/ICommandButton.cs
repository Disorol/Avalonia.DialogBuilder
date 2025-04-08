using System.Windows.Input;

namespace Avalonia.DialogBuilder.ViewModels
{
    public interface ICommandButton
    {
        ICommand? Command { get; set; }
    }
}
