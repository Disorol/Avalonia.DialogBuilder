using System.Windows.Input;

namespace Avalonia.DialogBuilder.ViewModels
{
    /// <summary>
    /// Interface for buttons that can execute commands
    /// </summary>
    public interface ICommandButton
    {
        /// <summary>
        /// Gets or sets the command to be executed when the button is clicked
        /// </summary>
        ICommand? Command { get; set; }
    }
}
