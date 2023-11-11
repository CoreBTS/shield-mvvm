using CoreBTS.Maui.ShieldMVVM.Bindings;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace CoreBTS.Maui.ShieldMVVM.Pages;

/// <summary>
/// This defines content pages that are tied to a specific ViewModel.
/// </summary>
/// <typeparam name="TViewModel">The type of ViewModel the page is tied to.</typeparam>
public abstract class ContentPageBase<TViewModel> : ContentPage
    where TViewModel : IPageViewModelBase
{
    /// <summary>
    /// Constructor that takes the ViewModel to assign to the BindingContext.
    /// </summary>
    /// <param name="viewModel">The ViewModel the page is bound to.</param>
    protected ContentPageBase(TViewModel viewModel)
    {
        SetControlTemplate();

        BindingContext = viewModel;
        Binder = BindingHelper.Create(viewModel);

        CreateControls();

        if (RunSetupBindings)
            SetupBindings();

        ViewModel.OnViewCreated();
    }

    /// <summary>
    /// Gets whether to run the SetupBindings method in the constructor.
    /// </summary>
    protected virtual bool RunSetupBindings => true;

    /// <summary>
    /// Gets the ViewModel the page is tied to.
    /// </summary>
    protected TViewModel ViewModel => (TViewModel)BindingContext;

    /// <summary>
    /// Gets the BindingHelper to add control bindings from the ViewModel.
    /// </summary>
    protected BindingHelper<TViewModel> Binder { get; }

    /// <summary>
    /// This methods should be used to define all control bindings.
    /// </summary>
    protected abstract void SetupBindings();

    /// <summary>
    /// This method should be used to set the ControlTemplate property, if applicable.
    /// </summary>
    protected virtual void SetControlTemplate() { }

    /// <summary>
    /// Calls InitializeComponent.
    /// </summary>
    protected virtual void CreateControls() => this.CallInitializeComponent();

    /// <summary>
    /// Runs when the view is appearing.
    /// </summary>
    protected virtual void OnViewAppearing() { }

    /// <summary>
    /// Runs when the view is disappearing.
    /// </summary>
    protected virtual void OnViewDisappearing() { }

    /// <summary>
    /// A method that fires whenever the page is appearing to the user from a non-visible state.
    /// </summary>
    protected sealed override async void OnAppearing()
    {
        base.OnAppearing();
        await ViewModel.OnViewAppearing();
        OnViewAppearing();
    }

    /// <summary>
    /// A method that fires whenever the page is disappearing from the user from a visible state.
    /// </summary>
    protected sealed override async void OnDisappearing()
    {
        base.OnDisappearing();
        await ViewModel.OnViewDisappearing();
        OnViewDisappearing();
    }
}