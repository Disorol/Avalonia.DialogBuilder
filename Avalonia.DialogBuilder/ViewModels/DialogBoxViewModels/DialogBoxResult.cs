namespace Avalonia.DialogBuilder.ViewModels
{
    /// <summary>
    /// Represents the result of a dialog box operation, containing the parameter returned from the dialog
    /// </summary>
    /// <param name="parameter">The value returned from the dialog box</param>
    public class DialogBoxResult(object? parameter)
    {
        /// <summary>
        /// Gets or sets the parameter value returned from the dialog box
        /// </summary>
        public object? Parameter { get; set; } = parameter;
    }
}
