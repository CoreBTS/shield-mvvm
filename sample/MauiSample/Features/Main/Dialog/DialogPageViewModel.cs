using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace MauiSample.Features.Main.Dialog;

public class DialogPageViewModel : DialogViewModelBase
{
    public DialogPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    public virtual string MyLabel => "This is my dialog label";

    public override Task InitializeAsync(CancellationToken token = default) =>
        Task.CompletedTask;
}
