namespace CoreBTS.Maui.ShieldMVVM.Converters;

public static partial class Converter
{
    /// <summary>
    /// A converter that converts the given value to its inverse value (e.g. given false, returns true).
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<bool, bool> ConvertToInverse(this BindingConverter<bool, bool> _) =>
        Create(_,
            value => !value,
            value => !value);

    /// <summary>
    /// A converter that converts the given value to its inverse value (e.g. given false, returns true).
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<bool?, bool?> ConvertToInverse(this BindingConverter<bool?, bool?> _) =>
       Create(_,
           value => !value,
           value => !value);

    /// <summary>
    /// A converter that converts the given nullable value to a bool value.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <param name="defaultValue">The value to use if the given value is null.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<bool?, bool> ConvertToBool(this BindingConverter<bool?, bool> _, bool defaultValue = false) =>
        Create(_,
            value => value ?? defaultValue);

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