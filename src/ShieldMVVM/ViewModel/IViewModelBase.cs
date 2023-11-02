using System.ComponentModel;

namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// The base ViewModel interface that defines all the common methods all ViewModels have.
/// </summary>
public interface IViewModelBase : INotifyPropertyChanging, INotifyPropertyChanged
{
    /// <summary>
    /// Gets or sets that the ViewModel is currently busy running something that might take a while.
    /// </summary>
    bool IsBusy { get; set; }

    /// <summary>
    /// This method only fires once when the ViewModel is first created and before the page is created.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task InitializeAsync(CancellationToken token = default);

    /// <summary>
    /// A method that only fires once when the ViewModel is assigned to a created page.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task OnViewCreated(CancellationToken token = default);
}