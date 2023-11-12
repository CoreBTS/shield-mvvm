# Shield MVVM
## _Protects you with type-safety, everywhere_

Core BTS's Shield MVVM is a .NET MAUI MVVM framework that provides type-safety for navigation, bindable properties, converters, behaviors, dialogs, data templates, and more in a way that enables developers to code faster, safer, and with less lines.

### Navigation
By wrapping Microsoft MAUI's navigation, developers can do ViewModel-to-ViewModel navigation. Developers can also pass typed arguments to send data to the next ViewModel and even a typed result back when the user navigates back. The code can await where the navigation took place and the result will come back to that spot in code.

### Dialogs
With the help of the MAUI CommunityToolkit, developers can create dialog ViewModels and show them from a page ViewModel via the Navigation service. These dialogs can have full XAML support with full bindings as if they were a normal page. They can be built just like any other page and you can get a result back from showing them in a similar way to normal pages inside Shield MVVM.

### Bindable Properties
In MAUI, Bindable Properties are how all the one-way and two-way bindings get hooked up, but they are not type-safe. Shield MVVM wraps them in a type-safe/generic version of BindableProperty to guarantee the developer is binding the correct types. All the "Bind" methods will show up in Intellisense that only apply to the control you are binding and can be chained together. If a developer attempts to bind a different type, the code will not compile. However, a converter can be used inline where Intellisense shows only the possible combinations for the given types.

### Converters
Converters allow a developer to convert a value from a ViewModel into a more UI friendly version. Shield MVVM comes with type-safe/generic converters to speed up development. The basic implementation allows callbacks to be used, so developers don't have to create new classes every time. Since they are generic, they can be used to support Intellisense in code-behind bindings by making them extension methods. Finally, since these are callbacks, developers can send any number of type-safe parameters into the call in order to do the conversion - developers are not limited to just one parameter of type object.

### Behaviors
Similar to converters, Behaviors are also made type-safe/generic. They can be chained with the Bindable Properties in order to add additional functionality. Intellisense will only show you the behaviors that apply to the control you are binding to.

### Data Templates
TODO

### ClickableControl
Some controls, like labels, don't have the ability to bind clicks out of the box. Shield MVVM exposes a generic bind method to easily wrap any control that allows for gestures. This way, developers can add BindClick to almost any control directly.

### Quick Code Example

This shows a very basic page and the code you would use navigate to the page, hook everything up, and then go back to the previous page.

XAML
```xml
<?xml version="1.0" encoding="utf-8" ?>
<base:ContentPageBase xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
    xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
    xmlns:base="clr-namespace:CoreBTS.Maui.Shield MVVM.Pages;assembly=CoreBTS.Maui.Shield MVVM"
    x:Class="MauiSample.Features.About.AboutPage"
    xmlns:vm="clr-namespace:MauiSample.Features.About"
    x:TypeArguments="vm:AboutPageViewModel">
    
    <VerticalStackLayout
        HorizontalOptions="Center"
        >
        
        <Label
            Text="Previous counter value" 
            />
        
        <Label 
            x:Name="Counter" />

        <Button
            x:Name="DoneButton"
            />

    </VerticalStackLayout>
    
</base:ContentPageBase>
```

Code Behind:
```csharp
public partial class AboutPage : ContentPageBase<AboutPageViewModel>
{
    public AboutPage(AboutPageViewModel viewModel) : base(viewModel)
    {
    }

    protected override void SetupBindings()
    {
        Binder.WithControl(Counter)
            .For(c => c.BindText(), vm => vm.Counter, c => c.ConvertToString());

        Binder.WithControl(DoneButton)
            .Once(c => c.BindText(), vm => "Done");
            .For(c => c.BindCommand(), vm => vm.DoneCommand);
    }
}
```
This binds Counter (an int) to the text of the label (a string) named Counter via a converter call. It also binds the Done Button to the click (Command) event and calls DoneCommand on the View Model. With .Once, a value can be set once without actually binding, so any value can be used if wanted.

View Model:
```csharp
public class AboutPageViewModel : PageViewModelBase<AboutPageArgs, AboutPageResult>
{
    public AboutPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        DoneCommand = new Command(DoDoneCommand);
    }

    public ICommand DoneCommand { get; }
    public int Counter { get; protected set; }

    public override void Prepare(AboutPageArgs parameters)
    {
        Counter = parameters.Counter;
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    private async void DoDoneCommand()
    {
        await GoBackAsync(new AboutPageResult(--Counter));
    }
}
```

Navigating to the View Model:
```csharp
    private async Task OnAboutPageCommand()
    {
        var result = 
            await NavigationService.NavigateToAsync<AboutPageViewModel, AboutPageArgs, AboutPageResult>(
                new AboutPageArgs(Counter));

        Counter = result.Counter;
    }
```
