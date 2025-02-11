using CoreBTS.Maui.ShieldMVVM.Behaviors;
using CoreBTS.Maui.ShieldMVVM.Converters;
using CoreBTS.Maui.ShieldMVVM.DataTemplates;
using System.Collections;
using System.Globalization;
using System.Linq.Expressions;
using System.Windows.Input;

namespace CoreBTS.Maui.ShieldMVVM.Bindings;

/// <summary>
/// This is a helper class to create a new instance of a type-specific BindingHelper.
/// </summary>
public static class BindingHelper
{
    /// <summary>
    /// Returns a new instance of a type-specific BindingHelper. Used so you don't have to
    /// specify the generic directly.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <param name="viewModel">The ViewModel being bound to.</param>
    /// <returns>A new instance of a type-specific BindingHelper.</returns>
    public static BindingHelper<TViewModel> Create<TViewModel>(TViewModel viewModel) =>
        BindingHelper<TViewModel>.Create(viewModel);
}

/// <summary>
/// This class allows you to bind to controls with type-safe lambdas and 
/// chain multiple bindings for the same control.
/// </summary>
/// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
public class BindingHelper<TViewModel>
{
    private readonly TViewModel _viewModel;

    /// <summary>
    /// Creates a new instance of a type-specific BindingHelper.
    /// </summary>
    /// <param name="viewModel">The type of ViewModel being bound to.</param>
    /// <returns>A type-specific BindingHelper.</returns>
    public static BindingHelper<TViewModel> Create(TViewModel viewModel) =>
        new(viewModel);

    private BindingHelper(TViewModel viewModel) =>
        _viewModel = viewModel;

    /// <summary>
    /// A method that defines which control you are binding to in order to provide only
    /// valid BindableProperties with type-safety.
    /// </summary>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <param name="control">The control being bond to.</param>
    /// <returns>A new instance of a type-specific BindingControl.</returns>
    public BindingControl<TViewModel, TControl> WithControl<TControl>(TControl control)
        where TControl : BindableObject =>
        WithControls(control);

    /// <summary>
    /// A method that defines which control(s) you are binding to in order to provide only
    /// valid BindableProperties with type-safety.
    /// </summary>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <param name="controls">The control(s) being bound to.</param>
    /// <returns>A new instance of a type-specific BindingControl.</returns>
    public BindingControl<TViewModel, TControl> WithControls<TControl>(params TControl[] controls)
        where TControl : BindableObject =>
        new(_viewModel, controls);
}

/// <summary>
/// A class that allows chaining different types of binding for a specific control type and the ability to add a
/// type-safe converter.
/// </summary>
/// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
/// <typeparam name="TControl">The type of control being bound to.</typeparam>
/// <remarks>
/// Creates a new instance of a type-safe BindingControl.
/// </remarks>
/// <param name="viewModel">The ViewModel being bound to.</param>
/// <param name="controls">The control(s) being bound to.</param>
public class BindingControl<TViewModel, TControl>(TViewModel viewModel, params TControl[] controls)
    where TControl : BindableObject
{
    private readonly TViewModel _viewModel = viewModel;
    private readonly TControl[] _controls = controls;

    /// <summary>
    /// Binds a ViewModel property to a control's BindableProperty.
    /// </summary>
    /// <typeparam name="TPropertyType">The type of property coming from the ViewModel and going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="viewModelPropertyExpression">An expression to get the ViewModel property to use.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> For<TPropertyType>(
       Func<TControl, BindableProperty<TPropertyType>> bindablePropertyExpression,
       Expression<Func<TViewModel, TPropertyType>> viewModelPropertyExpression)
    {
        foreach (var control in _controls)
        {
            var bpv = bindablePropertyExpression(control).BindablePropertyValue;
            control.ClearValue(bpv);
            control.SetBinding(
                bpv,
                new Binding(
                    GetPropertyPath(viewModelPropertyExpression),
                    source: _viewModel)
                );
        }

        return this;
    }

    /// <summary>
    /// Binds a ViewModel property to a control's BindableProperty.
    /// </summary>
    /// <typeparam name="TFrom">The type of property coming from the ViewModel.</typeparam>
    /// <typeparam name="TTo">The type of property going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="viewModelPropertyExpression">An expression to get the ViewModel property to use.</param>
    /// <param name="converter">A converter to change the value from the ViewModel to the BindableProperty type.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> For<TFrom, TTo>(
       Func<TControl, BindableProperty<TTo>> bindablePropertyExpression,
       Expression<Func<TViewModel, TFrom>> viewModelPropertyExpression,
       Func<BindingConverter<TFrom, TTo>, IValueConverter<TFrom, TTo>> converter)
    {
        foreach (var control in _controls)
        {
            var bpv = bindablePropertyExpression(control).BindablePropertyValue;
            control.ClearValue(bpv);
            control.SetBinding(
                bpv,
                new Binding(
                    GetPropertyPath(viewModelPropertyExpression),
                    converter: converter(new BindingConverter<TFrom, TTo>()), // Just used for extension method
                    source: _viewModel)
                );
        }

        return this;
    }

    /// <summary>
    /// Binds a ViewModel property to a control's BindableProperty.
    /// </summary>
    /// <typeparam name="TFrom">The type of property coming from the ViewModel.</typeparam>
    /// <typeparam name="TTo">The type of property going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="viewModelPropertyExpression">An expression to get the ViewModel property to use.</param>
    /// <param name="converter">A converter to change the value from the ViewModel to the BindableProperty.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> For<TFrom, TTo>(
       Func<TControl, BindableProperty<TTo>> bindablePropertyExpression,
       Expression<Func<TViewModel, TFrom>> viewModelPropertyExpression,
       Func<BindingConverter<TFrom, TTo>, TViewModel, IValueConverter<TFrom, TTo>> converter)
    {
        foreach (var control in _controls)
        {
            var bpv = bindablePropertyExpression(control).BindablePropertyValue;
            control.ClearValue(bpv);
            control.SetBinding(
                bpv,
                new Binding(
                    GetPropertyPath(viewModelPropertyExpression),
                    converter: converter(new BindingConverter<TFrom, TTo>(), _viewModel), // Just used for extension method
                    source: _viewModel)
                );
        }

        return this;
    }

    /// <summary>
    /// Sets a ViewModel property to a control's value directly, only once.
    /// </summary>
    /// <typeparam name="TFrom">The type of property coming from the ViewModel.</typeparam>
    /// <typeparam name="TTo">The type of property going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="viewModelPropertyExpression">An expression to get the ViewModel property to use.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> Once<TFrom, TTo>(
       Func<TControl, BindableProperty<TTo>> bindablePropertyExpression,
       Func<TViewModel, TFrom> viewModelPropertyExpression)
    {
        foreach (var control in _controls)
        {
            control.SetValue(
                bindablePropertyExpression(control).BindablePropertyValue,
                viewModelPropertyExpression(_viewModel)
            );
        }

        return this;
    }

    /// <summary>
    /// Sets a ViewModel property to a control's value directly, only once.
    /// </summary>
    /// <typeparam name="TFrom">The type of property coming from the ViewModel.</typeparam>
    /// <typeparam name="TTo">The type of property going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="viewModelPropertyExpression">An expression to get the ViewModel property to use.</param>
    /// <param name="converter">An optional converter to change the value from the ViewModel to the BindableProperty.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> Once<TFrom, TTo>(
       Func<TControl, BindableProperty<TTo>> bindablePropertyExpression,
       Func<TViewModel, TFrom> viewModelPropertyExpression,
       Func<BindingConverter<TFrom, TTo>, IValueConverter<TFrom, TTo>> converter)
    {
        foreach (var control in _controls)
        {
            control.SetValue(
                bindablePropertyExpression(control).BindablePropertyValue,
                converter(new BindingConverter<TFrom, TTo>())
                    .Convert(
                        viewModelPropertyExpression(_viewModel), 
                        typeof(TTo),
                        null, 
                        CultureInfo.CurrentCulture)
            );
        }

        return this;
    }

    /// <summary>
    /// Sets a ViewModel property to a control's value directly, only once.
    /// </summary>
    /// <typeparam name="TFrom">The type of property coming from the ViewModel.</typeparam>
    /// <typeparam name="TTo">The type of property going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="viewModelPropertyExpression">An expression to get the ViewModel property to use.</param>
    /// <param name="converter">An optional converter to change the value from the ViewModel to the BindableProperty.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> Once<TFrom, TTo>(
       Func<TControl, BindableProperty<TTo>> bindablePropertyExpression,
       Func<TViewModel, TFrom> viewModelPropertyExpression,
       Func<BindingConverter<TFrom, TTo>, TViewModel, IValueConverter<TFrom, TTo>> converter)
    {
        foreach (var control in _controls)
        {
            control.SetValue(
                bindablePropertyExpression(control).BindablePropertyValue,
                converter(new BindingConverter<TFrom, TTo>(), _viewModel)
                    .Convert(
                        viewModelPropertyExpression(_viewModel), 
                        typeof(TTo),
                        null, 
                        CultureInfo.CurrentCulture)
            );
        }

        return this;
    }

    /// <summary>
    /// Binds a behavior to a control.
    /// </summary>
    /// <param name="behaviorExpression">The expression that sets up the behavior to add to the control</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> Behavior(
        Func<BindingBehavior<TControl>, Behavior<TControl>> behaviorExpression)
    {
        foreach (var control in _controls)
        {
            if (control is VisualElement ve)
                ve.Behaviors.Add(behaviorExpression(new BindingBehavior<TControl>())); // Just used for extension method
        }

        return this;
    }

    /// <summary>
    /// Binds a behavior to a control.
    /// </summary>
    /// <param name="behaviorExpression">The expression that sets up the behavior to add to the control</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public BindingControl<TViewModel, TControl> Behavior(
        Func<BindingBehavior<TControl>, TViewModel, Behavior<TControl>> behaviorExpression)
    {
        foreach (var control in _controls)
        {
            if (control is VisualElement ve)
                ve.Behaviors.Add(behaviorExpression(new BindingBehavior<TControl>(), _viewModel)); // Just used for extension method
        }

        return this;
    }

    /// <summary>
    /// Binds a ViewModel property to a control's BindableProperty.
    /// </summary>
    /// <typeparam name="TTo">The type of property going to the BindableProperty.</typeparam>
    /// <param name="bindablePropertyExpression">An expression to get the BindableProperty to use.</param>
    /// <param name="binding">The Binding information to use directly.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    internal BindingControl<TViewModel, TControl> For<TTo>(
        Func<TControl, BindableProperty<TTo>> bindablePropertyExpression,
        Binding binding)
    {
        foreach (var control in _controls)
        {
            control.SetBinding(
                bindablePropertyExpression(control).BindablePropertyValue,
                binding
            );
        }

        return this;
    }

    private static string GetPropertyPath<TFrom>(Expression<Func<TViewModel, TFrom>> propertyExpression)
    {
        if (propertyExpression.Body is MemberExpression me)
            return GetMemberExpressionMemberName(me);

        if (propertyExpression.Body is UnaryExpression ue && ue.Operand is MemberExpression ueMe)
            return GetMemberExpressionMemberName(ueMe);

        throw new NotSupportedException("Given expression is not currently supported.");
    }

    private static string GetMemberExpressionMemberName(MemberExpression me)
    {
        var propertyNames = new List<string>();

        var current = me;
        while (current != null && current.NodeType == ExpressionType.MemberAccess)
        {
            propertyNames.Insert(0, current.Member.Name);

            current = current.Expression as MemberExpression;
        }

        if (propertyNames.Count == 1)
            return propertyNames[0];

        return string.Join(".", propertyNames);
    }
}

/// <summary>
/// Extension methods to add specific functionality for specific controls
/// </summary>
public static class BindingHelperExtensions
{
    /// <summary>
    /// Adds generic type-safety for binding to lists that bind to ViewCellBase.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <typeparam name="TCellModel">The model type the cell is bound to.</typeparam>
    /// <param name="self">Extension parameter.</param>
    /// <param name="dataPropertyExpression">An expression to the list being bound to.</param>
    /// <param name="dataTemplate">The ItemTemplate to use.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public static BindingControl<TViewModel, TControl> ForTemplate<TViewModel, TControl, TCellModel>(
        this BindingControl<TViewModel, TControl> self,
        Expression<Func<TViewModel, IEnumerable<TCellModel>>> dataPropertyExpression,
        DataTemplate<TCellModel> dataTemplate
        )
        where TControl : ItemsView =>
        self.For(c => c.BindItemsSource<TCellModel>(), dataPropertyExpression)
            .Once(c => c.BindItemTemplate(), vm => dataTemplate);

    /// <summary>
    /// Adds generic type-safety for binding to lists that bind to ViewCellBase.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <typeparam name="TCellModel">The model type the cell is bound to.</typeparam>
    /// <param name="self">Extension parameter.</param>
    /// <param name="dataPropertyExpression">An expression to the list being bound to.</param>
    /// <param name="dataTemplate">The ItemTemplate to use.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public static BindingControl<TViewModel, TControl> ForTemplateLayout<TViewModel, TControl, TCellModel>(
        this BindingControl<TViewModel, TControl> self,
        Expression<Func<TViewModel, IEnumerable<TCellModel>>> dataPropertyExpression,
        DataTemplate<TCellModel> dataTemplate
        )
        where TControl : BindableObject, IBindableLayout =>
        self.For(c => c.BindItemsSource<TControl, TCellModel>(), dataPropertyExpression)
            .Once(c => c.BindItemTemplate<TControl, DataTemplate<TCellModel>>(), vm => dataTemplate);

    /// <summary>
    /// Adds generic type-safety for binding to lists that bind to ViewCellBase.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <typeparam name="TCellModel">The model type the cell is bound to.</typeparam>
    /// <param name="self">Extension parameter.</param>
    /// <param name="dataPropertyExpression">An expression to the list being bound to.</param>
    /// <param name="dataTemplateSelector">The DataTemplateSelector to use.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public static BindingControl<TViewModel, TControl> ForTemplate<TViewModel, TControl, TCellModel>(
       this BindingControl<TViewModel, TControl> self,
       Expression<Func<TViewModel, IEnumerable<TCellModel>>> dataPropertyExpression,
       DataTemplateSelector dataTemplateSelector
       )
       where TControl : ItemsView =>
       self.For(c => c.BindItemsSource<TCellModel>(), dataPropertyExpression)
           .Once(c => c.BindItemTemplate(), vm => dataTemplateSelector);

    /// <summary>
    /// Adds generic type-safety for binding to lists that bind to ViewCellBase.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <typeparam name="TCellModel">The model type the cell is bound to.</typeparam>
    /// <param name="self">Extension parameter.</param>
    /// <param name="dataPropertyExpression">An expression to the list being bound to.</param>
    /// <param name="dataTemplateSelector">The DataTemplateSelector to use.</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public static BindingControl<TViewModel, TControl> ForTemplateLayout<TViewModel, TControl, TCellModel>(
       this BindingControl<TViewModel, TControl> self,
       Expression<Func<TViewModel, IEnumerable<TCellModel>>> dataPropertyExpression,
       DataTemplateSelector dataTemplateSelector
       )
       where TControl : BindableObject, IBindableLayout =>
       self.For(c => c.BindItemsSource<TControl,TCellModel>(), dataPropertyExpression)
           .Once(c => c.BindItemTemplate<TControl, DataTemplateSelector>(), vm => dataTemplateSelector);

    /// <summary>
    /// Adds short-hand way to hookup Selection Changed events.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <param name="self">Extension parameter.</param>
    /// <param name="commandPropertyExpression">The command to run when a selection is made</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public static BindingControl<TViewModel, TControl> ForSingleSelection<TViewModel, TControl>(
        this BindingControl<TViewModel, TControl> self,
        Expression<Func<TViewModel, ICommand>> commandPropertyExpression
        )
        where TControl : SelectableItemsView =>
        self.For(c => c.BindSelectionChangedCommand(), commandPropertyExpression)
            .For(c => c.BindSelectionChangedCommandParameter(),
                new Binding(
                    SelectableItemsView.SelectedItemProperty.PropertyName,
                    source: new RelativeBindingSource(RelativeBindingSourceMode.Self)
                    )
            );

    /// <summary>
    /// Adds short-hand way to hookup Selection Changed events.
    /// </summary>
    /// <typeparam name="TViewModel">The type of ViewModel being bound to.</typeparam>
    /// <typeparam name="TControl">The type of control being bound to.</typeparam>
    /// <param name="self">Extension parameter.</param>
    /// <param name="commandPropertyExpression">The command to run when a selection is made</param>
    /// <returns>A reference to this instance to allow chaining.</returns>
    public static BindingControl<TViewModel, TControl> ForMultiSelection<TViewModel, TControl>(
        this BindingControl<TViewModel, TControl> self,
        Expression<Func<TViewModel, ICommand>> commandPropertyExpression
        )
        where TControl : SelectableItemsView =>
        self.For(c => c.BindSelectionChangedCommand(), commandPropertyExpression)
            .For(c => c.BindSelectionChangedCommandParameter(),
                new Binding(
                    SelectableItemsView.SelectedItemsProperty.PropertyName,
                    source: new RelativeBindingSource(RelativeBindingSourceMode.Self)
                    )
            );
}