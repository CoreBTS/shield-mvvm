namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// This interface defines all common methods shared by all Page View Models.
/// </summary>
public interface IPageViewModelBase : IViewModelBase
{
    /// <summary>
    /// Gets whether the InitializeAsync method is called before page is created (true) or after (false).
    /// </summary>
    bool IsInitializeCalledBeforePageIsCreated { get; }

    /// <summary>
    /// A method that fires whenever the page is appearing to the user from a non-visible state.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task OnViewAppearing(CancellationToken token = default);

    /// <summary>
    /// A method that fires whenever the page is disappearing from the user from a visible state.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task OnViewDisappearing(CancellationToken token = default);
}

/// <summary>
/// This interface is used by a ViewModel that doesn't take an arg parameter nor returns a result.
/// </summary>
public interface IPageViewModel : IPageViewModelBase
{
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter but doesn't return a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
public interface IPageViewModel<in TParameter> : IPageViewModelBase
{
    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    void Prepare(TParameter parameters);
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter and returns a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
/// <typeparam name="TResult">The type of result the ViewModel returns.</typeparam>
public interface IPageViewModel<in TParameter, TResult> : IPageViewModelBase
{
    /// <summary>
    /// Gets a TaskCompletionSource that allows a Navigation call to return a result.
    /// </summary>
    internal TaskCompletionSource<TResult> TaskCompletionSource { get; set; }

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    void Prepare(TParameter parameters);
}