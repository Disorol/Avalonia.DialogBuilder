# Avalonia.DialogBuilder

A lightweight dialog builder library for Avalonia applications that provides a fluent interface for creating customizable dialog windows.

## Features
- Fluent API for dialog configuration
- Pre-styled dialog types (Error, Warning, Information, Success)
- Support for multiple buttons
- Custom content support (text or controls)
- Flexible styling and layout options
- Global dialog settings

## Getting Started

### Installation
```bash
dotnet add package Avalonia.DialogBuilder
```

### Basic Usage

Simple dialog with text:
```csharp
var builder = new DialogBoxViewModelBuilder().SetText("Do you want to save changes?")
                                             .SetButtons(
                                                 new DialogButtonBase { Text = "Save", CommandParameter = true },
                                                 new DialogButtonBase { Text = "Cancel", CommandParameter = false });
var director = new WarningDialogBoxDirector();
DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
DialogBoxResult result = await ShowTestDialog.Handle(dialogBoxViewModel);

if (result.Parameter is true)
{
    // Handle save
}
```

Pre-styled error dialog:
```csharp
var builder = new DialogBoxViewModelBuilder().SetText("Failed to connect to the server.")
                                             .SetButtons(
                                                 new DialogButtonBase { Text = "OK" });
var director = new ErrorDialogBoxDirector();
DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
await ShowTestDialog.Handle(dialogBoxViewModel);
```

Dialog with custom control:
```csharp
var viewModel = new TestViewModel();
var view = new TextView();
view.DataContext = viewModel;
var builder = new DialogBoxViewModelBuilder().SetControl(view)
                                             .SetButtons(new DialogButtonBase { Text = "Close" });
var director = new InformationDialogBoxDirector();
DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
await ShowTestDialog.Handle(dialogBoxViewModel);
```

### Customization

Styling and layout:
```csharp
var builder = new DialogBoxViewModelBuilder()
    .SetMaxWidth(500)
    .SetMaxHeight(400)
    .SetTextFontSize(14)
    .SetButtonTextFontSize(12)
    .SetButtonHeight(32)
    .SetCanResize(true)
    .Build();
```

Global dialog titles:
```csharp
ErrorDialogBoxDirector.Title = "Application Error";
WarningDialogBoxDirector.Title = "Warning";
InformationDialogBoxDirector.Title = "Information";
SuccessDialogBoxDirector.Title = "Success";
```

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```
