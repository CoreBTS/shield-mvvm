namespace MauiSample.Features.Splash;

public partial class SplashPage(SplashPageViewModel viewModel) : ContentPageBase<SplashPageViewModel>(viewModel)
{
    protected override void SetupBindings()
    {
        NavigationPage.SetHasBackButton(this, false);
        NavigationPage.SetHasNavigationBar(this, false);
    }
}