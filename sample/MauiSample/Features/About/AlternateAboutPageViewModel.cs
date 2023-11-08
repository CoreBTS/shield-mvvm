using CoreBTS.Maui.ShieldMVVM.Navigation;

namespace MauiSample.Features.About;

public class AlternateAboutPageViewModel : AboutPageViewModel
{
    public AlternateAboutPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    public override void Prepare(AboutPageArgs parameters)
    {
        Counter = parameters.Counter * 2;
    }
}