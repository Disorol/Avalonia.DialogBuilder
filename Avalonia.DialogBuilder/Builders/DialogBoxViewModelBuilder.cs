using Avalonia.Controls;
using Avalonia.DialogBuilder.ViewModels;
using ReactiveUI;

namespace Avalonia.DialogBuilder.Builders
{
    public class DialogBoxViewModelBuilder : IDialogBoxViewModelBuilder
    {
        protected DialogBoxViewModel _viewModel = new();

        public DialogBoxViewModel Build() => _viewModel;

        public DialogBoxViewModelBuilder SetIcon(WindowIcon icon)
        {
            _viewModel.Icon = icon;
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

        public DialogBoxViewModelBuilder SetMaxHeight(double maxHeight)
        {
            _viewModel.MaxHeight = maxHeight;
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
    }
}
