using Avalonia.Controls;
using Avalonia.DialogBuilder.Builders;
using Avalonia.DialogBuilder.ViewModels;
using Avalonia.Platform;

namespace Avalonia.DialogBuilder.Directors
{
    public class InformationDialogBoxDirector : IDialogBoxDirector
    {
        private static readonly WindowIcon s_icon = new WindowIcon(AssetLoader.Open(new Uri("avares://Avalonia.DialogBuilder/Assets/Icons/information.ico")));

        public DialogBoxViewModel Build(IDialogBoxViewModelBuilder builder)
        {
            return builder.SetIcon(s_icon)
                          .SetTitle("TODO")
                          .Build();
        }
    }
}
