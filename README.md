# Avalonia.DialogBuilder

A lightweight dialog builder library for Avalonia applications that provides a fluent interface for creating customizable dialog windows.

## Features
- Fluent API for dialog configuration
- Pre-styled dialog types (Error, Warning, Information, Success)
<<<<<<< HEAD
- Support for multiple buttons with custom actions
=======
- Support for multiple buttons
>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
- Custom content support (text or controls)
- Flexible styling and layout options
- Global dialog settings

## Getting Started

### Installation
```bash
dotnet add package Avalonia.DialogBuilder
```

<<<<<<< HEAD
=======
## Dialog Setup with ReactiveUI

To use dialogs in your application, you need to set up three components:

### 1. Window Class
Your window must inherit from `ReactiveWindow<TViewModel>` where `TViewModel` is your window's view model type:
```csharp
public partial class MainWindow : ReactiveWindow<MainWindowViewModel>
```

### 2. ViewModel Setup
In your window's view model, declare an Interaction property that will handle dialog operations:

```csharp
public Interaction<DialogBoxViewModel, DialogBoxResult?> ShowDialog { get; } = new();
```

This property acts as a bridge between your view model and the actual dialog window.

### 3. Dialog Handler in Window
In your window's code-behind, implement the dialog showing logic:

```csharp
public MainWindow()
{
    InitializeComponent();
    
    // Register dialog handler
    this.WhenActivated(action => 
        action(ViewModel!.ShowDialog.RegisterHandler(DoShowDialogAsync)));
}

private async Task DoShowDialogAsync(
    IInteractionContext<DialogBoxViewModel, DialogBoxResult?> interaction)
{
    var dialog = new DialogBoxView
    {
        DataContext = interaction.Input
    };

    var result = await dialog.ShowDialog<DialogBoxResult?>(this);
    interaction.SetOutput(result);
}
```

This setup creates a proper MVVM-friendly dialog system

>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
### Basic Usage

Simple dialog with text:
```csharp
<<<<<<< HEAD
var result = await DialogBox.ShowAsync(new DialogBoxViewModelBuilder()
    .SetText("Do you want to save changes?")
    .SetButtons(
        new DialogButton { Text = "Save", CommandParameter = true },
        new DialogButton { Text = "Cancel", CommandParameter = false }
    )
    .Build());

if ((bool)result.Parameter)
=======
var builder = new DialogBoxViewModelBuilder().SetText("Do you want to save changes?")
                                             .SetButtons(
                                                 new DialogButtonBase { Text = "Save", CommandParameter = true },
                                                 new DialogButtonBase { Text = "Cancel", CommandParameter = false });
var director = new WarningDialogBoxDirector();
DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
DialogBoxResult result = await ShowTestDialog.Handle(dialogBoxViewModel);

if (result.Parameter is true)
>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
{
    // Handle save
}
```

Pre-styled error dialog:
```csharp
<<<<<<< HEAD
await DialogBox.ShowAsync(new DialogBoxViewModelBuilder()
    .UseDirector(new ErrorDialogBoxDirector())
    .SetText("Failed to connect to the server.")
    .SetButtons(new DialogButton { Text = "OK" })
    .Build());
=======
var builder = new DialogBoxViewModelBuilder().SetText("Failed to connect to the server.")
                                             .SetButtons(
                                                 new DialogButtonBase { Text = "OK" });
var director = new ErrorDialogBoxDirector();
DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
await ShowTestDialog.Handle(dialogBoxViewModel);
>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
```

Dialog with custom control:
```csharp
<<<<<<< HEAD
await DialogBox.ShowAsync(new DialogBoxViewModelBuilder()
    .UseDirector(new InformationDialogBoxDirector())
    .SetControl(new MyCustomControl())
    .SetButtons(new DialogButton { Text = "Close" })
    .Build());
=======
var viewModel = new TestViewModel();
var view = new TextView();
view.DataContext = viewModel;
var builder = new DialogBoxViewModelBuilder().SetControl(view)
                                             .SetButtons(new DialogButtonBase { Text = "Close" });
var director = new InformationDialogBoxDirector();
DialogBoxViewModel dialogBoxViewModel = director.Build(builder);
await ShowTestDialog.Handle(dialogBoxViewModel);
>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
```

### Customization

Styling and layout:
```csharp
<<<<<<< HEAD
var dialog = new DialogBoxViewModelBuilder()
=======
var builder = new DialogBoxViewModelBuilder()
>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
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

<<<<<<< HEAD
## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.
```
=======
## Example Project

The repository includes a TestingProject that demonstrates:
- Complete setup of ReactiveUI Interactions for dialog handling
- Practical examples of using Avalonia.DialogBuilder in a real application
- Implementation of various dialog types and configurations
- Proper MVVM architecture with dialog handling

You can use this project as a reference for integrating the library into your own applications.
>>>>>>> d38c4ef82ee81bb3b6934e0478afbb9ad3949b75
