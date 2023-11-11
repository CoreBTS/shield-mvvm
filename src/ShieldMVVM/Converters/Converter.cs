using Microsoft.Maui.Graphics.Converters;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

/// <summary>
/// This class contains all the converters that can use generic lambda callbacks.
/// </summary>
public static partial class Converter
{
    /// <summary>
    /// Creates a new instance of a converter to use.
    /// </summary>
    /// <typeparam name="TFrom">The type of value being converted from.</typeparam>
    /// <typeparam name="TTo">The type of value being converted to.</typeparam>
    /// <param name="_"></param>
    /// <param name="convertTo">A function that converts from the source to the target.</param>
    /// <param name="convertBack">A function that converts back from the target to the source.</param>
    /// <returns>A new instance of a converter.</returns>
    public static GenericConverter<TFrom, TTo> Create<TFrom, TTo>(
        BindingConverter<TFrom, TTo> _, // Used for type inference only
        Func<TFrom, TTo> convertTo,
        Func<TTo, TFrom>? convertBack = null) =>
        GenericConverter<TFrom, TTo>.Create(convertTo, convertBack);

    private static readonly ColorTypeConverter ColorTypeConverter = new();

    private static Color? GetColor(string value) =>
        string.IsNullOrWhiteSpace(value)
            ? Colors.Transparent
            : ColorTypeConverter.ConvertFromInvariantString(value) as Color;
}
