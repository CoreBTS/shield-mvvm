namespace MauiSample.Features.Main.Dialog;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class DialogPromptPage : DialogPageBase<DialogPromptPageViewModel>
{
    public DialogPromptPage(DialogPromptPageViewModel viewModel) : base(viewModel)
    {
        VerticalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
        HorizontalOptions = Microsoft.Maui.Primitives.LayoutAlignment.Fill;
    }

    protected override void SetupBindings()
    {
        Binder.WithControl(MyLabel)
            .Once(c => c.BindText(), vm => vm.MyLabel);

        Binder.WithControl(Counter)
            .For(c => c.BindText(), vm => vm.Counter, c => c.ConvertToString());

        Binder.WithControl(CloseButton)
            .Once(c => c.BindText(), vm => "Save")
            .Once(c => c.BindClick(), vm => vm.CloseCommand);
    }
}