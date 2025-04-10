using Avalonia.Controls.Templates;
using Avalonia.Controls;
using Avalonia.Media;

namespace Avalonia.DialogBuilder.Views
{
    public class DialogBoxViewLocator : IDataTemplate
    {
        public Control Build(object? data)
        {
            if (data is null)
                return new TextBlock { Text = "(null)", Foreground = Brushes.Gray };

            // string
            if (data is string text)
            {
                return new TextBlock
                {
                    Text = text,
                    TextWrapping = TextWrapping.Wrap
                };
            }

            // Control — возвращаем как есть
            if (data is Control control)
            {
                return control;
            }

            // ViewModel — ищем View по имени
            var vmType = data.GetType();
            var viewTypeName = vmType.FullName!.Replace("ViewModel", "View");
            var viewType = Type.GetType(viewTypeName);

            if (viewType is not null && Activator.CreateInstance(viewType) is Control view)
            {
                view.DataContext = data;
                return view;
            }

            // ничего не нашли
            return new TextBlock
            {
                Text = $"[No view found for {vmType.Name}]",
                Foreground = Brushes.Red
            };
        }

        public bool Match(object? data) => true;
    }
}
