using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

namespace Avalonia.DialogBuilder.Directors
{
    /// <summary>
    /// Director for creating success-styled dialog boxes with appropriate icon and styling
    /// </summary>
    public class SuccessDialogBoxDirector : IDialogBoxDirector
    {
        /// <summary>
        /// Predefined success icon loaded from application resources
        /// </summary>
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/checkmark.ico")));

        /// <summary>
        /// Gets or sets the title text displayed in success dialog boxes.
        /// This setting applies globally to all success dialogs.
        /// </summary>
        public static string Title { get; set; } = "Success";

        /// <summary>
        /// Configures the builder with success dialog specific settings
        /// </summary>
        /// <param name="builder">The builder to configure</param>
        /// <returns>Configured dialog box view model with success styling</returns>
        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle(Title)
                          .Build();
        }
    }
}
