﻿using CommunityToolkit.Mvvm.Input;
using CoreBTS.Maui.ShieldMVVM.Navigation;

namespace CoreBTS.Maui.ShieldMVVM.ViewModel;

/// <summary>
/// This base class is used by a DialogViewModel that defines common, dialog-related methods.
/// </summary>
public abstract class BaseDialogViewModelBase : BaseViewModelBase
{
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
    protected abstract void CloseDialog();
}

/// <summary>
/// This base class is used by a ViewModel that doesn't take an arg parameter nor returns a result.
/// </summary>
public abstract class DialogViewModelBase : BaseDialogViewModelBase, IDialogViewModel
{
    /// <summary>
    /// This event fires when the dialog should be closed.
    /// </summary>
    public event EventHandler Close;

    protected DialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// Closes the dialog.
    /// </summary>
    protected override void CloseDialog() =>
        Close?.Invoke(this, EventArgs.Empty);
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter but doesn't return a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
public abstract class DialogViewModelBase<TParameter> : BaseDialogViewModelBase, IDialogViewModel<TParameter>
{
    /// <summary>
    /// This event fires when the dialog should be closed.
    /// </summary>
    public event EventHandler Close;

    protected DialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    public abstract void Prepare(TParameter parameters);

    /// <summary>
    /// Closes the dialog.
    /// </summary>
    protected override void CloseDialog() =>
        Close?.Invoke(this, EventArgs.Empty);
}

/// <summary>
/// This interface is used by a ViewModel that takes an arg parameter and returns a result.
/// </summary>
/// <typeparam name="TParameter">The type of parameter the ViewModel uses to set itself up.</typeparam>
/// <typeparam name="TResult">The type of result the ViewModel returns.</typeparam>
public abstract class DialogViewModelBase<TParameter, TResult> : BaseDialogViewModelBase, IDialogViewModel<TParameter, TResult>
{
    /// <summary>
    /// This event fires when the dialog should be closed.
    /// </summary>
    public event EventHandler<TResult> Close;

    protected DialogViewModelBase(INavigationService navigationService) : base(navigationService)
    {
    }

    /// <summary>
    /// Gets the result of the dialog.
    /// </summary>
    public abstract TResult Result { get; }

    /// <summary>
    /// A method that only fires once and sets up any initial data the ViewModel requires to function.
    /// </summary>
    /// <param name="parameters">The arg data used by the ViewModel.</param>
    public abstract void Prepare(TParameter parameters);

    /// <summary>
    /// Closes the dialog.
    /// </summary>
    protected override void CloseDialog() =>
        Close?.Invoke(this, Result);
}