using System.Runtime.CompilerServices;

namespace CoreBTS.Maui.ShieldMVVM.Behaviors;

/// <summary>
/// This class allows for creating converters in a type-safe way with callback functions.
/// </summary>
/// <typeparam name="TControl">The type of control the behavior applies to.</typeparam>
public class GenericBehavior<TControl> : Behavior<TControl>
    where TControl : BindableObject
{
    private readonly Func<TControl, EventHandler> _eventHandlerCallback;
    private readonly Action<TControl, EventHandler> _attachCallback;
    private readonly Action<TControl, EventHandler> _detachCallback;
    private readonly Action<string> _propertyChangingCallback;
    private readonly Action<string> _propertyChangedCallback;

    private EventHandler _eventHandler;
    
    /// <summary>
    /// Constructor that handles all the callbacks to invoke a behavior.
    /// </summary>
    /// <param name="eventHandlerCallback">The event to fire when attaching/detaching.</param>
    /// <param name="attachCallback">Callback to attach the behavior.</param>
    /// <param name="detachCallback">Callback to remove the behavior.</param>
    /// <param name="propertyChangingCallback">Fires when the bound property is about to change.</param>
    /// <param name="propertyChangedCallback">Fires after the bound property changes.</param>
    public GenericBehavior(
        Func<TControl, EventHandler> eventHandlerCallback,
        Action<TControl, EventHandler> attachCallback = null,
        Action<TControl, EventHandler> detachCallback = null,
        Action<string> propertyChangingCallback = null,
        Action<string> propertyChangedCallback = null)
    {
        _eventHandlerCallback = eventHandlerCallback;
        _attachCallback = attachCallback;
        _detachCallback = detachCallback;
        _propertyChangingCallback = propertyChangingCallback;
        _propertyChangedCallback = propertyChangedCallback;
    }

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
    protected override void OnPropertyChanging([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanging(propertyName);

        _propertyChangingCallback?.Invoke(propertyName);
    }

    /// <summary>
    /// Fires when the bound property value has changed.
    /// </summary>
    /// <param name="propertyName">The name of the property that changed.</param>
    protected override void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        base.OnPropertyChanged(propertyName);

        _propertyChangedCallback?.Invoke(propertyName);
    }
}