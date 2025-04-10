using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

namespace Avalonia.DialogBuilder.Directors
{
    /// <summary>
    /// Director for creating information-styled dialog boxes with appropriate icon and styling
    /// </summary>
    public class InformationDialogBoxDirector : IDialogBoxDirector
    {
        /// <summary>
        /// Predefined information icon loaded from application resources
        /// </summary>
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/information.ico")));

        /// <summary>
        /// Gets or sets the title text displayed in information dialog boxes.
        /// This setting applies globally to all information dialogs.
        /// </summary>
        public static string Title { get; set; } = "Information";

        /// <summary>
        /// Configures the builder with information dialog specific settings
        /// </summary>
        /// <param name="builder">The builder to configure</param>
        /// <returns>Configured dialog box view model with information styling</returns>
        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle(Title)
                          .Build();
        }
    }
}
