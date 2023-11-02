namespace CoreBTS.Maui.ShieldMVVM.Converters;

public static partial class Converter
{
    /// <summary>
    /// A converter that converts the given value to its inverse value (e.g. given false, returns true).
    /// </summary>
    /// <param name="_"></param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<bool, bool> ConvertToInverse(this BindingConverter<bool, bool> _) =>
        Create(_,
            value => !value,
            value => !value);

    /// <summary>
    /// A converter that converts the given value to its inverse value (e.g. given false, returns true).
    /// </summary>
    /// <param name="_"></param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<bool?, bool?> ConvertToInverse(this BindingConverter<bool?, bool?> _) =>
       Create(_,
           value => !value,
           value => !value);

    /// <summary>
    /// A converter that converts the given nullable value to a bool value.
    /// </summary>
    /// <param name="_"></param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<bool?, bool> ConvertToBool(this BindingConverter<bool?, bool> _, bool defaultValue = false) =>
        Create(_,
            value => value ?? defaultValue);
}