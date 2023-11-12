namespace CoreBTS.Maui.ShieldMVVM.Behaviors;

/// <summary>
/// This class contains all the behaviors that can use generic lambda callbacks.
/// </summary>
public static partial class Behaviors
{
    /// <summary>
    /// Creates a new instance of a behavior to use.
    /// </summary>
    /// <typeparam name="TControl">The type of control the behavior applies to.</typeparam>
    /// <typeparam name="TEventHandler">The type of event handler used to handle the event..</typeparam>
    /// <param name="_">Extension parameters.</param>
    /// <param name="eventHandlerCallback">The event to fire when attaching/detaching.</param>
    /// <param name="attachCallback">Callback to attach the behavior.</param>
    /// <param name="detachCallback">Callback to remove the behavior.</param>
    /// <param name="propertyChangingCallback">Fires when the bound property is about to change.</param>
    /// <param name="propertyChangedCallback">Fires after the bound property changes.</param>
    /// <returns>A new instance of a converter.</returns>
    public static GenericBehavior<TControl, TEventHandler> Create<TControl, TEventHandler>(
        BindingBehavior<TControl> _, // Used for type inference only
        Func<TControl, TEventHandler?> eventHandlerCallback,
        Action<TControl, TEventHandler?>? attachCallback = null,
        Action<TControl, TEventHandler?>? detachCallback = null,
        Action<string>? propertyChangingCallback = null,
        Action<string>? propertyChangedCallback = null) 
        where TControl : BindableObject =>
        GenericBehavior<TControl, TEventHandler>.Create(
            eventHandlerCallback, 
            attachCallback, 
            detachCallback, 
            propertyChangingCallback, 
            propertyChangedCallback);

    /// <summary>
    /// A behavior that sets the text color of an entry depending on the text entered.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <param name="colorToChangeTo">The color to turn the text when matching callback result.</param>
    /// <param name="defaultColor">The color to use when the color change does not apply.</param>
    /// <param name="mustApplyColorCallback">Callback to determine if color should be applied.</param>
    /// <returns>A Behavior.</returns>
    public static Behavior<Entry> ApplyColorForValue(this BindingBehavior<Entry> _,
        Color colorToChangeTo,
        Color defaultColor,
        Func<string, bool>? mustApplyColorCallback = null) =>
        Create<Entry, EventHandler<TextChangedEventArgs>>(_,
            c => (sender, e) => c.TextColor = (mustApplyColorCallback ??= val => !string.IsNullOrEmpty(val))(c.Text) ? colorToChangeTo : defaultColor, 
            (c, e) => c.TextChanged += e,
            (c, e) => c.TextChanged -= e);
}