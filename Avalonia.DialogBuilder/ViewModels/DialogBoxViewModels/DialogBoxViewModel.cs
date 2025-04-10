using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.DialogBuilder.ViewModels
{
    /// <summary>
    /// View model for dialog box window that provides properties to configure and manage dialog appearance and behavior
    /// </summary>
    public class DialogBoxViewModel : ViewModelBase
    {
        /// <summary>
        /// Gets or sets the window icon displayed in the dialog's title bar
        /// </summary>
        public WindowIcon? Icon { get; set; }

        /// <summary>
        /// Gets or sets the title text displayed in the dialog's title bar
        /// </summary>
        public string? Title { get; set; }

        private object? _content;
        /// <summary>
        /// Gets or sets the main content of the dialog box
        /// </summary>
        public object? Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        /// <summary>
        /// Gets or sets the text content of the dialog box.
        /// This property is maintained for backward compatibility and internally uses the Content property
        /// </summary>
        public string? Text
        {
            get => Content as string;
            set => Content = value;
        }

        /// <summary>
        /// Gets the collection of button view models that represent the dialog's buttons
        /// </summary>
        public IList<ButtonViewModel> ButtonViewModels { get; } = [];

        #region [Window Settings]

        private WindowStartupLocation _windowStartupLocation = WindowStartupLocation.CenterScreen;
        /// <summary>
        /// Gets or sets the initial position of the dialog window when it is shown
        /// </summary>
        public WindowStartupLocation WindowStartupLocation
        {
            get => _windowStartupLocation;
            set => this.RaiseAndSetIfChanged(ref _windowStartupLocation, value);
        }

        private ThemeVariant _requestedThemeVariant = ThemeVariant.Light;
        /// <summary>
        /// Gets or sets the theme variant (Light/Dark) for the dialog window
        /// </summary>
        public ThemeVariant RequestedThemeVariant
        {
            get => _requestedThemeVariant;
            set => this.RaiseAndSetIfChanged(ref _requestedThemeVariant, value);
        }

        private bool _canResize = false;
        /// <summary>
        /// Gets or sets whether the dialog window can be resized by the user
        /// </summary>
        public bool CanResize
        {
            get => _canResize;
            set => this.RaiseAndSetIfChanged(ref _canResize, value);
        }

        private double _maxWidth = 400;
        /// <summary>
        /// Gets or sets the maximum width of the dialog window in pixels
        /// </summary>
        public double MaxWidth
        {
            get => _maxWidth;
            set => this.RaiseAndSetIfChanged(ref _maxWidth, value);
        }

        private double _maxHeight = 150;
        /// <summary>
        /// Gets or sets the maximum height of the dialog window in pixels
        /// </summary>
        public double MaxHeight
        {
            get => _maxHeight;
            set => this.RaiseAndSetIfChanged(ref _maxHeight, value);
        }

        #endregion

        #region [Text Settings]

        private double _textFontSize = 14;
        /// <summary>
        /// Gets or sets the font size for the dialog's text content
        /// </summary>
        public double TextFontSize
        {
            get => _textFontSize;
            set => this.RaiseAndSetIfChanged(ref _textFontSize, value);
        }

        #endregion

        #region [Button Settings]

        private double _buttonHeight = 32;
        /// <summary>
        /// Gets or sets the height for dialog buttons in pixels
        /// </summary>
        public double ButtonHeight
        {
            get => _buttonHeight;
            set => this.RaiseAndSetIfChanged(ref _buttonHeight, value);
        }

        private double _minButtonWidth = 100;
        /// <summary>
        /// Gets or sets the minimum width for dialog buttons in pixels
        /// </summary>
        public double MinButtonWidth
        {
            get => _minButtonWidth;
            set => this.RaiseAndSetIfChanged(ref _minButtonWidth, value);
        }

        private double _maxButtonWidth = 150;
        /// <summary>
        /// Gets or sets the maximum width for dialog buttons in pixels
        /// </summary>
        public double MaxButtonWidth
        {
            get => _maxButtonWidth;
            set => this.RaiseAndSetIfChanged(ref _maxButtonWidth, value);
        }

        /// <summary>
        /// Gets the calculated width for all buttons in the dialog.
        /// The width is calculated based on the widest button text and current font size
        /// </summary>
        public double ButtonWidth => ButtonViewModels.Any() 
            ? Math.Max(MinButtonWidth,
                Math.Min(ButtonViewModels.Max(b => (b.Text?.Length ?? 0)) * (ButtonTextFontSize * 0.7), MaxButtonWidth))
            : MinButtonWidth;

        private FlowDirection _buttonWrappingFlowDirection = FlowDirection.RightToLeft;
        /// <summary>
        /// Gets or sets the flow direction for button layout (RightToLeft or LeftToRight)
        /// </summary>
        public FlowDirection ButtonWrappingFlowDirection
        {
            get => _buttonWrappingFlowDirection;
            set => this.RaiseAndSetIfChanged(ref _buttonWrappingFlowDirection, value);
        }

        private double _buttonTextFontSize = 14;
        /// <summary>
        /// Gets or sets the font size for the text displayed on buttons
        /// </summary>
        public double ButtonTextFontSize
        {
            get => _buttonTextFontSize;
            set => this.RaiseAndSetIfChanged(ref _buttonTextFontSize, value);
        }

        #endregion
    }
}
