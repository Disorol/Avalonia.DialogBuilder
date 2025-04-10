using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.Directors;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

namespace PLCSoldier.UIServices.Directors
{
    public class WarningDialogBoxDirector : IDialogBoxDirector
    {
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/warning.ico")));

        public DialogBoxViewModel Build(DialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle("TODO")
                          .Build();
        }
    }
}
