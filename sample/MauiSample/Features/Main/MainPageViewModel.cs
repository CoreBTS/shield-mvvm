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
            if (!type.IsAssignableTo(typeof(IGestureRecognizers)) || type.ContainsGenericParameters || type.IsNotPublic)
                continue;

            if (type.GetProperties().Any(a => a.Name == "Command"))
                continue;

            output.Add($"            public static Bindings.BindableProperty<ICommand> BindClick(this {type.Name} _) => new(Controls.ClickableControl<{type.Name}>.CommandProperty);");
        }
        var text = string.Join(Environment.NewLine, output.Distinct());
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

            var members = type.GetFields(System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Public).OrderBy(a => a.Name);
            if (!members.Any())
                continue;

            output.AppendLine($"    // {type.Name} Bindings");
            output.AppendLine("");

            foreach (var member in members)
            {
                if (member.FieldType == bp)
                {
                    var bpValue = member.GetValue(null) as BindableProperty;
                    if (bpValue.ReturnType.IsNotPublic)
                        continue;

                    var bindableType = $"BindableProperty{GetProperTypeName(bpValue.ReturnType.Name, bpValue.ReturnType.GenericTypeArguments)}";
                    output.AppendLine($"        public static Bindings.{bindableType} Bind{member.Name.Replace("Property", "")}(this {type.Name} _) => {bindableType}.Create({type.Name}.{member.Name});");
                }
            }
            output.AppendLine("");
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

            output.AppendLine($"    // {type.Name} Bindings");
            output.AppendLine("");

            foreach (var member in members)
            {
                if (member.FieldType == bp)
                {
                    var bpValue = member.GetValue(null) as BindableProperty;
                    if (bpValue.ReturnType.IsNotPublic)
                        continue;

                    var bindableType = $"BindableProperty{GetProperTypeName(bpValue.ReturnType.Name, bpValue.ReturnType.GenericTypeArguments)}";
                    output.AppendLine($"        public static {bindableType} Bind{member.Name.Replace("Property", "")}(this {type.Name} _) => {bindableType}.Create({type.Name}.{member.Name});");
                }
            }
            output.AppendLine("");
        }

        var text = output.ToString();
    }

    private static string GetProperTypeName(string val, Type[] genericTypes)
    {
        var result = NameFix($"<{val}>");

        if (genericTypes == null || genericTypes.Length == 0)
            return result;

        for (int i = 0; i < genericTypes.Length; i++)
        {
            result = result.Replace($"`{i + 1}", $"<{GetGenericName(genericTypes[i])}>");
        }

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