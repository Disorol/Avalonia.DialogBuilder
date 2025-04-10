# Avalonia.DialogBuilder

A lightweight dialog builder library for Avalonia applications that provides a fluent interface for creating customizable dialog windows.

## Features
- Fluent API for dialog configuration
- Pre-styled dialog types (Error, Warning, Information, Success)
- Support for multiple buttons with custom actions
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
var result = await DialogBox.ShowAsync(new DialogBoxViewModelBuilder()
    .SetText("Do you want to save changes?")
    .SetButtons(
        new DialogButton { Text = "Save", CommandParameter = true },
        new DialogButton { Text = "Cancel", CommandParameter = false }
    )
    .Build());

if ((bool)result.Parameter)
{
    // Handle save
}
```

Pre-styled error dialog:
```csharp
await DialogBox.ShowAsync(new DialogBoxViewModelBuilder()
    .UseDirector(new ErrorDialogBoxDirector())
    .SetText("Failed to connect to the server.")
    .SetButtons(new DialogButton { Text = "OK" })
    .Build());
```

Dialog with custom control:
```csharp
await DialogBox.ShowAsync(new DialogBoxViewModelBuilder()
    .UseDirector(new InformationDialogBoxDirector())
    .SetControl(new MyCustomControl())
    .SetButtons(new DialogButton { Text = "Close" })
    .Build());
```

### Customization

Styling and layout:
```csharp
var dialog = new DialogBoxViewModelBuilder()
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