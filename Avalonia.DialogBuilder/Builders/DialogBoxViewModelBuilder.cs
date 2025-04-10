using Avalonia.Controls;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Media;
using Avalonia.Styling;
using ReactiveUI;

namespace Avalonia.DialogBuilder.Builders
{
    public class DialogBoxViewModelBuilder
    {
        protected DialogBoxViewModel _viewModel = new();

        public DialogBoxViewModel Build() => _viewModel;

        public DialogBoxViewModelBuilder SetIcon(WindowIcon windowIcon)
        {
            _viewModel.Icon = windowIcon;
            return this;
        }

        public DialogBoxViewModelBuilder SetTitle(string title)
        {
            _viewModel.Title = title;
            return this;
        }

        public DialogBoxViewModelBuilder SetText(string text)
        {
            _viewModel.Text = text;
            return this;
        }

        public DialogBoxViewModelBuilder SetControl(Control control)
        {
            _viewModel.Content = control;
            return this;
        }

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

        public DialogBoxViewModelBuilder SetMaxHeight(double height)
        {
            _viewModel.MaxHeight = height;
            return this;
        }

        public DialogBoxViewModelBuilder SetMaxWidth(double width)
        {
            _viewModel.MaxWidth = width;
            return this;
        }

        public DialogBoxViewModelBuilder SetWindowStartupLocation(WindowStartupLocation windowStartupLocation)
        {
            _viewModel.WindowStartupLocation = windowStartupLocation;
            return this;
        }

        public DialogBoxViewModelBuilder SetRequestedThemeVariant(ThemeVariant themeVariant)
        {
            _viewModel.RequestedThemeVariant = themeVariant;
            return this;
        }

        public DialogBoxViewModelBuilder SetTextFontSize(double fontSize)
        {
            _viewModel.TextFontSize = fontSize;
            return this;
        }

        public DialogBoxViewModelBuilder SetButtonTextFontSize(double fontSize)
        {
            _viewModel.ButtonTextFontSize = fontSize;
            return this;
        }

        public DialogBoxViewModelBuilder SetButtonWrappingFlowDirection(FlowDirection flowDirection)
        {
            _viewModel.ButtonWrappingFlowDirection = flowDirection;
            return this;
        }

        public DialogBoxViewModelBuilder SetCanResize(bool canResize)
        {
            _viewModel.CanResize = canResize;
            return this;
        }
    }
}
