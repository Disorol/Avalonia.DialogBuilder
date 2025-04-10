using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.Directors;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

// Current namespace is incorrect
namespace PLCSoldier.UIServices.Directors
// Should be
namespace Avalonia.DialogBuilder.Directors
{
    /// <summary>
    /// Director for creating warning-styled dialog boxes with appropriate icon and styling
    /// </summary>
    public class WarningDialogBoxDirector : IDialogBoxDirector
    {
        /// <summary>
        /// Predefined warning icon loaded from application resources
        /// </summary>
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/warning.ico")));

        /// <summary>
        /// Gets or sets the title text displayed in warning dialog boxes.
        /// This setting applies globally to all warning dialogs.
        /// </summary>
        public static string Title { get; set; } = "Warning";

        /// <summary>
        /// Configures the builder with warning dialog specific settings
        /// </summary>
        /// <param name="builder">The builder to configure</param>
        /// <returns>Configured dialog box view model with warning styling</returns>
        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle(Title)
                          .Build();
        }
    }
}
