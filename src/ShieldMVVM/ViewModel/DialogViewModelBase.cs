using CommunityToolkit.Mvvm.Input;
using CoreBTS.Maui.ShieldMVVM.Navigation;

namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// This base class is used by a DialogViewModel that defines common, dialog-related methods.
/// </summary>
public abstract class BaseDialogViewModelBase : BaseViewModelBase
{
    /// <summary>
    /// This event fires when the dialog should be closed.
    /// </summary>
    public event EventHandler? Close;

    /// <summary>
    /// Constructor that takes the NavigationService in order to navigate between View Models.
    /// </summary>
    /// <param name="navigationService">The service used for navigation.</param>
    protected BaseDialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
        CloseCommand = new RelayCommand(CloseDialog);
    }

    /// <summary>
    /// Gets the command to run to close the dialog.
    /// </summary>
    public IRelayCommand CloseCommand { get; }

    /// <summary>
    /// Closes the dialog.
    /// </summary>
    protected virtual void CloseDialog() =>
        Close?.Invoke(this, EventArgs.Empty);
}

/// <summary>
/// This base class is used by a ViewModel that doesn't take an arg parameter nor returns a result.
/// </summary>
public abstract class DialogViewModelBase : BaseDialogViewModelBase, IDialogViewModel
{
    /// <summary>
    /// Constructor that takes the NavigationService in order to navigate between View Models.
    /// </summary>
    /// <param name="navigationService">The service used for navigation.</param>
    protected DialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter but doesn't return a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
public abstract class DialogViewModelBase<TParameter> : BaseDialogViewModelBase, IDialogViewModel<TParameter>
{
    /// <summary>
    /// Constructor that takes the NavigationService in order to navigate between View Models.
    /// </summary>
    /// <param name="navigationService">The service used for navigation.</param>
    protected DialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    public abstract void Prepare(TParameter parameters);
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter and returns a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
/// <typeparam name="TResult">The type of result the ViewModel returns.</typeparam>
public abstract class DialogViewModelBase<TParameter, TResult> : BaseDialogViewModelBase, IDialogViewModel<TParameter, TResult>
{
    /// <summary>
    /// Constructor that takes the NavigationService in order to navigate between View Models.
    /// </summary>
    /// <param name="navigationService">The service used for navigation.</param>
    protected DialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    public abstract void Prepare(TParameter parameters);

    /// <summary>
    /// Gets or sets the result of the dialog running.
    /// </summary>
    public TResult? Result { get; set; }

    /// <summary>
    /// Allows the result to be calculated and set before the dialog is fully closed.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public virtual Task SetResultAsync(CancellationToken token = default) => Task.CompletedTask;
}