namespace MauiSample.Features.About;

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
            .For(c => c.BindCommand(), vm => vm.DoneCommand);

        Binder.WithControl(MyText)
            .Once(c => c.BindText(), vm => vm.GetType().FullName);
    }
}