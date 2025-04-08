using Avalonia.Controls;
using ReactiveUI;

namespace Avalonia.DialogBuilder.ViewModels
{
    public class DialogBoxViewModel : ViewModelBase
    {
        public WindowIcon? Icon { get; set; }
        public string? Title { get; set; }
        public string? Text { get; set; }

        public double MaxHeight
        {
            get => _maxHeight;
            set => this.RaiseAndSetIfChanged(ref _maxHeight, value);
        }
        private double _maxHeight = 160;

        public IList<ButtonViewModel> ButtonViewModels { get; } = [];

        /// <summary>
        /// Ширина каждой кнопки. Высчитывается по ширине самой широкой кнопки.
        /// Максимальная допустимая ширина кнопки 150px.
        /// Минимальная - 100px.
        /// </summary>
        public double ButtonWidth => ButtonViewModels.Any() ? Math.Max(100,
                                     Math.Min(ButtonViewModels.Max(b => (b.Text?.Length ?? 0)) * 10, 150))
                                     : 100;
    }
}
