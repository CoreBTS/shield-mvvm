using System.Globalization;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

/// <summary>
/// An interface that adds type safety to converting values.
/// </summary>
/// <typeparam name="TFrom">The type of value to convert from.</typeparam>
/// <typeparam name="TTo">The type of value to convert to.</typeparam>
public interface IValueConverter<TFrom, TTo> : IValueConverter
{
    /// <summary>
    /// Converts a given value to another value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert from.</param>
    /// <param name="targetType">The type to convert to.</param>
    /// <param name="parameter">Any optional data used to help convert the value.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted value.</returns>
    TTo Convert(TFrom value, Type targetType, object parameter, CultureInfo culture);

    /// <summary>
    /// Converts a given value to back to its original value based on the given parameters.
    /// </summary>
    /// <param name="value">The value to convert back.</param>
    /// <param name="targetType">The type to convert back to.</param>
    /// <param name="parameter">Any optional data used to help convert the value back.</param>
    /// <param name="culture">The user's culture.</param>
    /// <returns>Converted back to original value.</returns>
    TFrom ConvertBack(TTo value, Type targetType, object parameter, CultureInfo culture);
}