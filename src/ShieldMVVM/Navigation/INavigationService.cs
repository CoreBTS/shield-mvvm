using CoreBTS.Maui.ShieldMVVM.ActionSheet;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace CoreBTS.Maui.ShieldMVVM.Navigation;

/// <summary>
/// This interface defines methods to navigate to/back from a ViewModel.
/// </summary>
public interface INavigationService
{
    /// <summary>
    /// Displays an alert message on the screen.
    /// </summary>
    /// <param name="message">Message to show the user.</param>
    /// <param name="title">Title of the message.</param>
    /// <param name="acceptButtonText">Text of the accept button to show.</param>
    /// <param name="cancelButtonText">Text of the cancel button to show.</param>
    /// <param name="flowDirection">The flow direction to be used by the alert.</param>
    /// <returns>An awaitable task where if true then the user accepted the alert; false otherwise.</returns>
    Task<bool> ShowAlertAsync(string message, string? title = null, string? acceptButtonText = null, string? cancelButtonText = null, FlowDirection? flowDirection = null);

    /// <summary>
    /// Shows an action sheet to the user and returns the option selected.
    /// </summary>
    /// <param name="title">The title text to show.</param>
    /// <param name="actions">The actions to allow the user to select.</param>
    /// <returns>The chosen action; null if cancelled.</returns>
    Task<ActionSheetItem?> ShowActionSheetAsync(string title, params ActionSheetItem[] actions);

    /// <summary>
    /// Shows an action sheet to the user and returns the option selected.
    /// </summary>
    /// <param name="title">The title text to show.</param>
    /// <param name="message">The message text to show below the title.</param>
    /// <param name="actions">The actions to allow the user to select.</param>
    /// <returns>The chosen action; null if cancelled.</returns>
    Task<ActionSheetItem?> ShowActionSheetAsync(string title, string message, params ActionSheetItem[] actions);

    /// <summary>
    /// Shows a popup dialog over the top of the current page without leaving.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being popped up.</typeparam>
    /// <param name="viewModel">Instance of the view model to use directly, if available.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    Task ShowDialogPopupAsync<TViewModel>(
        TViewModel? viewModel = null,
        CancellationToken token = default)
        where TViewModel : class, IDialogViewModel;

    /// <summary>
    /// Shows a popup dialog over the top of the current page without leaving.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being popped up.</typeparam>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <param name="parameter">The setup parameter value.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    Task ShowDialogPopupAsync<TViewModel, TParameter>(
        TParameter parameter,
        CancellationToken token = default)
        where TViewModel : class, IDialogViewModel<TParameter>;

    /// <summary>
    /// Shows a popup dialog over the top of the current page without leaving.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being popped up.</typeparam>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <typeparam name="TResult">The type of result being returned.</typeparam>
    /// <param name="parameter">The setup parameter value.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task that returns the view model and result of the dialog.</returns>
    Task<TResult?> ShowDialogPopupAsync<TViewModel, TParameter, TResult>(
        TParameter parameter,
        CancellationToken token = default)
        where TViewModel : class, IDialogViewModel<TParameter, TResult>;

    /// <summary>
    /// Navigates to another ViewModel with no parameters/results.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being navigated to.</typeparam>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="mustClearNavigationStack">
    /// True if the navigation stack should be cleared after navigating; false otherwise.
    /// </param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    Task NavigateToAsync<TViewModel>(
       bool isAnimated = true,
       bool mustClearNavigationStack = false,
       CancellationToken token = default)
       where TViewModel : IPageViewModel;

    /// <summary>
    /// Navigates to another ViewModel with setup parameters and no result.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being navigated to.</typeparam>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <param name="parameter">The setup parameter value.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="mustClearNavigationStack">
    /// True if the navigation stack should be cleared after navigating; false otherwise.
    /// </param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    Task NavigateToAsync<TViewModel, TParameter>(
        TParameter parameter,
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel<TParameter>;

    /// <summary>
    /// Navigates to another ViewModel with setup parameters and expecting a result.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being navigated to.</typeparam>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <typeparam name="TResult">The type of result being returned.</typeparam>
    /// <param name="parameter">The setup parameter value.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="mustClearNavigationStack">
    /// True if the navigation stack should be cleared after navigating; false otherwise.
    /// </param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task that returns the view model and result of the page.</returns>
    Task<TResult> NavigateToAsync<TViewModel, TParameter, TResult>(
        TParameter parameter,
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel<TParameter, TResult>;

    /// <summary>
    /// Navigates to the previous page and returns the page navigated from.
    /// </summary>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task NavigateBackAsync(
        IPageViewModel viewModel, 
        bool isAnimated = true,
        CancellationToken token = default);

    /// <summary>
    /// Navigates to the previous page and returns the page navigated from.
    /// </summary>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task NavigateBackAsync<TParameter>(
        IPageViewModel<TParameter> viewModel, 
        bool isAnimated = true, 
        CancellationToken token = default);

    /// <summary>
    /// Navigates to the previous page and returns the page navigated from.
    /// </summary>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <typeparam name="TResult">The type of result being returned.</typeparam>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="result"></param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task NavigateBackAsync<TParameter, TResult>(
        IPageViewModel<TParameter, TResult> viewModel, 
        TResult result, 
        bool isAnimated = true, 
        CancellationToken token = default);

    /// <summary>
    /// Clears the entire navigation stack.
    /// </summary>
    void ClearNavigation();

    /// <summary>
    /// Navigates entire window to another ViewModel with no parameters/results.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being navigated to.</typeparam>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="mustClearNavigationStack">
    /// True if the navigation stack should be cleared after navigating; false otherwise.
    /// </param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    Task NavigateWindowToAsync<TViewModel>(
       bool isAnimated = true,
       bool mustClearNavigationStack = false,
       CancellationToken token = default)
       where TViewModel : IPageViewModel;

    /// <summary>
    /// Navigates entire window to another ViewModel with setup parameters and no result.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being navigated to.</typeparam>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <param name="parameter">The setup parameter value.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="mustClearNavigationStack">
    /// True if the navigation stack should be cleared after navigating; false otherwise.
    /// </param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    Task NavigateWindowToAsync<TViewModel, TParameter>(
        TParameter parameter,
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel<TParameter>;

    /// <summary>
    /// Navigates entire window to another ViewModel with setup parameters and expecting a result.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being navigated to.</typeparam>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <typeparam name="TResult">The type of result being returned.</typeparam>
    /// <param name="parameter">The setup parameter value.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="mustClearNavigationStack">
    /// True if the navigation stack should be cleared after navigating; false otherwise.
    /// </param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task that returns the view model and result of the page.</returns>
    Task<TResult> NavigateWindowToAsync<TViewModel, TParameter, TResult>(
        TParameter parameter,
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel<TParameter, TResult>;

    /// <summary>
    /// Navigates entire window to the previous page and returns the page navigated from.
    /// </summary>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task NavigateWindowBackAsync(
        IPageViewModel viewModel,
        bool isAnimated = true,
        CancellationToken token = default);

    /// <summary>
    /// Navigates entire window to the previous page and returns the page navigated from.
    /// </summary>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task NavigateWindowBackAsync<TParameter>(
        IPageViewModel<TParameter> viewModel,
        bool isAnimated = true,
        CancellationToken token = default);

    /// <summary>
    /// Navigates entire window to the previous page and returns the page navigated from.
    /// </summary>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <typeparam name="TResult">The type of result being returned.</typeparam>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="result"></param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task NavigateWindowBackAsync<TParameter, TResult>(
        IPageViewModel<TParameter, TResult> viewModel,
        TResult result,
        bool isAnimated = true,
        CancellationToken token = default);

    /// <summary>
    /// Clears the entire window navigation stack.
    /// </summary>
    void ClearWindowNavigation();
}