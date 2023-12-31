﻿using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
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

    [ObservableProperty]
    [NotifyPropertyChangedFor(nameof(ButtonText))]
    private int _counter = 0;

    public MainPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        Secondary = new SecondaryViewModel(NavigationService) { MyLabel = "Secondary Test" };
    }

    [RelayCommand]
    protected virtual void Click()
    {
        GenerateBindingText();
        GenerateBindingToolkitText();
        GenerateBindingClickableControlText();
        GenerateToolkitBindingClickableControlText();
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

        Counter = result.Counter;
        UpdateSecondary();
    }

    public override void Prepare(MainPageArgs parameters)
    {
        Counter = parameters.InitialCounter;
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    public static void GenerateBindingClickableControlText()
    {
        var bp = typeof(IGestureRecognizers);
        var output = new List<string>();

        foreach (var type in typeof(Button).Assembly.GetTypes().OrderBy(a => a.Name))
        {
            if (!type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IGestureRecognizers)) || type.ContainsGenericParameters || type.IsNotPublic)
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

            output.Add($"    public static Bindings.BindableProperty<ICommand> BindClick(this {typeName} _) => new(Controls.ClickableControl<{typeName}>.CommandProperty);");
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
            if (!type.IsPublic || !type.IsAssignableTo(typeof(BindableObject)) || !type.IsAssignableTo(typeof(IGestureRecognizers)) || type.ContainsGenericParameters || type.IsNotPublic)
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

            output.Add($"    public static Bindings.BindableProperty<ICommand> BindClick(this {typeName} _) => new(Controls.ClickableControl<{typeName}>.CommandProperty);");
            output.Add("");
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

                    var bpValue = member.GetValue(null) as BindableProperty;
                    if (bpValue.ReturnType.IsNotPublic)
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
                    if (bpValue.ReturnType.IsNotPublic)
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
        if (type.FullName.Contains("Compatibility"))
            return type.FullName.Trim();

        return type.Name;
    }

    private static string GetProperTypeName(Type val, Type[] genericTypes)
    {
        var typeName = val.FullName.Contains("Compatibility") ? val.FullName.Trim() : val.Name;
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

public partial class SecondaryViewModel : BaseViewModelBase
{
    public SecondaryViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    [ObservableProperty]
    private string _myLabel;

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }
}