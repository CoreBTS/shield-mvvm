using CoreBTS.Maui.ShieldMVVM.Bindings;

namespace CoreBTS.Maui.ShieldMVVM.DataTemplates;

/// <summary>
/// This class defines common methods to create a cell for a list.
/// </summary>
/// <typeparam name="TModel">The data being bound to this cell.</typeparam>
/// <typeparam name="TCell">The inheriting class.</typeparam>
public abstract class ViewCellBase<TModel, TCell> : ContentView
{
    protected ViewCellBase() =>
        CreateControls();

    /// <summary>
    /// Gets the ItemTemplate that is type-safe.
    /// </summary>
    public static DataTemplate<TModel> ItemTemplate => new(typeof(TCell));

    /// <summary>
    /// Gets the data bound to this cell.
    /// </summary>
    public TModel Model => (TModel)BindingContext;

    /// <summary>
    /// Gets the BindingHelper to add control bindings from the Model.
    /// </summary>
    protected BindingHelper<TModel> Binder { get; private set; }

    /// <summary>
    /// Calls InitializeComponent.
    /// </summary>
    protected virtual void CreateControls() => this.CallInitializeComponent();

    /// <summary>
    /// Ensures SetupBindings is run when the BindingContext changes.
    /// </summary>
    protected override void OnBindingContextChanged()
    {
        base.OnBindingContextChanged();

        Binder = BindingHelper.Create(Model);

        SetupBindings();
    }

    /// <summary>
    /// This methods should be used to define all control bindings.
    /// </summary>
    protected abstract void SetupBindings();
}
