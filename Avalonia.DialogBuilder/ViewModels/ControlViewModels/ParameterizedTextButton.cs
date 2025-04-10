namespace Avalonia.DialogBuilder.ViewModels
{
    /// <summary>
    /// Base class for buttons that have both text and command parameter
    /// </summary>
    public class ParameterizedTextButton : IParameterizedButton, ITextButton
    {
        /// <summary>
        /// Gets or sets the parameter to be passed to the button's command when executed
        /// </summary>
        public object? CommandParameter { get; set; }

        /// <summary>
        /// Gets or sets the text displayed on the button
        /// </summary>
        public string? Text { get; set; }
    }
}
