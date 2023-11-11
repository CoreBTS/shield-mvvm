namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// This interface defines all common methods shared by all Dialog View Models.
/// </summary>
public interface IDialogViewModelBase : IViewModelBase
{
    /// <summary>
    /// This event fires when the dialog should be closed.
    /// </summary>
    event EventHandler Close;
}

/// <summary>
/// This interface is used by a ViewModel that doesn't take an arg parameter nor returns a result.
/// </summary>
public interface IDialogViewModel : IDialogViewModelBase
{
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter but doesn't return a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
public interface IDialogViewModel<in TParameter> : IDialogViewModelBase
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
public interface IDialogViewModel<in TParameter, TResult> : IDialogViewModelBase
{
    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    void Prepare(TParameter parameters);
    
    /// <summary>
    /// Gets or sets the result of the dialog running.
    /// </summary>
    TResult? Result { get; set; }

    /// <summary>
    /// Allows the result to be calculated and set before the dialog is fully closed.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    Task SetResultAsync(CancellationToken token = default);
}