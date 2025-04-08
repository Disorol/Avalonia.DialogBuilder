using Avalonia.Controls;
using Avalonia.DialogBuilder.ViewModels;

namespace Avalonia.DialogBuilder.Builders
{
    public interface IDialogBoxViewModelBuilder
    {
        public DialogBoxViewModel Build();
        public DialogBoxViewModelBuilder SetIcon(WindowIcon icon);
        public DialogBoxViewModelBuilder SetTitle(string title);
    }
}
