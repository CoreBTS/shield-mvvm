using CoreBTS.Maui.ShieldMVVM.Navigation;

namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// This base class is used by a PageViewModel that defines common, page-related event methods.
/// </summary>
public abstract class BasePageViewModelBase : BaseViewModelBase
{
    protected BasePageViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// Gets whether the InitializeAsync method is called before page is created (default - true) or after (false).
    /// </summary>
    public virtual bool IsInitializeCalledBeforePageIsCreated => true;

    /// <summary>
    /// A method that fires whenever the page is appearing to the user from a non-visible state.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public virtual Task OnViewAppearing(CancellationToken token = default) =>
        Task.CompletedTask;

    /// <summary>
    /// A method that fires whenever the page is disappearing from the user from a visible state.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public virtual Task OnViewDisappearing(CancellationToken token = default) =>
        Task.CompletedTask;
}

/// <summary>
/// This base class is used by a ViewModel that doesn't take an arg parameter nor returns a result.
/// </summary>
public abstract class PageViewModelBase : BasePageViewModelBase, IPageViewModel
{
    protected PageViewModelBase(INavigationService navigationService) : base(navigationService) 
    {
    }

    /// <summary>
    /// Navigates the user back to the previous page.
    /// </summary>
    /// <param name="isAnimated">True if the transition back is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    protected Task GoBackAsync(bool isAnimated = true, CancellationToken token = default) =>
        NavigationService.NavigateBackAsync(this, isAnimated, token);
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter but doesn't return a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
public abstract class PageViewModelBase<TParameter> : BasePageViewModelBase, IPageViewModel<TParameter>
{
    protected PageViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    public abstract void Prepare(TParameter parameters);

    /// <summary>
    /// Navigates the user back to the previous page.
    /// </summary>
    /// <param name="isAnimated">True if the transition back is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    protected Task GoBackAsync(bool isAnimated = true, CancellationToken token = default) =>
        NavigationService.NavigateBackAsync(this, isAnimated, token);
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter and returns a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
/// <typeparam name="TResult">The type of result the ViewModel returns.</typeparam>
public abstract class PageViewModelBase<TParameter, TResult> : BasePageViewModelBase, IPageViewModel<TParameter, TResult>
{
    /// <summary>
    /// Gets a TaskCompletionSource that allows a Navigation call to return a result.
    /// </summary>
    public TaskCompletionSource<TResult> TaskCompletionSource { get; }

    protected PageViewModelBase(INavigationService navigationService) : base(navigationService) =>
        TaskCompletionSource = new TaskCompletionSource<TResult>();

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    public abstract void Prepare(TParameter parameters);

    /// <summary>
    /// Navigates the user back to the previous page.
    /// </summary>
    /// <param name="result">The result of the page navigation.</param>
    /// <param name="isAnimated">True if the transition back is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    protected Task GoBackAsync(TResult result, bool isAnimated = true, CancellationToken token = default) =>
        NavigationService.NavigateBackAsync(this, result, isAnimated, token);
}