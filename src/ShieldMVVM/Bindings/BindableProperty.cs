using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace CoreBTS.Maui.ShieldMVVM.Bindings;

/// <summary>
/// A BindableProperty is a backing store for properties allowing bindings on Microsoft.Maui.Controls.BindableObject.
/// This class adds type safety to ensure the control property type matches the View Model property being bound from.
/// </summary>
/// <typeparam name="TPropertyType">The type of property being bound to.</typeparam>
public class BindableProperty<TPropertyType>
{
    private static readonly ConcurrentDictionary<BindableProperty, BindableProperty<TPropertyType>> cache = new();

    /// <summary>
    /// Returns a type-safe version of the given BindableProperty.
    /// </summary>
    /// <param name="bindablePropertyValue">The backing BindableProperty being wrapped.</param>
    /// <returns>A type-safe BindableProperty.</returns>
    public static BindableProperty<TPropertyType> Create(BindableProperty bindablePropertyValue)
    {
        if (cache.TryGetValue(bindablePropertyValue, out var result))
            return result;

        result = new BindableProperty<TPropertyType>(bindablePropertyValue);
        cache.TryAdd(bindablePropertyValue, result);

        return result;
    }

    /// <summary>
    /// Creates a new instance of the type-safe BindableProperty class.
    /// </summary>
    /// <param name="bindablePropertyValue">The BindableProperty being wrapped.</param>
    public BindableProperty(BindableProperty bindablePropertyValue) =>
        BindablePropertyValue = bindablePropertyValue;

    /// <summary>
    /// Gets the wrapped BindableProperty.
    /// </summary>
    public BindableProperty BindablePropertyValue { get; }

    /// <summary>
    /// Creates a new instance of the type-safe BindableProperty class.
    /// </summary>
    /// <typeparam name="TControl">The type of control the BindableProperty belongs to.</typeparam>
    /// <param name="propertyTarget">An expression to get the name of the property.</param>
    /// <param name="bindingMode">
    /// The BindingMode to use on SetBinding() if no BindingMode is given. 
    /// This parameter is optional. Default is BindingMode.OneWay.
    /// </param>
    /// <param name="defaultValue">The default value for the property.</param>
    /// <param name="validateValue">
    /// A delegate to be run when a value is set. This parameter is optional. Default is null.
    /// </param>
    /// <param name="propertyChanged">
    /// A delegate to be run when the value has changed. This parameter is optional. Default is null.
    /// </param>
    /// <param name="propertyChanging">
    /// A delegate to be run when the value will change. This parameter is optional. Default is null.
    /// </param>
    /// <param name="coerceValue">
    ///  A delegate used to coerce the range of a value. This parameter is optional. Default is null.
    /// </param>
    /// <param name="defaultValueCreator">
    /// A Func used to initialize default value for reference types.
    /// </param>
    /// <returns>A newly created type-safe BindableProperty.</returns>
    public static BindableProperty<TPropertyType> Create<TControl>(
        Expression<Func<TControl, TPropertyType>> propertyTarget,
        BindingMode bindingMode = BindingMode.OneWay,
        TPropertyType defaultValue = default,
        Func<TControl, TPropertyType, bool> validateValue = null,
        Action<TControl, TPropertyType, TPropertyType> propertyChanged = null,
        Action<TControl, TPropertyType, TPropertyType> propertyChanging = null,
        Func<TControl, TPropertyType, TPropertyType> coerceValue = null,
        Func<TControl, TPropertyType> defaultValueCreator = null)
            where TControl : BindableObject =>
        new(
            BindableProperty.Create(
                ((MemberExpression)propertyTarget.Body).Member.Name,
                typeof(TPropertyType),
                typeof(TControl),
                defaultValue,
                bindingMode,
                validateValue: validateValue == null ? null : (control, newValue) => validateValue((TControl)control, (TPropertyType)newValue),
                propertyChanged: (control, oldValue, newValue) => propertyChanged?.Invoke((TControl)control, (TPropertyType)oldValue, (TPropertyType)newValue),
                propertyChanging: (control, oldValue, newValue) => propertyChanging?.Invoke((TControl)control, (TPropertyType)oldValue, (TPropertyType)newValue),
                coerceValue: coerceValue == null ? null : (control, newValue) => coerceValue((TControl)control, (TPropertyType)newValue),
                defaultValueCreator: defaultValueCreator == null ? null : control => defaultValueCreator((TControl)control)
            )
        );

    /// <summary>
    /// Creates a new instance of the type-safe BindableProperty class for an attached property.
    /// </summary>
    /// <typeparam name="TControl">The type of control the BindableProperty belongs to.</typeparam>
    /// <param name="propertyTarget">An expression to get the name of the property.</param>
    /// <param name="bindingMode">
    /// The BindingMode to use on SetBinding() if no BindingMode is given. 
    /// This parameter is optional. Default is BindingMode.OneWay.
    /// </param>
    /// <param name="defaultValue">The default value for the property.</param>
    /// <param name="validateValue">
    /// A delegate to be run when a value is set. This parameter is optional. Default is null.
    /// </param>
    /// <param name="propertyChanged">
    /// A delegate to be run when the value has changed. This parameter is optional. Default is null.
    /// </param>
    /// <param name="propertyChanging">
    /// A delegate to be run when the value will change. This parameter is optional. Default is null.
    /// </param>
    /// <param name="coerceValue">
    ///  A delegate used to coerce the range of a value. This parameter is optional. Default is null.
    /// </param>
    /// <param name="defaultValueCreator">
    /// A Func used to initialize default value for reference types.
    /// </param>
    /// <returns>A newly created type-safe BindableProperty.</returns>
    public static BindableProperty<TPropertyType> CreateAttached<TControl>(
       Expression<Func<TControl, TPropertyType>> propertyTarget,
       BindingMode bindingMode = BindingMode.OneWay,
       TPropertyType defaultValue = default,
       Func<TControl, TPropertyType, bool> validateValue = null,
       Action<TControl, TPropertyType, TPropertyType> propertyChanged = null,
       Action<TControl, TPropertyType, TPropertyType> propertyChanging = null,
       Func<TControl, TPropertyType, TPropertyType> coerceValue = null,
       Func<TControl, TPropertyType> defaultValueCreator = null)
            where TControl : BindableObject =>
       new(
           BindableProperty.CreateAttached(
               ((MemberExpression)propertyTarget.Body).Member.Name,
               typeof(TPropertyType),
               typeof(TControl),
               defaultValue,
               bindingMode,
               validateValue: validateValue == null ? null : (control, newValue) => validateValue((TControl)control, (TPropertyType)newValue),
               propertyChanged: (control, oldValue, newValue) => propertyChanged?.Invoke((TControl)control, (TPropertyType)oldValue, (TPropertyType)newValue),
               propertyChanging: (control, oldValue, newValue) => propertyChanging?.Invoke((TControl)control, (TPropertyType)oldValue, (TPropertyType)newValue),
               coerceValue: coerceValue == null ? null : (control, newValue) => coerceValue((TControl)control, (TPropertyType)newValue),
               defaultValueCreator: defaultValueCreator == null ? null : control => defaultValueCreator((TControl)control)
           )
       );
}