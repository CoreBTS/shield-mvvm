namespace CoreBTS.Maui.ShieldMVVM.Converters;

/// <summary>
/// Defines a generic parameter to force converts to be type-safe.
/// </summary>
/// <typeparam name="TFrom">The type being converted from.</typeparam>
/// <typeparam name="TTo">The type being converted to.</typeparam>
public class BindingConverter<TFrom, TTo>
{
    // Used only for the Extension method in BindingHelper
    private BindingConverter() { }
}