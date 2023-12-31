﻿using System.Globalization;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

public static partial class Converter
{
    /// <summary>
    /// A converter that converts the given value to its string representation.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <param name="style">The style to convert the value to.</param>
    /// <param name="formatProvider">A way to convert the value to a string.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<float, string> ConvertToString(this BindingConverter<float, string> _,
        NumberStyles style = NumberStyles.Any,
        IFormatProvider? formatProvider = null) =>
        Create(_,
            value => value.ToString(formatProvider),
            value => float.TryParse(value, style, formatProvider, out var val) ? val : default);

    /// <summary>
    /// A converter that converts the given value to its string representation.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <param name="style">The style to convert the value to.</param>
    /// <param name="formatProvider">A way to convert the value to a string.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<float?, string?> ConvertToString(this BindingConverter<float?, string?> _,
       NumberStyles style = NumberStyles.Any,
       IFormatProvider? formatProvider = null) =>
       Create(_,
           value => value?.ToString(formatProvider),
           value => float.TryParse(value, style, formatProvider, out var val) ? val : null);
}