using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using MauiSample.Features.About.Cells;
using System.Collections.ObjectModel;

namespace MauiSample.Features.About;

public partial class AboutPageViewModel : PageViewModelBase<AboutPageArgs, AboutPageResult>
{
    public AboutPageViewModel(INavigationService navigationService) : base(navigationService)
    {
        DoneCommand = new AsyncRelayCommand(DoDoneCommand);
    }

    public IAsyncRelayCommand DoneCommand { get; }

    public int Counter { get; protected set; }

    [ObservableProperty]
    private ObservableCollection<AboutItem> _aboutItems;

    public override void Prepare(AboutPageArgs parameters)
    {
        Counter = parameters.Counter;
    }

    public override Task InitializeAsync(CancellationToken token = default)
    {
        AboutItems = new ObservableCollection<AboutItem>
        {
            new() { Name = "Test1", Description = "Desc 1" },
            new() { Name = "Test2", Description = "Desc 2" },
            new() { Name = "Test3", Description = "Desc 3" },
            new() { Name = "Test4", Description = "Desc 4" },
        };

        return Task.CompletedTask;
    }

    private async Task DoDoneCommand() =>
        await GoBackAsync(new AboutPageResult(--Counter));

    [RelayCommand]
    private void Add() =>
        AboutItems.Add(new() { Name = Guid.NewGuid().ToString(), Description = "Test" });

    [RelayCommand]
    private void Selected(AboutItem item) =>
       AboutItems.Add(item);
}