namespace MauiSample.Features.Main.Dialog;

[XamlCompilation(XamlCompilationOptions.Compile)]
public partial class DialogPage(DialogPageViewModel viewModel) : DialogPageBase<DialogPageViewModel>(viewModel)
{
    protected override void SetupBindings()
    {
        Binder.WithControl(MyLabel)
            .Once(c => c.BindText(), vm => vm.MyLabel);

        Binder.WithControl(CloseButton)
            .Once(c => c.BindText(), vm => "Close")
            .Once(c => c.BindClick(), vm => vm.CloseCommand);
    }
}