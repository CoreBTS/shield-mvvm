namespace CoreBTS.Maui.ShieldMVVM.DataTemplates;

/// <summary>
/// This class wraps the DataTemplate to make it type-safe/generic.
/// </summary>
/// <typeparam name="TModel">The type of model the data template represents.</typeparam>
public class DataTemplate<TModel> : DataTemplate
{
    public DataTemplate(Type cellType): base(cellType)
    {
    }
}