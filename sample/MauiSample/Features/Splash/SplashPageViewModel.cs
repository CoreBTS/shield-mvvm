using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using MauiSample.Features.Main;

namespace MauiSample.Features.Splash;

public partial class SplashPageViewModel(INavigationService navigationService) : PageViewModelBase(navigationService)
{
    public override bool IsInitializeCalledBeforePageIsCreated => false;

    public override async Task InitializeAsync(CancellationToken token = default)
    {
        System.Diagnostics.Trace.WriteLine("In Splash Page Navigation Event");

        await NavigationService.NavigateToAsync<MainPageViewModel, MainPageArgs>(
            new MainPageArgs(new Random().Next(1, 10)), mustClearNavigationStack: true, token: token);

        System.Diagnostics.Trace.WriteLine("Pushed new main page");
    }
}
