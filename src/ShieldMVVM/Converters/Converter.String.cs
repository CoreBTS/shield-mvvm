﻿namespace CoreBTS.Maui.ShieldMVVM.Converters;

public static partial class Converter
{
    /// <summary>
    /// A converter that converts a string to a Color based via the ColorTypeConverter class.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<string, Color> ConvertToColor(this BindingConverter<string, Color> _) =>
        Create(_, 
            value => GetColor(value));

    /// <summary>
    /// A converter that converts a string to all lower case letters.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<string, string> ConvertToLowerCase(this BindingConverter<string, string> _) =>
        Create(_, 
            value => value?.ToLowerInvariant());

    /// <summary>
    /// A converter that converts a string to all upper case letters.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<string, string> ConvertToUpperCase(this BindingConverter<string, string> _) =>
        Create(_,
            value => value?.ToUpperInvariant());

    /// <summary>
    /// A converter that converts a nullable string to a non-nullable string.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<string?, string> ConvertToNonNullString(this BindingConverter<string?, string> _) =>
        Create(_,
            value => value ?? string.Empty);

    /// <summary>
    /// A converter that converts the given string's length to a bool value.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<string?, bool> ConvertToNullableHasLength(this BindingConverter<string?, bool> _) =>
        Create(_,
            value => !string.IsNullOrEmpty(value));

    /// <summary>
    /// A converter that converts the given string's length to a bool value.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<string, bool> ConvertToHasLength(this BindingConverter<string, bool> _) =>
        Create(_,
            value => !string.IsNullOrEmpty(value));
}