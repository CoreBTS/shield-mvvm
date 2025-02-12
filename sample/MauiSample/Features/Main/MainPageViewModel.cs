using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.Input;
using CoreBTS.Maui.ShieldMVVM.ActionSheet;
using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using MauiSample.Features.About;
using MauiSample.Features.Main.Dialog;
using System.Reflection;
using System.Reflection.Metadata;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

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
        //Commented out lines are for generating extension methods for Maui/CommunitToolkit controls
        //GenerateCode();

        Counter++;
        RaisePropertyChanged(nameof(ButtonText));
        UpdateSecondary();
    }

    private static void GenerateCode()
    {
        var assemblies = new List<Assembly> { typeof(Button).Assembly, typeof(Popup).Assembly };

        var bp = typeof(BindableProperty);
        foreach (var assembly in assemblies)
        {
#pragma warning disable IDE0028 // Simplify collection initialization - Don't want to indent everything to much below
            var output = new List<string>();
#pragma warning restore IDE0028 // Simplify collection initialization

            output.Add("    // ********** IBindableLayout Bindings **********");
            output.Add("");

            output.Add(GenerateCodeSnippet(
                assembly,
                type => !type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IBindableLayout)) || type.ContainsGenericParameters || type.IsNotPublic,
                typeName => $@"    /// <summary>
    /// Allows binding to the ItemsSourceProperty as BindItemsSource for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IEnumerable.</returns>",
                typeName => $"    public static Bindings.BindableProperty<IEnumerable<T>> BindItemsSource<T>(this {typeName} _) => Bindings.BindableProperty<IEnumerable<T>>.Create(BindableLayout.ItemsSourceProperty);"));

            output.Add(GenerateCodeSnippet(
                assembly,
                type => !type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IBindableLayout)) || type.ContainsGenericParameters || type.IsNotPublic,
                typeName => $@"    /// <summary>
    /// Allows binding to the ItemTemplateProperty as BindItemTemplate for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DataTemplate.</returns>",
                typeName => $"    public static Bindings.BindableProperty<T> BindItemTemplate<T>(this {typeName} _) where T : DataTemplate => Bindings.BindableProperty<T>.Create(BindableLayout.ItemTemplateProperty);"));

            output.Add(GenerateCodeSnippet(
                assembly,
                type => !type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IBindableLayout)) || type.ContainsGenericParameters || type.IsNotPublic,
                typeName => $@"    /// <summary>
    /// Allows binding to the ItemTemplateSelectorProperty as BindItemTemplateSelector for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DataTemplateSelector.</returns>",
                typeName => $"    public static Bindings.BindableProperty<T> BindItemTemplateSelector<T>(this {typeName} _) where T : DataTemplateSelector => Bindings.BindableProperty<T>.Create(BindableLayout.ItemTemplateSelectorProperty);"));

            output.Add(GenerateCodeSnippet(
                assembly,
                type => !type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IBindableLayout)) || type.ContainsGenericParameters || type.IsNotPublic,
                typeName => $@"    /// <summary>
    /// Allows binding to the EmptyViewProperty as BindEmptyView for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type object.</returns>",
                typeName => $"    public static Bindings.BindableProperty<T> BindEmptyView<T>(this {typeName} _) => Bindings.BindableProperty<T>.Create(BindableLayout.EmptyViewProperty);"));

            output.Add(GenerateCodeSnippet(
                assembly,
                type => !type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IBindableLayout)) || type.ContainsGenericParameters || type.IsNotPublic,
                typeName => $@"    /// <summary>
    /// Allows binding to the EmptyViewTemplateProperty as BindEmptyViewTemplate for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DataTemplate.</returns>",
                typeName => $"    public static Bindings.BindableProperty<T> BindEmptyViewTemplate<T>(this {typeName} _) where T : DataTemplate => Bindings.BindableProperty<T>.Create(BindableLayout.EmptyViewTemplateProperty);"));

            output.Add("    // ********** IGestureRecognizers Bindings **********");
            output.Add("");

            output.Add(GenerateCodeSnippet(
                assembly,
                type => !type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IGestureRecognizers)) || type.ContainsGenericParameters || type.IsNotPublic || type.GetProperty("CommandParameter", BindingFlags.Public | BindingFlags.Instance) == null,
                typeName => $@"    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>",
                typeName => $"    public static Bindings.BindableProperty<ICommand> BindClick(this {typeName} _) => Bindings.BindableProperty<ICommand>.Create({typeName}.CommandProperty);"));

            output.Add("    // ********** Bindable Properties **********");
            output.Add("");

            output.Add(GenerateBindablePropertyCodeSnippet(
                assembly,
                type => !type.IsAssignableTo(typeof(BindableObject)) || type.ContainsGenericParameters || type.IsNotPublic,
                (member, typeName) => $@"    /// <summary>
    /// Allows binding to the {member.Name} as Bind{member.Name.Replace("Property", "")} for the {typeName} control.
    /// </summary>
    /// <param name=""_"">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type {typeName}.</returns>",
                (member, bindableType, typeName) => $"    public static Bindings.{bindableType} Bind{member.Name.Replace("Property", "")}(this {typeName} _) => Bindings.{bindableType}.Create({typeName}.{member.Name});"));

            string result = string.Join(Environment.NewLine, output);
        }
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

    [RelayCommand]
    public async Task Alert()
    {
        await NavigationService.ShowAlertAsync("Alert message", "Alert Title");
    }

    public override void Prepare(MainPageArgs parameters)
    {
        Counter = parameters.InitialCounter;
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    private static string GenerateCodeSnippet(
        Assembly assemblyToCheck, Func<Type, bool> shouldSkipProcessCallback, Func<string, string> commentLines, Func<string, string> codeLineCallback)
    {
        var output = new List<string>();

        foreach (var type in assemblyToCheck.GetTypes())
        {
            if (shouldSkipProcessCallback(type))
                continue;

            var typeName = GetTypeName(type);
            output.Add(commentLines(typeName));

            if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
                output.Add($"    [Obsolete(\"{obsolete.Message}\")]");

            output.Add(codeLineCallback(typeName));
            output.Add("");
        }

        var text = string.Join(Environment.NewLine, output);
        return text;
    }

    private static string GenerateBindablePropertyCodeSnippet(
        Assembly assemblyToCheck, Func<Type, bool> shouldSkipProcessCallback, Func<FieldInfo, string, string> commentLines, Func<FieldInfo, string, string, string> codeLineCallback)
    {
        var bp = typeof(BindableProperty);

        var output = new StringBuilder();

        foreach (var type in assemblyToCheck.GetTypes())
        {
            if (shouldSkipProcessCallback(type))
                continue;

            if (type == typeof(StatusBarBehavior)) // Version issues
                continue;
            if (type.Name == "AppThemeProxy") // AppThemeBinding is a private class, so can't generate against it
                continue;

            var members = type.GetFields(BindingFlags.Static | BindingFlags.Public).OrderBy(a => a.Name);
            if (!members.Any())
                continue;

            var typeName = GetTypeName(type);

            var hasCreatedHeader = false;

            foreach (var member in members)
            {
                if (member.FieldType != bp)
                    continue;

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

                output.AppendLine(commentLines(member, typeName));

                if (type.GetCustomAttributes(true).FirstOrDefault(a => a is ObsoleteAttribute) is ObsoleteAttribute obsolete)
                    output.AppendLine($"    [Obsolete(\"{obsolete.Message}\")]");

                output.AppendLine(codeLineCallback(member, bindableType, typeName));
                output.AppendLine("");
            }
        }

        var text = output.ToString();
        return text;
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