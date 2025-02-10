using System.Collections.Concurrent;
using System.Linq.Expressions;

namespace CoreBTS.Maui.ShieldMVVM.Bindings;

/// <summary>
/// The secret key to a BindableProperty, used to implement a BindableProperty with restricted write access.
/// This class adds type safety to ensure the control property type matches the View Model property being bound from.
/// </summary>
/// <typeparam name="TPropertyType">The type of property being bound to.</typeparam>
/// <remarks>
/// The following example shows the creation of a BindablePropertyKey. Write access
///     is internal while read access is public.
///     class Bindable : BindableObject
///     {
///       internal static readonly BindablePropertyKey FooPropertyKey =
///         BindableProperty.CreateReadOnly&lt;Bindable, string&gt; (w => w.Foo, default(string));
///       public static readonly BindableProperty FooProperty = FooPropertyKey.BindableProperty;
///       public string Foo {
///         get { return (string)GetValue (FooProperty); }
///         internal set { SetValue (FooPropertyKey, value); }
///       }
///     }
/// </remarks>
/// <remarks>
/// Creates a new instance of the type-safe BindablePropertyKey class.
/// </remarks>
/// <param name="bindablePropertyKeyValue">The BindablePropertyKey being wrapped.</param>
public class BindablePropertyKey<TPropertyType>(BindablePropertyKey bindablePropertyKeyValue)
{
    private static readonly ConcurrentDictionary<BindablePropertyKey, BindablePropertyKey<TPropertyType>> cache = new();

    /// <summary>
    /// Returns a type-safe version of the given BindablePropertyKey.
    /// </summary>
    /// <param name="bindablePropertyKeyValue">The backing BindablePropertyKey being wrapped.</param>
    /// <returns>A type-safe BindablePropertyKey.</returns>
    public static BindablePropertyKey<TPropertyType> Create(BindablePropertyKey bindablePropertyKeyValue)
    {
        if (cache.TryGetValue(bindablePropertyKeyValue, out var result))
            return result;

        result = new BindablePropertyKey<TPropertyType>(bindablePropertyKeyValue);
        cache.TryAdd(bindablePropertyKeyValue, result);

        return result;
    }

    /// <summary>
    /// Gets the wrapped BindablePropertyKey.
    /// </summary>
    public BindablePropertyKey BindablePropertyKeyValue { get; } = bindablePropertyKeyValue;

    /// <summary>
    /// Creates a new instance of the type-safe BindablePropertyKey class for an attached property.
    /// </summary>
    /// <typeparam name="TControl">The type of control the BindableProperty belongs to.</typeparam>
    /// <param name="propertyTarget">An expression to get the name of the property.</param>
    /// <param name="bindingMode">
    /// The BindingMode to use on SetBinding() if no BindingMode is given. 
    /// This parameter is optional. Default is BindingMode.OneWayToSource.
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
    /// <returns>A newly created type-safe BindablePropertyKey.</returns>
    public static BindablePropertyKey<TPropertyType> CreateReadOnly<TControl>(
       Expression<Func<TControl, TPropertyType>> propertyTarget,
       BindingMode bindingMode = BindingMode.OneWayToSource,
       TPropertyType? defaultValue = default,
       Func<TControl, TPropertyType, bool>? validateValue = null,
       Action<TControl, TPropertyType, TPropertyType>? propertyChanged = null,
       Action<TControl, TPropertyType, TPropertyType>? propertyChanging = null,
       Func<TControl, TPropertyType, TPropertyType>? coerceValue = null,
       Func<TControl, TPropertyType>? defaultValueCreator = null)
           where TControl : BindableObject =>
     new(
         BindableProperty.CreateReadOnly(
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
    /// Creates a new instance of the type-safe BindableProperty class for attached read-only properties.
    /// </summary>
    /// <typeparam name="TControl">The type of control the BindableProperty belongs to.</typeparam>
    /// <param name="propertyTarget">An expression to get the name of the property.</param>
    /// <param name="bindingMode">
    /// The BindingMode to use on SetBinding() if no BindingMode is given. 
    /// This parameter is optional. Default is BindingMode.OneWayToSource.
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
    /// <returns>A newly created type-safe BindablePropertyKey.</returns>
    public static BindablePropertyKey<TPropertyType> CreateAttachedReadOnly<TControl>(
        Expression<Func<TControl, TPropertyType>> propertyTarget,
        BindingMode bindingMode = BindingMode.OneWayToSource,
        TPropertyType? defaultValue = default,
        Func<TControl, TPropertyType, bool>? validateValue = null,
        Action<TControl, TPropertyType, TPropertyType>? propertyChanged = null,
        Action<TControl, TPropertyType, TPropertyType>? propertyChanging = null,
        Func<TControl, TPropertyType, TPropertyType>? coerceValue = null,
        Func<TControl, TPropertyType>? defaultValueCreator = null)
            where TControl : BindableObject =>
      new(
          BindableProperty.CreateAttachedReadOnly(
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