using CommunityToolkit.Maui.Views;
using CoreBTS.Maui.ShieldMVVM.Bindings;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace CoreBTS.Maui.ShieldMVVM.Pages;

/// <summary>
/// This defines dialog pages that are tied to a specific ViewModel.
/// </summary>
/// <typeparam name="TViewModel">The type of ViewModel the dialog is tied to.</typeparam>
public abstract class DialogPageBase<TViewModel> : Popup
    where TViewModel : IDialogViewModelBase
{
    protected DialogPageBase(TViewModel viewModel)
    {
        CanBeDismissedByTappingOutsideOfPopup = false;

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
    /// Calls InitializeComponent.
    /// </summary>
    protected virtual void CreateControls() => this.CallInitializeComponent();
}