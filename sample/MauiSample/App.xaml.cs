using CoreBTS.Maui.ShieldMVVM.Navigation;
using MauiSample.Features.Splash;

namespace MauiSample;

public partial class App : Application
{
    private readonly INavigationService _navigationService;

    public App(INavigationService navigation)
    {
        _navigationService = navigation;

        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new AppShell());
    }

    protected override async void OnStart()
    {
        base.OnStart();

        await _navigationService.NavigateToAsync<SplashPageViewModel>(mustClearNavigationStack: true);
    }
}