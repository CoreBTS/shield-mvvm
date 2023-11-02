namespace CoreBTS.Maui.ShieldMVVM.DataTemplates;

/// <summary>
/// This class wraps DataTemplateSelector to ensure it is type-safe.
/// </summary>
/// <typeparam name="TSelector">The inheriting class</typeparam>
public abstract class DataTemplateSelectorBase<TSelector> : DataTemplateSelector
    where TSelector : DataTemplateSelector, new()
{
    /// <summary>
    /// Gets the non-generic version of the DataTemplateSelector.
    /// </summary>
    public static DataTemplateSelector ItemTemplate => new TSelector();

    /// <summary>
    /// Gets the mappings of the various data templates to use based on a specific type.
    /// </summary>
    protected abstract Dictionary<Type, DataTemplate> TypeTemplateDictionary { get; }

    /// <summary>
    /// Returns the DataTemplate to use based upon the given item.
    /// </summary>
    /// <param name="item">The model being bound to.</param>
    /// <param name="container">The control housing the model.</param>
    /// <returns>The DataTemplate the control should use.</returns>
    /// <exception cref="NotImplementedException">
    /// Thrown when TypeTemplateDictionary doesn't have the given item type mapping.
    /// </exception>
    protected override DataTemplate OnSelectTemplate(object item, BindableObject container) =>
        TypeTemplateDictionary.TryGetValue(item.GetType(), out var val)
            ? val
            : throw new NotImplementedException($"Cannot find type '{item.GetType()}'.");
}