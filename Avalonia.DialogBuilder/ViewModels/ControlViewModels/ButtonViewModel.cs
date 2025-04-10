using System.Windows.Input;

namespace Avalonia.DialogBuilder.ViewModels
{
    /// <summary>
    /// View model for a button that combines text, command, and parameter functionality
    /// </summary>
    public class ButtonViewModel : DialogButtonBase, ICommandButton
    {
        /// <summary>
        /// Gets or sets the command to be executed when the button is clicked
        /// </summary>
        public ICommand? Command { get; set; }
    }
}
