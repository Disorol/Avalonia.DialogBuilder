using Avalonia.Controls;
using Avalonia.Media;
using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.DialogBuilder.ViewModels
{
    public class DialogBoxViewModel : ViewModelBase
    {
        public WindowIcon? Icon { get; set; }
        public string? Title { get; set; }

        private object? _content;
        public object? Content
        {
            get => _content;
            set => this.RaiseAndSetIfChanged(ref _content, value);
        }

        // Для обратной совместимости
        public string? Text
        {
            get => Content as string;
            set => Content = value;
        }

        public IList<ButtonViewModel> ButtonViewModels { get; } = [];

        #region [Window Settings]

        private WindowStartupLocation _windowStartupLocation = WindowStartupLocation.CenterScreen;
        public WindowStartupLocation WindowStartupLocation
        {
            get => _windowStartupLocation;
            set => this.RaiseAndSetIfChanged(ref _windowStartupLocation, value);
        }

        private ThemeVariant _requestedThemeVariant = ThemeVariant.Light;
        public ThemeVariant RequestedThemeVariant
        {
            get => _requestedThemeVariant;
            set => this.RaiseAndSetIfChanged(ref _requestedThemeVariant, value);
        }

        private bool _canResize = false;
        public bool CanResize
        {
            get => _canResize;
            set => this.RaiseAndSetIfChanged(ref _canResize, value);
        }

        private double _maxWidth = 400;
        public double MaxWidth
        {
            get => _maxWidth;
            set => this.RaiseAndSetIfChanged(ref _maxWidth, value);
        }

        private double _maxHeight = 150;
        public double MaxHeight
        {
            get => _maxHeight;
            set => this.RaiseAndSetIfChanged(ref _maxHeight, value);
        }

        #endregion

        #region [Text Settings]

        private double _textFontSize = 14;
        public double TextFontSize
        {
            get => _textFontSize;
            set => this.RaiseAndSetIfChanged(ref _textFontSize, value);
        }

        #endregion

        #region [Button Settings]

        /// <summary>
        /// Ширина каждой кнопки. Высчитывается по ширине самой широкой кнопки.
        /// Максимальная допустимая ширина кнопки 150px.
        /// Минимальная - 100px.
        /// </summary>
        public double ButtonWidth => ButtonViewModels.Any() ? Math.Max(100,
                                     Math.Min(ButtonViewModels.Max(b => (b.Text?.Length ?? 0)) * 10, 150))
                                     : 100;

        private FlowDirection _buttonWrappingFlowDirection = FlowDirection.RightToLeft;
        public FlowDirection ButtonWrappingFlowDirection
        {
            get => _buttonWrappingFlowDirection;
            set => this.RaiseAndSetIfChanged(ref _buttonWrappingFlowDirection, value);
        }

        private double _buttonTextFontSize = 14;
        public double ButtonTextFontSize
        {
            get => _buttonTextFontSize;
            set => this.RaiseAndSetIfChanged(ref _buttonTextFontSize, value);
        }

        #endregion
    }
}
