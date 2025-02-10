namespace MauiSample.Features.Main;

public partial class MainPage : ContentPageBase<MainPageViewModel>
{
    public MainPage(MainPageViewModel viewModel) : base(viewModel)
    {
        NavigationPage.SetHasBackButton(this, false);
        NavigationPage.SetHasNavigationBar(this, false);
    }

    protected override void SetupBindings()
    {
        Binder.WithControl(CounterBtn)
            .For(c => c.BindText(), vm => vm.ButtonText)
            .Once(c => c.BindClick(), vm => vm.ClickCommand);

        Binder.WithControl(NumberCounter)
            .For(c => c.BindText(), vm => vm.Counter, c => c.ConvertToString());

        Binder.WithControl(SecondaryLabel)
            .For(c => c.BindText(), vm => vm.Secondary.MyLabel, vm => vm.ConvertToNonNullString());

        Binder.WithControl(AboutPageButton)
            .Once(c => c.BindClick(), vm => vm.AboutPageCommand);

        Binder.WithControl(AboutAlternatePageButton)
            .Once(c => c.BindClick(), vm => vm.AboutAlternatePageCommand);

        Binder.WithControl(Dialog1)
            .Once(c => c.BindClick(), vm => vm.Dialog1Command);

        Binder.WithControl(Dialog2)
            .Once(c => c.BindClick(), vm => vm.Dialog2Command);
    }
}