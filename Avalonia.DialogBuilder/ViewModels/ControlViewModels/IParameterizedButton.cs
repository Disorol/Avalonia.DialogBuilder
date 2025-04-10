namespace Avalonia.DialogBuilder.ViewModels
{
    /// <summary>
    /// Interface for buttons that support command parameters
    /// </summary>
    public interface IParameterizedButton
    {
        /// <summary>
        /// Gets or sets the parameter to be passed to the button's command when executed
        /// </summary>
        object? CommandParameter { get; set; }
    }
}
