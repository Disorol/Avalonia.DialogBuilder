using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

namespace Avalonia.DialogBuilder.Directors
{
    public class SuccessDialogBoxDirector : IDialogBoxDirector
    {
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/checkmark.ico")));

        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle("TODO")
                          .Build();
        }
    }
}
