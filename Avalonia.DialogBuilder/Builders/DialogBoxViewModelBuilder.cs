using Avalonia.Controls;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Media;
using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.DialogBuilder.Builders
{
    /// <summary>
    /// Builder for creating and configuring dialog box view models.
    /// Provides a fluent interface for setting all dialog properties.
    /// </summary>
    public class DialogBoxViewModelBuilder
    {
        /// <summary>
        /// The view model instance being configured
        /// </summary>
        protected DialogBoxViewModel _viewModel = new();

        /// <summary>
        /// Builds and returns the configured dialog box view model
        /// </summary>
        public DialogBoxViewModel Build() => _viewModel;

        /// <summary>
        /// Sets the window icon for the dialog
        /// </summary>
        /// <param name="windowIcon">Icon to display in the window's title bar</param>
        public DialogBoxViewModelBuilder SetIcon(WindowIcon windowIcon)
        {
            _viewModel.Icon = windowIcon;
            return this;
        }

        /// <summary>
        /// Sets the window title text
        /// </summary>
        /// <param name="title">Text to display in the window's title bar</param>
        public DialogBoxViewModelBuilder SetTitle(string title)
        {
            _viewModel.Title = title;
            return this;
        }

        /// <summary>
        /// Sets the main content text of the dialog
        /// </summary>
        /// <param name="text">Text to display in the dialog's content area</param>
        public DialogBoxViewModelBuilder SetText(string text)
        {
            _viewModel.Text = text;
            return this;
        }

        /// <summary>
        /// Sets a custom control as the dialog's content
        /// </summary>
        /// <param name="control">Control to display in the dialog's content area</param>
        public DialogBoxViewModelBuilder SetControl(Control control)
        {
            _viewModel.Content = control;
            return this;
        }

        /// <summary>
        /// Sets the dialog's buttons, replacing any existing buttons
        /// </summary>
        /// <param name="buttons">Collection of button configurations</param>
        public DialogBoxViewModelBuilder SetButtons(params ParameterizedTextButton[] buttons)
        {
            _viewModel.ButtonViewModels.Clear();

            foreach (var button in buttons)
            {
                ButtonViewModel buttonViewModel = new()
                {
                    Text = button.Text,
                    CommandParameter = button.CommandParameter,
                    Command = ReactiveCommand.Create(() => new DialogBoxResult(button.CommandParameter))
                };

                _viewModel.ButtonViewModels.Add(buttonViewModel);
            }

            return this;
        }

        /// <summary>
        /// Adds a single button to the dialog's button collection
        /// </summary>
        /// <param name="button">Button configuration to add</param>
        public DialogBoxViewModelBuilder AddButton(ParameterizedTextButton button)
        {
            ButtonViewModel buttonViewModel = new()
            {
                Text = button.Text,
                CommandParameter = button.CommandParameter,
                Command = ReactiveCommand.Create(() => new DialogBoxResult(button.CommandParameter))
            };

            _viewModel.ButtonViewModels.Add(buttonViewModel);

            return this;
        }

        /// <summary>
        /// Sets the maximum height of the dialog window
        /// </summary>
        /// <param name="height">Maximum height in pixels</param>
        public DialogBoxViewModelBuilder SetMaxHeight(double height)
        {
            _viewModel.MaxHeight = height;
            return this;
        }

        /// <summary>
        /// Sets the maximum width of the dialog window
        /// </summary>
        /// <param name="width">Maximum width in pixels</param>
        public DialogBoxViewModelBuilder SetMaxWidth(double width)
        {
            _viewModel.MaxWidth = width;
            return this;
        }

        /// <summary>
        /// Sets the initial position of the dialog window
        /// </summary>
        /// <param name="windowStartupLocation">Location where the window should appear when shown</param>
        public DialogBoxViewModelBuilder SetWindowStartupLocation(WindowStartupLocation windowStartupLocation)
        {
            _viewModel.WindowStartupLocation = windowStartupLocation;
            return this;
        }

        /// <summary>
        /// Sets the theme variant for the dialog
        /// </summary>
        /// <param name="themeVariant">Theme variant (Light/Dark) to use</param>
        public DialogBoxViewModelBuilder SetRequestedThemeVariant(ThemeVariant themeVariant)
        {
            _viewModel.RequestedThemeVariant = themeVariant;
            return this;
        }

        /// <summary>
        /// Sets the font size for the dialog's text content
        /// </summary>
        /// <param name="fontSize">Font size in points</param>
        public DialogBoxViewModelBuilder SetTextFontSize(double fontSize)
        {
            _viewModel.TextFontSize = fontSize;
            return this;
        }

        /// <summary>
        /// Sets the font size for button texts
        /// </summary>
        /// <param name="fontSize">Font size in points</param>
        public DialogBoxViewModelBuilder SetButtonTextFontSize(double fontSize)
        {
            _viewModel.ButtonTextFontSize = fontSize;
            return this;
        }

        /// <summary>
        /// Sets the minimum width for dialog buttons
        /// </summary>
        /// <param name="width">Minimum width in pixels</param>
        public DialogBoxViewModelBuilder SetMinButtonWidth(double width)
        {
            _viewModel.MinButtonWidth = width;
            return this;
        }

        /// <summary>
        /// Sets the maximum width for dialog buttons
        /// </summary>
        /// <param name="width">Maximum width in pixels</param>
        public DialogBoxViewModelBuilder SetMaxButtonWidth(double width)
        {
            _viewModel.MaxButtonWidth = width;
            return this;
        }

        /// <summary>
        /// Sets the flow direction for button layout
        /// </summary>
        /// <param name="flowDirection">Direction (LeftToRight or RightToLeft) for button arrangement</param>
        public DialogBoxViewModelBuilder SetButtonWrappingFlowDirection(FlowDirection flowDirection)
        {
            _viewModel.ButtonWrappingFlowDirection = flowDirection;
            return this;
        }

        /// <summary>
        /// Sets whether the dialog window can be resized
        /// </summary>
        /// <param name="canResize">True to allow resizing, false to prevent it</param>
        public DialogBoxViewModelBuilder SetCanResize(bool canResize)
        {
            _viewModel.CanResize = canResize;
            return this;
        }

        /// <summary>
        /// Sets the height for all dialog buttons
        /// </summary>
        /// <param name="height">Button height in pixels</param>
        public DialogBoxViewModelBuilder SetButtonHeight(double height)
        {
            _viewModel.ButtonHeight = height;
            return this;
        }
    }
}
