using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CoreBTS.Maui.ShieldMVVM.ActionSheet;
using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using MauiSample.Features.About;
using MauiSample.Features.Main.Dialog;
using System.Text;

namespace MauiSample.Features.Main;

public partial class MainPageViewModel : PageViewModelBase<MainPageArgs>
{
    public SecondaryViewModel Secondary { get; }

    public string ButtonText => $"Clicked {Counter} time{(Counter != 1 ? "s" : "")}";

    private int _counter = 0;
    public int Counter
    {
        get => _counter;
        set
        {
            if (SetProperty(ref _counter, value))
                RaisePropertyChanged(nameof(ButtonText));
        }
    }

    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        Secondary = new SecondaryViewModel(NavigationService) { MyLabel = "Secondary Test" };
    }

    [RelayCommand]
    protected virtual void Click()
    {
        //Commented out lines are for generating BindableProeprty extension methods for Maui/CommunitToolkit controls
        //GenerateBindingText();
        //GenerateBindingToolkitText();
        //GenerateBindingClickableControlText();
        //GenerateToolkitBindingClickableControlText();
        //GenerateIBindableLayout();

        Counter++;
        RaisePropertyChanged(nameof(ButtonText));
        UpdateSecondary();
    }

    private void UpdateSecondary() =>
        Secondary.MyLabel = $"Secondary {Counter}";

    [RelayCommand]
    protected virtual async Task AboutPage()
    {
        var result = 
            await NavigationService.NavigateToAsync<AboutPageViewModel, AboutPageArgs, AboutPageResult>(
                new AboutPageArgs(Counter));

        Counter = result.Counter;
        UpdateSecondary();
    }

    [RelayCommand]
    protected virtual async Task AboutAlternatePage()
    {
        var result = 
            await NavigationService.NavigateToAsync<AlternateAboutPageViewModel, AboutPageArgs, AboutPageResult>(
                new AboutPageArgs(Counter));

        Counter = result.Counter;
        UpdateSecondary();
    }

    [RelayCommand]
    public async Task Dialog1() =>
        await NavigationService.ShowDialogPopupAsync<DialogPageViewModel>();

    [RelayCommand]
    public async Task Dialog2()
    {
        var result = 
            await NavigationService.ShowDialogPopupAsync<DialogPromptPageViewModel, DialogPromptPageArg, DialogPromptPageResult>(
                new DialogPromptPageArg(Counter));

        Counter = result!.Counter;
        UpdateSecondary();
    }

    [RelayCommand]
    public async Task Action()
    {
        var result =
            await NavigationService.ShowActionSheetAsync(
                "My Title", 
                "My message",
                new ActionSheetItem("Item1", "Item 1"),
                new ActionSheetItem("Item2", "Item 2"),
                new ActionSheetItem("Item3", "Item 3"),
                new ActionSheetItem("Item4", "Item 4", Colors.Red));

        if (result != null)
        {

        }
    }

    public override void Prepare(MainPageArgs parameters)
    {
        Counter = parameters.InitialCounter;
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    public static void GenerateIBindableLayout()
    {
        var bp = typeof(IGestureRecognizers);
        var output = new List<string>();

        foreach (var type in typeof(Button).Assembly.GetTypes().OrderBy(a => a.Name))
        {
            if (!type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IBindableLayout)) || type.ContainsGenericParameters || type.IsNotPublic)
                continue;

            var typeName = GetTypeName(type);

            output.Add($@"    /// <summary>
    /// Allows binding to the ItemsSourceProperty as BindItemsSource for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IEnumerable.</returns>");

            if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
            {
                output.Add($"    [Obsolete(\"{obsolete.Message}\")]");
            }

            output.Add($"    public static Bindings.BindableProperty<IEnumerable<T>> BindItemsSource<T>(this {typeName} _) => Bindings.BindableProperty<IEnumerable<T>>.Create(BindableLayout.ItemsSourceProperty);");
            output.Add("");


            output.Add($@"    /// <summary>
    /// Allows binding to the ItemTemplateProperty as BindItemTemplate for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DataTemplate.</returns>");

            if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete2)
            {
                output.Add($"    [Obsolete(\"{obsolete2.Message}\")]");
            }

            output.Add($"    public static Bindings.BindableProperty<T> BindItemTemplate<T>(this {typeName} _) where T : DataTemplate => Bindings.BindableProperty<T>.Create(BindableLayout.ItemTemplateProperty);");
            output.Add("");


            output.Add($@"    /// <summary>
    /// Allows binding to the ItemTemplateSelectorProperty as BindItemTemplateSelector for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DataTemplateSelector.</returns>");

            if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete3)
            {
                output.Add($"    [Obsolete(\"{obsolete3.Message}\")]");
            }

            output.Add($"    public static Bindings.BindableProperty<T> BindItemTemplateSelector<T>(this {typeName} _) where T : DataTemplateSelector => Bindings.BindableProperty<T>.Create(BindableLayout.ItemTemplateSelectorProperty);");
            output.Add("");
            
        }
        var text = string.Join(Environment.NewLine, output);
    }

    public static void GenerateBindingClickableControlText()
    {
        var bp = typeof(IGestureRecognizers);
        var output = new List<string>();

        foreach (var type in typeof(Button).Assembly.GetTypes().OrderBy(a => a.Name))
        {
            if (!type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IGestureRecognizers)) || type.ContainsGenericParameters || type.IsNotPublic)
                continue;

            if (type.GetProperty("CommandParameter", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance) == null)
                continue;

            var typeName = GetTypeName(type);

            output.Add($@"    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>");

            if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
            {
                output.Add($"    [Obsolete(\"{obsolete.Message}\")]");
            }

            output.Add($"    public static Bindings.BindableProperty<ICommand> BindClick(this {typeName} _) => new({typeName}.CommandProperty);");
            output.Add("");
        }
        var text = string.Join(Environment.NewLine, output);
    }

    public static void GenerateToolkitBindingClickableControlText()
    {
        var bp = typeof(IGestureRecognizers);
        var output = new List<string>();

        foreach (var type in typeof(Popup).Assembly.GetTypes().OrderBy(a => a.Name))
        {
            try
            {
                if (!type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IGestureRecognizers)) || type.ContainsGenericParameters || type.IsNotPublic)
                    continue;

                if (type.GetProperty("CommandParameter", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance) == null)
                    continue;

                var typeName = GetTypeName(type);

                output.Add($@"    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>");

                if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
                {
                    output.Add($"    [Obsolete(\"{obsolete.Message}\")]");
                }

                output.Add($"    public static Bindings.BindableProperty<ICommand> BindClick(this {typeName} _) => new({typeName}.CommandProperty);");
                output.Add("");
            }

            catch
            {
                // Ignore
            }
        }
        var text = string.Join(Environment.NewLine, output);
    }

    public static void GenerateBindingToolkitText()
    {
        var bp = typeof(BindableProperty);

        var x = Button.CommandProperty;
        var output = new StringBuilder();

        foreach (var type in typeof(Popup).Assembly.GetTypes().OrderBy(a => a.Name))
        {
            try
            {
                if (!type.IsAssignableTo(typeof(BindableObject)) || type.ContainsGenericParameters || type.IsNotPublic)
                    continue;

                if (type == typeof(StatusBarBehavior)) // Version issues
                    continue;

                var members = type.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).OrderBy(a => a.Name);
                if (!members.Any())
                    continue;

                var typeName = GetTypeName(type);

                var hasCreatedHeader = false;

                foreach (var member in members)
                {
                    if (member.FieldType == bp)
                    {
                        if (!hasCreatedHeader)
                        {
                            output.AppendLine($"    // ***** {typeName} Bindings *****");
                            output.AppendLine("");
                            hasCreatedHeader = true;
                        }

                        try
                        {
                            var bpValue = member.GetValue(null) as BindableProperty;
                            if (bpValue!.ReturnType.IsNotPublic)
                                continue;
                            var genericType = GetProperTypeName(bpValue.ReturnType, bpValue.ReturnType.GenericTypeArguments);
                            var bindableType = $"BindableProperty{genericType}";

                            output.AppendLine($@"    /// <summary>
    /// Allows binding to the {member.Name} as Bind{member.Name.Replace("Property", "")} for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type {typeName}.</returns>");

                            if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
                            {
                                output.AppendLine($"    [Obsolete(\"{obsolete.Message}\")]");
                            }
                            output.AppendLine($"    public static Bindings.{bindableType} Bind{member.Name.Replace("Property", "")}(this {typeName} _) => Bindings.{bindableType}.Create({typeName}.{member.Name});");
                            output.AppendLine("");
                        }
                        catch
                        {
                            // Ignore
                        }
                    }
                }
            }
            catch
            {
                // Ignore
            }
        }

        var text = output.ToString();
    }

    public static void GenerateBindingText()
    {
        var bp = typeof(BindableProperty);

        var x = Button.CommandProperty;
        var output = new StringBuilder();
        foreach (var type in typeof(Button).Assembly.GetTypes().OrderBy(a => a.Name))
        {
            if (!type.IsAssignableTo(typeof(BindableObject)) || type.ContainsGenericParameters || type.IsNotPublic)
                continue;

            var members = type.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).OrderBy(a => a.Name);
            if (!members.Any())
                continue;

            var typeName = GetTypeName(type);

            var hasCreatedHeader = false;

            foreach (var member in members)
            {
                if (member.FieldType == bp)
                {
                    if (!hasCreatedHeader)
                    {
                        output.AppendLine($"    // ***** {typeName} Bindings *****");
                        output.AppendLine("");
                        hasCreatedHeader = true;
                    }

                    var bpValue = member.GetValue(null) as BindableProperty;
                    if (bpValue!.ReturnType.IsNotPublic)
                        continue;

                    var genericType = GetProperTypeName(bpValue.ReturnType, bpValue.ReturnType.GenericTypeArguments);
                    var bindableType = $"BindableProperty{genericType}";

                    output.AppendLine($@"    /// <summary>
    /// Allows binding to the {member.Name} as Bind{member.Name.Replace("Property", "")} for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type {typeName}.</returns>");
                    
                    if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
                    {
                        output.AppendLine($"    [Obsolete(\"{obsolete.Message}\")]");
                    }

                    output.AppendLine($"    public static Bindings.{bindableType} Bind{member.Name.Replace("Property", "")}(this {typeName} _) => Bindings.{bindableType}.Create({typeName}.{member.Name});");
                    output.AppendLine("");
                }
            }
        }

        var text = output.ToString();
    }

    private static string GetTypeName(Type type)
    {
        if (type.FullName!.Contains("Compatibility"))
            return type.FullName.Trim();

        return type.Name;
    }

    private static string GetProperTypeName(Type val, Type[] genericTypes)
    {
        var typeName = val.FullName!.Contains("Compatibility") ? val.FullName.Trim() : val.Name;
        var result = NameFix($"<{typeName}>");

        if (genericTypes == null || genericTypes.Length == 0)
            return result;

        for (int i = 0; i < genericTypes.Length; i++)
        {
            result = result.Replace($"`{i + 1}", $"<{GetGenericName(genericTypes[i])}>");
        }

        result = result.Replace("`1", "");

        return NameFix(result);
    }

    private static string NameFix(string val) =>
        val.Replace("<Boolean>", "<bool>").Replace("<Double>", "<double>")
            .Replace("<String>", "<string>").Replace("<Decimal>", "<decimal>").Replace("<Int32>", "<int>").Replace("<Single>", "<float>")
            .Replace("<Int16>", "<short>").Replace("<Byte>", "<byte>").Replace("<Object>", "<object>");

    private static string GetGenericName(Type type)
    {
        if (type.GenericTypeArguments == null || type.GenericTypeArguments.Length == 0)
            return type.Name;

        var generics = new List<string>();
        foreach (var t in type.GenericTypeArguments)
        {
            generics.Add(GetGenericName(t));
        }
     
        return $"{type.Name}<{string.Join(", ", generics)}>";
    }
}

public partial class SecondaryViewModel(INavigationService navigationService) : BaseViewModelBase(navigationService)
{
    private string? _myLabel;
    public string? MyLabel
    {
        get => _myLabel;
        set => SetProperty(ref _myLabel, value);
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }
}