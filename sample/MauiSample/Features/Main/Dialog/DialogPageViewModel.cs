using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace MauiSample.Features.Main.Dialog;

public partial class DialogPageViewModel(INavigationService navigationService) : DialogViewModelBase(navigationService)
{
    public virtual string MyLabel => "This is my dialog label";

    public override Task InitializeAsync(CancellationToken token = default) =>
        Task.CompletedTask;
}