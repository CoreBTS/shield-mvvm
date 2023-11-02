using CoreBTS.Maui.ShieldMVVM.Navigation;
using MauiSample.Features.Main;

namespace MauiSample;

public partial class App : Application
{
    private readonly INavigationService _navigationService;

    public App(INavigationService navigation)
    {
        _navigationService = navigation;

        InitializeComponent();

        MainPage = new AppShell();
    }

    protected override async void OnStart()
    {
        base.OnStart();

        await _navigationService.NavigateToAsync<MainPageViewModel, MainPageArgs>(
            new MainPageArgs(new Random().Next(1, 10)), mustClearNavigationStack: true);
    }
}