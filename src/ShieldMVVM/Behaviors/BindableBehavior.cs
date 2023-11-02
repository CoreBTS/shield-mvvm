namespace CoreBTS.Maui.ShieldMVVM.Behaviors;

/// <summary>
/// Defines a generic parameter to force behaviors to be type-safe.
/// </summary>
/// <typeparam name="TControl">The control the behavior is for.</typeparam>
public class BindableBehavior<TControl> where TControl : BindableObject
{
    // Used only for the Extension method in BindingHelper
    private BindableBehavior() { }
}