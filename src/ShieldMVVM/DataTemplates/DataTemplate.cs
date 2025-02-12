namespace CoreBTS.Maui.ShieldMVVM.DataTemplates;

/// <summary>
/// This class wraps the DataTemplate to make it type-safe/generic.
/// </summary>
/// <typeparam name="TModel">The type of model the data template represents.</typeparam>
public class DataTemplate<TModel> : DataTemplate
{
    /// <summary>
    /// Constructor that takes the type of cell being bound to.
    /// </summary>
    /// <param name="cellType">The type of cell being bound to.</param>
    public DataTemplate(Type cellType): base(cellType)
    {
    }
}