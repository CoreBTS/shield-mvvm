using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using System.Windows.Input;

namespace MauiSample.Features.About;

public class AboutPageViewModel : PageViewModelBase<AboutPageArgs, AboutPageResult>
{
    public AboutPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        DoneCommand = new Command(DoDoneCommand);
    }

    public ICommand DoneCommand { get; }
    public int Counter { get; protected set; }

    public override void Prepare(AboutPageArgs parameters)
    {
        Counter = parameters.Counter;
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    private async void DoDoneCommand()
    {
        await GoBackAsync(new AboutPageResult(--Counter));
    }
}