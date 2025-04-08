namespace Avalonia.DialogBuilder.ViewModels
{
    public class ParameterizedTextButton : IParameterizedButton, ITextButton
    {
        public object? CommandParameter { get; set; }
        public string? Text { get; set; }
    }
}
