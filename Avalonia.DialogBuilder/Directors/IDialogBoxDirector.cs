using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;

namespace Avalonia.DialogBuilder.Directors
{
    /// <summary>
    /// Defines a contract for dialog box directors that configure dialog boxes with specific styles and behaviors
    /// </summary>
    public interface IDialogBoxDirector
    {
        /// <summary>
        /// Configures and builds a dialog box view model using the provided builder
        /// </summary>
        /// <param name="builder">The builder instance to configure</param>
        /// <returns>Configured dialog box view model</returns>
        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder);
    }
}
