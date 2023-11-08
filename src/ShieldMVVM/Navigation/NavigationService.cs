using CommunityToolkit.Maui.Views;
using CoreBTS.Maui.ShieldMVVM.Pages;
using CoreBTS.Maui.ShieldMVVM.ViewModel;
using System.Collections.Concurrent;
using System.Reflection;

namespace CoreBTS.Maui.ShieldMVVM.Navigation;

/// <summary>
/// This class defines methods to navigate to/back from a ViewModel.
/// </summary>
public class NavigationService : INavigationService
{
    internal static readonly ConcurrentDictionary<Type, Type> ViewModelPageLookup = new();
    internal static readonly ConcurrentDictionary<Type, Type> ViewModelDialogPageLookup = new();

    private static readonly ConcurrentDictionary<Type, ConstructorInfo> PageConstructorLookup = new();
    private static readonly ConcurrentDictionary<Type, ConstructorInfo> DialogPageConstructorLookup = new();

    private static INavigation Navigation => Application.Current.MainPage.Navigation;
    private static Page Page => Application.Current.MainPage;

    private static readonly Type _viewModelBaseType = typeof(IViewModelBase);
    private static readonly Type _pageBaseType = typeof(ContentPageBase<>);
    private static readonly Type _dialogPageBaseType = typeof(DialogPageBase<>);

    private readonly Func<Type, dynamic> _typeResolverCallback;

    /// <summary>
    /// Constructor that takes a callback to resolve types.
    /// </summary>
    /// <param name="typeResolverCallback">The callback to an IoC container to return the resolved type.</param>
    public NavigationService(Func<Type, dynamic> typeResolverCallback) =>
        _typeResolverCallback = typeResolverCallback;

    /// <summary>
    /// Shows a popup dialog over the top of the current page without leaving.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being popped up.</typeparam>
    /// <param name="viewModel">Instance of the view model to use directly.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task with the created ViewModel.</returns>
    public async Task ShowDialogPopupAsync<TViewModel>(
        TViewModel viewModel = null,
        CancellationToken token = default)
        where TViewModel : class, IDialogViewModel
    {
        if (viewModel == null)
        {
            viewModel =
                (TViewModel)Convert.ChangeType(_typeResolverCallback(typeof(TViewModel)), typeof(TViewModel));

            await InitializeViewModel(viewModel, token);
        }

        var popup = CreateDialogPage(typeof(TViewModel), viewModel);

        await viewModel.OnViewCreated(token);

        viewModel.Close += async (sender, e) => await popup.CloseAsync();

        await Page.ShowPopupAsync(popup);
    }

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
    public async Task ShowDialogPopupAsync<TViewModel, TParameter>(
        TParameter parameter,
        CancellationToken token = default)
        where TViewModel : class, IDialogViewModel<TParameter>
    {
        var viewModel =
            (TViewModel)Convert.ChangeType(_typeResolverCallback(typeof(TViewModel)), typeof(TViewModel));

        viewModel.Prepare(parameter);

        await InitializeViewModel(viewModel, token);

        var popup = CreateDialogPage(typeof(TViewModel), viewModel);

        await viewModel.OnViewCreated(token);

        viewModel.Close += async (sender, e) => await popup.CloseAsync();

        await Page.ShowPopupAsync(popup);
    }

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
    public async Task<TResult> ShowDialogPopupAsync<TViewModel, TParameter, TResult>(
        TParameter parameter,
        CancellationToken token = default)
        where TViewModel : class, IDialogViewModel<TParameter, TResult>
    {
        var viewModel =
            (TViewModel)Convert.ChangeType(_typeResolverCallback(typeof(TViewModel)), typeof(TViewModel));

        viewModel.Prepare(parameter);

        await InitializeViewModel(viewModel, token);

        var popup = CreateDialogPage(typeof(TViewModel), viewModel);

        await viewModel.OnViewCreated(token);

        viewModel.Close += async (sender, e) => await popup.CloseAsync(e);

        var result = (TResult)await Page.ShowPopupAsync(popup);

        return result;
    }

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
    public async Task NavigateToAsync<TViewModel>(
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel
    {
        var viewModel =
            (TViewModel)Convert.ChangeType(_typeResolverCallback(typeof(TViewModel)), typeof(TViewModel));

        if (viewModel.IsInitializeCalledBeforePageIsCreated)
            await InitializeViewModel(viewModel, token);

        var page = CreatePage(typeof(TViewModel), viewModel, token);

        await viewModel.OnViewCreated(token);

        if (mustClearNavigationStack)
            ClearNavigation();

        await Navigation.PushAsync(page, isAnimated);

        if (!viewModel.IsInitializeCalledBeforePageIsCreated)
            await InitializeViewModel(viewModel, token);
    }

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
    public async Task NavigateToAsync<TViewModel, TParameter>(
        TParameter parameter,
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel<TParameter>
    {
        var viewModel =
            (TViewModel)Convert.ChangeType(_typeResolverCallback(typeof(TViewModel)), typeof(TViewModel));

        viewModel.Prepare(parameter);

        if (viewModel.IsInitializeCalledBeforePageIsCreated)
            await InitializeViewModel(viewModel, token);

        var page = CreatePage(typeof(TViewModel), viewModel, token);

        await viewModel.OnViewCreated(token);

        if (mustClearNavigationStack)
            ClearNavigation();

        await Navigation.PushAsync(page, isAnimated);

        if (!viewModel.IsInitializeCalledBeforePageIsCreated)
            await InitializeViewModel(viewModel, token);
    }

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
    public async Task<TResult> NavigateToAsync<TViewModel, TParameter, TResult>(
        TParameter parameter,
        bool isAnimated = true,
        bool mustClearNavigationStack = false,
        CancellationToken token = default)
        where TViewModel : IPageViewModel<TParameter, TResult>
    {
        var viewModel =
            (TViewModel)Convert.ChangeType(_typeResolverCallback(typeof(TViewModel)), typeof(TViewModel));

        viewModel.Prepare(parameter);

        if (viewModel.IsInitializeCalledBeforePageIsCreated)
            await InitializeViewModel(viewModel, token);

        var page = CreatePage(typeof(TViewModel), viewModel, token);

        await viewModel.OnViewCreated(token);

        if (mustClearNavigationStack)
            ClearNavigation();

        await Navigation.PushAsync(page, isAnimated);

        if (!viewModel.IsInitializeCalledBeforePageIsCreated)
            await InitializeViewModel(viewModel, token);

        var result = await viewModel.TaskCompletionSource.Task;

        return result;
    }

    /// <summary>
    /// Navigates to the previous page and returns the page navigated from.
    /// </summary>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task that returns the page navigated from.</returns>
    public async Task NavigateBackAsync(
       IPageViewModel viewModel,
       bool isAnimated = true,
       CancellationToken token = default)
    {
        await Navigation.PopAsync(isAnimated);
        await viewModel.OnViewDestroying(token);
    }

    /// <summary>
    /// Navigates to the previous page and returns the page navigated from.
    /// </summary>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task that returns the page navigated from.</returns>
    public async Task NavigateBackAsync<TParameter>(
       IPageViewModel<TParameter> viewModel,
       bool isAnimated = true,
       CancellationToken token = default)
    {
        await Navigation.PopAsync(isAnimated);
        await viewModel.OnViewDestroying(token);
    }

    /// <summary>
    /// Navigates to the previous page and returns the page navigated from.
    /// </summary>
    /// <typeparam name="TParameter">The type of setup parameter being sent.</typeparam>
    /// <typeparam name="TResult">The type of result being returned.</typeparam>
    /// <param name="viewModel">The ViewModel of the page navigating from.</param>
    /// <param name="result">The result of the ViewModel running.</param>
    /// <param name="isAnimated">True if the transition is animated; false otherwise.</param>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task that returns the page navigated from.</returns>
    public async Task NavigateBackAsync<TParameter, TResult>(
        IPageViewModel<TParameter, TResult> viewModel,
        TResult result,
        bool isAnimated = true,
        CancellationToken token = default)
    {
        await Navigation.PopAsync(isAnimated);

        if (!viewModel.TaskCompletionSource.TrySetResult(result))
            viewModel.TaskCompletionSource.SetCanceled(token);

        await viewModel.OnViewDestroying(token);
    }

    /// <summary>
    /// Clears the entire navigation stack.
    /// </summary>
    public virtual void ClearNavigation()
    {
        for (var i = Navigation.NavigationStack.Count - 1; i >= 0; i--)
        {
            var page = Navigation.NavigationStack[i];
            if (page == null)
                break;

            Navigation.RemovePage(page);
        }
    }

    private static async Task InitializeViewModel(IViewModelBase viewModel, CancellationToken token = default)
    {
        try
        {
            viewModel.IsBusy = true;
            await viewModel.InitializeAsync(token);
        }
        finally
        {
            viewModel.IsBusy = false;
        }
    }

    private Page CreatePage(
        Type viewModelType,
        dynamic viewModel,
        CancellationToken token)
    {
        var pageType = GetPageType(ViewModelPageLookup, _pageBaseType, viewModelType);

        var constructorInfo = GetPageConstructor(PageConstructorLookup, pageType, viewModelType);
        var parameters = GetConstructorParameters(viewModel, constructorInfo);
        var result = constructorInfo.Invoke(parameters.ToArray()) as Page;

        var baseVM = (IPageViewModelBase)viewModel;

        result.Appearing += async (sender, e) => await baseVM.OnViewAppearing(token);
        result.Disappearing += async (sender, e) => await baseVM.OnViewDisappearing(token);

        return result;
    }

    private Popup CreateDialogPage(Type viewModelType, dynamic viewModel)
    {
        var pageType = GetPageType(ViewModelDialogPageLookup, _dialogPageBaseType, viewModelType);

        var constructorInfo = GetPageConstructor(DialogPageConstructorLookup, pageType, viewModelType);
        var parameters = GetConstructorParameters(viewModel, constructorInfo);
        var result = constructorInfo.Invoke(parameters.ToArray()) as Popup;

        return result;
    }

    private static ConstructorInfo GetPageConstructor(
        ConcurrentDictionary<Type, ConstructorInfo> lookup,
        Type page, Type
        viewModelType)
    {
        if (lookup.TryGetValue(viewModelType, out var constructorInfo))
            return constructorInfo;

        var currentViewModelTypeCheck = viewModelType;
        constructorInfo = GetPageConstructorByType(page, currentViewModelTypeCheck);

        while (constructorInfo == null && currentViewModelTypeCheck.BaseType != null)
        {
            currentViewModelTypeCheck = currentViewModelTypeCheck.BaseType;
            constructorInfo = GetPageConstructorByType(page, currentViewModelTypeCheck);
        }

        if (constructorInfo == null)
            throw new InvalidOperationException(
                $"Must have a constructor that takes a ViewModel for page '{page.FullName}'.");

        lookup.TryAdd(viewModelType, constructorInfo);

        return constructorInfo;
    }

    private static ConstructorInfo GetPageConstructorByType(Type page, Type viewModelType) =>
        page.GetConstructors().OrderByDescending(a => a.GetParameters().Length)
                .FirstOrDefault(a => a.GetParameters().Any(a => a.ParameterType.IsAssignableTo(viewModelType)));

    private List<object> GetConstructorParameters(
        dynamic viewModel,
        ConstructorInfo constructorInfo)
    {
        var parameters = new List<object>();

        foreach (var parameter in constructorInfo.GetParameters())
        {
            if (parameter.ParameterType.IsAssignableTo(_viewModelBaseType))
            {
                parameters.Add(viewModel);
                continue;
            }

            parameters.Add(_typeResolverCallback(parameter.ParameterType));
        }

        return parameters;
    }

    private Type GetPageType(
        ConcurrentDictionary<Type, Type> pageLookup,
        Type pageBaseType,
        Type viewModelType)
    {
        if (pageLookup.TryGetValue(viewModelType, out var page))
            return page;

        Type currentType = viewModelType;
        dynamic pageCheck = _typeResolverCallback(pageBaseType.MakeGenericType(currentType));
        while (pageCheck == null && currentType != null)
        {
            currentType = viewModelType.BaseType;
            pageCheck = _typeResolverCallback(pageBaseType.MakeGenericType(currentType));
        }

        if (pageCheck == null)
            throw new InvalidOperationException(
                $"No {pageBaseType.FullName} exists for ViewModel '{viewModelType.FullName}'.");

        var pageType = pageCheck.GetType();

        pageLookup.TryAdd(viewModelType, pageType.GetType());
        return pageType;
    }
}