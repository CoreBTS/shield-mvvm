using System.Globalization;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

/// <summary>
/// A base class that adds type safety to converting values.
/// </summary>
/// <typeparam name="TFrom">The type of value to convert from.</typeparam>
/// <typeparam name="TTo">The type of value to convert to.</typeparam>
public abstract class ValueConverterBase<TFrom, TTo> : IValueConverter<TFrom, TTo>
{
    /// <summary>
    /// Converts a given value to another value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert from.</param>
    /// <param name="targetType">The type to convert to.</param>
    /// <param name="parameter">Any optional data used to help convert the value.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted value.</returns>
    public abstract TTo Convert(TFrom value, Type targetType, object parameter, CultureInfo culture);

    /// <summary>
    /// Converts a given value to back to its original value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert back.</param>
    /// <param name="targetType">The type to convert back to.</param>
    /// <param name="parameter">Any optional data used to help convert the value back.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted back to original value.</returns>
    public abstract TFrom ConvertBack(TTo value, Type targetType, object parameter, CultureInfo culture);

    /// <summary>
    /// Converts a given value to another value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert from.</param>
    /// <param name="targetType">The type to convert to.</param>
    /// <param name="parameter">Any optional data used to help convert the value.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted value.</returns>
    object IValueConverter.Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        Convert((TFrom)value, targetType, parameter, culture);

    /// <summary>
    /// Converts a given value to back to its original value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert back.</param>
    /// <param name="targetType">The type to convert back to.</param>
    /// <param name="parameter">Any optional data used to help convert the value back.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted back to original value.</returns>
    object IValueConverter.ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        ConvertBack((TTo)value, targetType, parameter, culture);
}