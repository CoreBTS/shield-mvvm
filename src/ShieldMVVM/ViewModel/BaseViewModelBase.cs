using CommunityToolkit.Mvvm.ComponentModel;
using CoreBTS.Maui.ShieldMVVM.Navigation;

namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// This class defines common logic amongst all ViewModel types.
/// </summary>
public abstract partial class BaseViewModelBase : ObservableObject
{
    /// <summary>
    /// This event fires whenever the IsBusy property changes.
    /// </summary>
    public event EventHandler<bool> IsBusyChanged;

    protected BaseViewModelBase(INavigationService navigationService) =>
        NavigationService = navigationService;

    /// <summary>
    /// Gets the NavigationService.
    /// </summary>
    protected INavigationService NavigationService { get; }

    private bool _isBusy;
    /// <summary>
    /// Gets or sets whether the ViewModel is busy with something that the UI should alert the user about.
    /// </summary>
    public bool IsBusy
    {
        get => _isBusy;
        set
        {
            if (SetProperty(ref _isBusy, value))
                IsBusyChanged?.Invoke(this, value);
        }
    }

    /// <summary>
    /// This method only fires once when the ViewModel is first created and before the page is created.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public abstract Task InitializeAsync(CancellationToken token = default);

    /// <summary>
    /// This method only fires once when the ViewModel is assigned to a created page.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public virtual Task OnViewCreated(CancellationToken token = default) => 
        Task.CompletedTask;

    /// <summary>
    /// A method that only fires once when the ViewModel is being destroyed.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public virtual Task OnViewDestroying(CancellationToken token = default) => 
        Task.CompletedTask;

    /// <summary>
    /// Raises a PropertyChanged event for the given property.
    /// </summary>
    /// <param name="propertyName">The name of the property to raise an event for.</param>
    protected virtual void RaisePropertyChanged(string propertyName) =>
        OnPropertyChanged(propertyName);
}
