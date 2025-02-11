using System.Runtime.CompilerServices;

namespace CoreBTS.Maui.ShieldMVVM.Behaviors;

/// <summary>
/// This class allows for creating behaviors in a type-safe way with callback functions.
/// </summary>
/// <typeparam name="TControl">The type of control the behavior applies to.</typeparam>
/// <typeparam name="TEventHandler">The type of control the behavior applies to.</typeparam>
public partial class GenericBehavior<TControl, TEventHandler> : Behavior<TControl>
    where TControl : BindableObject
{
    private readonly Func<TControl, TEventHandler?> _eventHandlerCallback;
    private readonly Action<TControl, TEventHandler?>? _attachCallback;
    private readonly Action<TControl, TEventHandler?>? _detachCallback;

    private readonly Action<string>? _propertyChangingCallback;
    private readonly Action<string>? _propertyChangedCallback;

    private TEventHandler? _eventHandler;
    
    /// <summary>
    /// Constructor that handles all the callbacks to invoke a behavior.
    /// </summary>
    /// <param name="eventHandlerCallback">The event to fire when attaching/detaching.</param>
    /// <param name="attachCallback">Callback to attach the behavior.</param>
    /// <param name="detachCallback">Callback to remove the behavior.</param>
    /// <param name="propertyChangingCallback">Fires when the bound property is about to change.</param>
    /// <param name="propertyChangedCallback">Fires after the bound property changes.</param>
    private GenericBehavior(
        Func<TControl, TEventHandler?> eventHandlerCallback,
        Action<TControl, TEventHandler?>? attachCallback = null,
        Action<TControl, TEventHandler?>? detachCallback = null,
        Action<string>? propertyChangingCallback = null,
        Action<string>? propertyChangedCallback = null)
    {
        _eventHandlerCallback = eventHandlerCallback;
        _attachCallback = attachCallback;
        _detachCallback = detachCallback;
        _propertyChangingCallback = propertyChangingCallback;
        _propertyChangedCallback = propertyChangedCallback;
    }

    /// <summary>
    /// Returns an instance of a behavior that uses callback to do the work.
    /// </summary>
    /// <param name="eventHandlerCallback">The event to fire when attaching/detaching.</param>
    /// <param name="attachCallback">Callback to attach the behavior.</param>
    /// <param name="detachCallback">Callback to remove the behavior.</param>
    /// <param name="propertyChangingCallback">Fires when the bound property is about to change.</param>
    /// <param name="propertyChangedCallback">Fires after the bound property changes.</param>
    /// <returns>A GenericBehavior.</returns>
    public static GenericBehavior<TControl, TEventHandler> Create(
        Func<TControl, TEventHandler?> eventHandlerCallback,
        Action<TControl, TEventHandler?>? attachCallback = null,
        Action<TControl, TEventHandler?>? detachCallback = null,
        Action<string>? propertyChangingCallback = null,
        Action<string>? propertyChangedCallback = null) =>
        new(eventHandlerCallback, 
            attachCallback, 
            detachCallback, 
            propertyChangingCallback, 
            propertyChangedCallback);

    /// <summary>
    /// Application developers override this method to implement the behaviors that will
    /// be associated with bindable.
    /// </summary>
    /// <param name="bindable">The bindable object to which the behavior was attached.</param>
    protected override void OnAttachedTo(TControl bindable)
    {
        _eventHandler = _eventHandlerCallback(bindable);
        _attachCallback?.Invoke(bindable, _eventHandler);

        base.OnAttachedTo(bindable);
    }

    /// <summary>
    /// Application developers override this method to remove the behaviors from bindable
    /// that were implemented in a previous call to the Microsoft.Maui.Controls.Behavior`1.OnAttachedTo(`0)
    /// method.
    /// </summary>
    /// <param name="bindable">The bindable object from which the behavior was detached.</param>
    protected override void OnDetachingFrom(TControl bindable)
    {
        _detachCallback?.Invoke(bindable, _eventHandler);

        base.OnDetachingFrom(bindable);
    }

    /// <summary>
    /// Fires when the bound property value is about to change.
    /// </summary>
    /// <param name="propertyName">The name of the property about to change.</param>
    protected override void OnPropertyChanging([CallerMemberName] string? propertyName = null)
    {
        base.OnPropertyChanging(propertyName);

        _propertyChangingCallback?.Invoke(propertyName ?? string.Empty);
    }

    /// <summary>
    /// Fires when the bound property value has changed.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected override void OnPropertyChanged([CallerMemberName] string? propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        _propertyChangedCallback?.Invoke(propertyName ?? string.Empty);
    }
}