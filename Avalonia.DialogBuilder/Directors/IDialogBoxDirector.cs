using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;

namespace Avalonia.DialogBuilder.Directors
{
    public interface IDialogBoxDirector
    {
        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder);
    }
}
