using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

namespace Avalonia.DialogBuilder.Directors
{
    /// <summary>
    /// Director for creating error-styled dialog boxes with appropriate icon and styling
    /// </summary>
    public class ErrorDialogBoxDirector : IDialogBoxDirector
    {
        /// <summary>
        /// Predefined error icon loaded from application resources
        /// </summary>
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/cross.ico")));

        /// <summary>
        /// Gets or sets the title text displayed in error dialog boxes.
        /// This setting applies globally to all error dialogs.
        /// </summary>
        public static string Title { get; set; } = "Error";

        /// <summary>
        /// Configures the builder with error dialog specific settings
        /// </summary>
        /// <param name="builder">The builder to configure</param>
        /// <returns>Configured dialog box view model with error styling</returns>
        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle(Title)
                          .Build();
        }
    }
}
