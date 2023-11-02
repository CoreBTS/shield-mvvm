namespace MauiSample.Features.Main.Dialog;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class DialogPage : DialogPageBase<DialogPageViewModel>
{
    public DialogPage(DialogPageViewModel viewModel) : base(viewModel)
    {
    }

    protected override void SetupBindings()
    {
        Binder.WithControl(MyLabel)
            .Once(c => c.BindText(), vm => vm.MyLabel);

        Binder.WithControl(CloseButton)
            .Once(c => c.BindText(), vm => "Close")
            .Once(c => c.BindClick(), vm => vm.CloseCommand);
    }
}