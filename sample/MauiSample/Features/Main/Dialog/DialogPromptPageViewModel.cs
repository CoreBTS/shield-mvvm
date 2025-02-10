using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace MauiSample.Features.Main.Dialog;

public partial class DialogPromptPageViewModel(INavigationService navigationService) : DialogViewModelBase<DialogPromptPageArg, DialogPromptPageResult>(navigationService)
{
    private int _counter;
    public int Counter
    {
        get => _counter;
        set => SetProperty(ref _counter, value);
    }

    public virtual string MyLabel => "Counter Value";

    public override Task SetResultAsync(CancellationToken token = default)
    {
        Result = new DialogPromptPageResult(Counter);
        return Task.CompletedTask;
    }

    public override void Prepare(DialogPromptPageArg parameters) =>
        Counter = parameters.Counter;

    public override Task InitializeAsync(CancellationToken token = default) =>
        Task.CompletedTask;
}