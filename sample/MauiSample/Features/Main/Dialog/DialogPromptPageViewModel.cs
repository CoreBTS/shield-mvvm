﻿using CommunityToolkit.Mvvm.ComponentModel;
using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace MauiSample.Features.Main.Dialog;

public partial class DialogPromptPageViewModel : DialogViewModelBase<DialogPromptPageArg, DialogPromptPageResult>
{
    public DialogPromptPageViewModel(INavigationService navigationService) : base(navigationService)
    {
    }

    [ObservableProperty]
    private int _counter;

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