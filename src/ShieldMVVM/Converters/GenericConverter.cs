using System.Globalization;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

/// <summary>
/// This class allows for creating converters in a type-safe way with callback functions.
/// </summary>
/// <typeparam name="TFrom">The type of value to convert from.</typeparam>
/// <typeparam name="TTo">The type of value to convert to.</typeparam>
public class GenericConverter<TFrom, TTo> : ValueConverterBase<TFrom, TTo>
{
    private readonly Func<TFrom, TTo> _convertTo;
    private readonly Func<TTo, TFrom>? _convertBack;

    /// <summary>
    /// Constructor that defines the callback methods to convert and convert back.
    /// </summary>
    /// <param name="convertTo">A callback method to convert from a value to a target type.</param>
    /// <param name="convertBack">A callback method to convert from the target type back to the original type.</param>
    private GenericConverter(Func<TFrom, TTo> convertTo, Func<TTo, TFrom>? convertBack = null)
    {
        _convertTo = convertTo;
        _convertBack = convertBack;
    }

    /// <summary>
    /// Returns an instance of a converter that uses callback to do conversions.
    /// </summary>
    /// <param name="convertTo">This method is called when converting from a view model to a view.</param>
    /// <param name="convertBack">This method is called when converting from a view to a view model.</param>
    /// <returns>A GenericConverter.</returns>
    public static GenericConverter<TFrom, TTo> Create(
        Func<TFrom, TTo> convertTo, 
        Func<TTo, TFrom>? convertBack = null) =>
        new(convertTo, convertBack);

    /// <summary>
    /// Converts a given value to another value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert from.</param>
    /// <param name="targetType">The type to convert to.</param>
    /// <param name="parameter">Any optional data used to help convert the value.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted value.</returns>
    public override TTo Convert(TFrom value, Type targetType, object? parameter, CultureInfo culture) =>
        _convertTo(value);

    /// <summary>
    /// Converts a given value to back to its original value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert back.</param>
    /// <param name="targetType">The type to convert back to.</param>
    /// <param name="parameter">Any optional data used to help convert the value back.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted back to original value.</returns>
    public override TFrom? ConvertBack(TTo value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (_convertBack == null)
            return default;

        return _convertBack(value);
    }
}