using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows.Input;
using static Microsoft.Maui.Controls.Button;
using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace CoreBTS.Maui.ShieldMVVM;

/// <summary>
/// This class stores all the Bind* extension methods for generic BindableProperty.
/// </summary>
public static partial class ControlBindExtensionMethods
{
    // ***** ClickableControl Bindings *****

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the AbsoluteLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this AbsoluteLayout _) => new(Controls.ClickableControl<AbsoluteLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Microsoft.Maui.Controls.Compatibility.AbsoluteLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.AbsoluteLayout _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.AbsoluteLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ActivityIndicator control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ActivityIndicator _) => new(Controls.ClickableControl<ActivityIndicator>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Border _) => new(Controls.ClickableControl<Border>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the BoxView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this BoxView _) => new(Controls.ClickableControl<BoxView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Button _) => new(Controls.ClickableControl<Button>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this CarouselView _) => new(Controls.ClickableControl<CarouselView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the CheckBox control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this CheckBox _) => new(Controls.ClickableControl<CheckBox>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the CollectionView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this CollectionView _) => new(Controls.ClickableControl<CollectionView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ContentPresenter control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ContentPresenter _) => new(Controls.ClickableControl<ContentPresenter>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ContentView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ContentView _) => new(Controls.ClickableControl<ContentView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this DatePicker _) => new(Controls.ClickableControl<DatePicker>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Editor _) => new(Controls.ClickableControl<Editor>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Ellipse control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Ellipse _) => new(Controls.ClickableControl<Ellipse>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Entry _) => new(Controls.ClickableControl<Entry>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this FlexLayout _) => new(Controls.ClickableControl<FlexLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.FlexLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Frame control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Frame _) => new(Controls.ClickableControl<Frame>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the GestureElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this GestureElement _) => new(Controls.ClickableControl<GestureElement>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the GraphicsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this GraphicsView _) => new(Controls.ClickableControl<GraphicsView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Grid _) => new(Controls.ClickableControl<Grid>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.Grid _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.Grid>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the GroupableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this GroupableItemsView _) => new(Controls.ClickableControl<GroupableItemsView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the HorizontalStackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this HorizontalStackLayout _) => new(Controls.ClickableControl<HorizontalStackLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Image control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Image _) => new(Controls.ClickableControl<Image>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ImageButton _) => new(Controls.ClickableControl<ImageButton>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this IndicatorView _) => new(Controls.ClickableControl<IndicatorView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this InputView _) => new(Controls.ClickableControl<InputView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ItemsView _) => new(Controls.ClickableControl<ItemsView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Label _) => new(Controls.ClickableControl<Label>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Layout _) => new(Controls.ClickableControl<Layout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Microsoft.Maui.Controls.Compatibility.Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.Layout _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.Layout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Line control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Line _) => new(Controls.ClickableControl<Line>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ListView _) => new(Controls.ClickableControl<ListView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the OpenGLView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    [Obsolete("OpenGLView is obsolete as of .NET 7. To enable this view you will need to call `builder.UseMauiCompatibility` but it is currently untested and unsupported.")]
    public static Bindings.BindableProperty<ICommand> BindClick(this OpenGLView _) => new(Controls.ClickableControl<OpenGLView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Path control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Path _) => new(Controls.ClickableControl<Path>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Picker _) => new(Controls.ClickableControl<Picker>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Polygon control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Polygon _) => new(Controls.ClickableControl<Polygon>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Polyline control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Polyline _) => new(Controls.ClickableControl<Polyline>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ProgressBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ProgressBar _) => new(Controls.ClickableControl<ProgressBar>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this RadioButton _) => new(Controls.ClickableControl<RadioButton>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Rectangle control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Rectangle _) => new(Controls.ClickableControl<Rectangle>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the RefreshView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this RefreshView _) => new(Controls.ClickableControl<RefreshView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Microsoft.Maui.Controls.Compatibility.RelativeLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.RelativeLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ReorderableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ReorderableItemsView _) => new(Controls.ClickableControl<ReorderableItemsView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the RoundRectangle control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this RoundRectangle _) => new(Controls.ClickableControl<RoundRectangle>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this ScrollView _) => new(Controls.ClickableControl<ScrollView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this SearchBar _) => new(Controls.ClickableControl<SearchBar>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the SelectableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this SelectableItemsView _) => new(Controls.ClickableControl<SelectableItemsView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Shape _) => new(Controls.ClickableControl<Shape>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Slider _) => new(Controls.ClickableControl<Slider>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Span _) => new(Controls.ClickableControl<Span>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the StackBase control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this StackBase _) => new(Controls.ClickableControl<StackBase>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the StackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this StackLayout _) => new(Controls.ClickableControl<StackLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Microsoft.Maui.Controls.Compatibility.StackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.StackLayout _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.StackLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Stepper control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Stepper _) => new(Controls.ClickableControl<Stepper>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this StructuredItemsView _) => new(Controls.ClickableControl<StructuredItemsView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the SwipeItemView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this SwipeItemView _) => new(Controls.ClickableControl<SwipeItemView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the SwipeView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this SwipeView _) => new(Controls.ClickableControl<SwipeView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Switch control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Switch _) => new(Controls.ClickableControl<Switch>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the TableView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this TableView _) => new(Controls.ClickableControl<TableView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the TemplatedView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this TemplatedView _) => new(Controls.ClickableControl<TemplatedView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this TimePicker _) => new(Controls.ClickableControl<TimePicker>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the VerticalStackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this VerticalStackLayout _) => new(Controls.ClickableControl<VerticalStackLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the View control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this View _) => new(Controls.ClickableControl<View>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the WebView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this WebView _) => new(Controls.ClickableControl<WebView>.CommandProperty);

    // ***** AbsoluteLayout Bindings *****

    /// <summary>
    /// Allows binding to the LayoutBoundsProperty as BindLayoutBounds for the AbsoluteLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AbsoluteLayout.</returns>
    public static Bindings.BindableProperty<Rect> BindLayoutBounds(this AbsoluteLayout _) => Bindings.BindableProperty<Rect>.Create(AbsoluteLayout.LayoutBoundsProperty);

    /// <summary>
    /// Allows binding to the LayoutFlagsProperty as BindLayoutFlags for the AbsoluteLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AbsoluteLayout.</returns>
    public static Bindings.BindableProperty<AbsoluteLayoutFlags> BindLayoutFlags(this AbsoluteLayout _) => Bindings.BindableProperty<AbsoluteLayoutFlags>.Create(AbsoluteLayout.LayoutFlagsProperty);

    // ***** Microsoft.Maui.Controls.Compatibility.AbsoluteLayout Bindings *****

    /// <summary>
    /// Allows binding to the LayoutBoundsProperty as BindLayoutBounds for the Microsoft.Maui.Controls.Compatibility.AbsoluteLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.AbsoluteLayout.</returns>
    public static Bindings.BindableProperty<Rect> BindLayoutBounds(this Microsoft.Maui.Controls.Compatibility.AbsoluteLayout _) => Bindings.BindableProperty<Rect>.Create(Microsoft.Maui.Controls.Compatibility.AbsoluteLayout.LayoutBoundsProperty);

    /// <summary>
    /// Allows binding to the LayoutFlagsProperty as BindLayoutFlags for the Microsoft.Maui.Controls.Compatibility.AbsoluteLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.AbsoluteLayout.</returns>
    public static Bindings.BindableProperty<AbsoluteLayoutFlags> BindLayoutFlags(this Microsoft.Maui.Controls.Compatibility.AbsoluteLayout _) => Bindings.BindableProperty<AbsoluteLayoutFlags>.Create(Microsoft.Maui.Controls.Compatibility.AbsoluteLayout.LayoutFlagsProperty);

    // ***** ActivityIndicator Bindings *****

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the ActivityIndicator control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ActivityIndicator.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this ActivityIndicator _) => Bindings.BindableProperty<Color>.Create(ActivityIndicator.ColorProperty);

    /// <summary>
    /// Allows binding to the IsRunningProperty as BindIsRunning for the ActivityIndicator control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ActivityIndicator.</returns>
    public static Bindings.BindableProperty<bool> BindIsRunning(this ActivityIndicator _) => Bindings.BindableProperty<bool>.Create(ActivityIndicator.IsRunningProperty);

    // ***** AdaptiveTrigger Bindings *****

    /// <summary>
    /// Allows binding to the MinWindowHeightProperty as BindMinWindowHeight for the AdaptiveTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AdaptiveTrigger.</returns>
    public static Bindings.BindableProperty<double> BindMinWindowHeight(this AdaptiveTrigger _) => Bindings.BindableProperty<double>.Create(AdaptiveTrigger.MinWindowHeightProperty);

    /// <summary>
    /// Allows binding to the MinWindowWidthProperty as BindMinWindowWidth for the AdaptiveTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AdaptiveTrigger.</returns>
    public static Bindings.BindableProperty<double> BindMinWindowWidth(this AdaptiveTrigger _) => Bindings.BindableProperty<double>.Create(AdaptiveTrigger.MinWindowWidthProperty);

    // ***** AppLinkEntry Bindings *****

    /// <summary>
    /// Allows binding to the AppLinkUriProperty as BindAppLinkUri for the AppLinkEntry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AppLinkEntry.</returns>
    public static Bindings.BindableProperty<Uri> BindAppLinkUri(this AppLinkEntry _) => Bindings.BindableProperty<Uri>.Create(AppLinkEntry.AppLinkUriProperty);

    /// <summary>
    /// Allows binding to the DescriptionProperty as BindDescription for the AppLinkEntry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AppLinkEntry.</returns>
    public static Bindings.BindableProperty<string> BindDescription(this AppLinkEntry _) => Bindings.BindableProperty<string>.Create(AppLinkEntry.DescriptionProperty);

    /// <summary>
    /// Allows binding to the IsLinkActiveProperty as BindIsLinkActive for the AppLinkEntry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AppLinkEntry.</returns>
    public static Bindings.BindableProperty<bool> BindIsLinkActive(this AppLinkEntry _) => Bindings.BindableProperty<bool>.Create(AppLinkEntry.IsLinkActiveProperty);

    /// <summary>
    /// Allows binding to the ThumbnailProperty as BindThumbnail for the AppLinkEntry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AppLinkEntry.</returns>
    public static Bindings.BindableProperty<ImageSource> BindThumbnail(this AppLinkEntry _) => Bindings.BindableProperty<ImageSource>.Create(AppLinkEntry.ThumbnailProperty);

    /// <summary>
    /// Allows binding to the TitleProperty as BindTitle for the AppLinkEntry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AppLinkEntry.</returns>
    public static Bindings.BindableProperty<string> BindTitle(this AppLinkEntry _) => Bindings.BindableProperty<string>.Create(AppLinkEntry.TitleProperty);

    // ***** ArcSegment Bindings *****

    /// <summary>
    /// Allows binding to the IsLargeArcProperty as BindIsLargeArc for the ArcSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ArcSegment.</returns>
    public static Bindings.BindableProperty<bool> BindIsLargeArc(this ArcSegment _) => Bindings.BindableProperty<bool>.Create(ArcSegment.IsLargeArcProperty);

    /// <summary>
    /// Allows binding to the PointProperty as BindPoint for the ArcSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ArcSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint(this ArcSegment _) => Bindings.BindableProperty<Point>.Create(ArcSegment.PointProperty);

    /// <summary>
    /// Allows binding to the RotationAngleProperty as BindRotationAngle for the ArcSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ArcSegment.</returns>
    public static Bindings.BindableProperty<double> BindRotationAngle(this ArcSegment _) => Bindings.BindableProperty<double>.Create(ArcSegment.RotationAngleProperty);

    /// <summary>
    /// Allows binding to the SizeProperty as BindSize for the ArcSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ArcSegment.</returns>
    public static Bindings.BindableProperty<Size> BindSize(this ArcSegment _) => Bindings.BindableProperty<Size>.Create(ArcSegment.SizeProperty);

    /// <summary>
    /// Allows binding to the SweepDirectionProperty as BindSweepDirection for the ArcSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ArcSegment.</returns>
    public static Bindings.BindableProperty<SweepDirection> BindSweepDirection(this ArcSegment _) => Bindings.BindableProperty<SweepDirection>.Create(ArcSegment.SweepDirectionProperty);

    // ***** BackButtonBehavior Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the BackButtonBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BackButtonBehavior.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this BackButtonBehavior _) => Bindings.BindableProperty<object>.Create(BackButtonBehavior.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the BackButtonBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BackButtonBehavior.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this BackButtonBehavior _) => Bindings.BindableProperty<ICommand>.Create(BackButtonBehavior.CommandProperty);

    /// <summary>
    /// Allows binding to the IconOverrideProperty as BindIconOverride for the BackButtonBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BackButtonBehavior.</returns>
    public static Bindings.BindableProperty<ImageSource> BindIconOverride(this BackButtonBehavior _) => Bindings.BindableProperty<ImageSource>.Create(BackButtonBehavior.IconOverrideProperty);

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the BackButtonBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BackButtonBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this BackButtonBehavior _) => Bindings.BindableProperty<bool>.Create(BackButtonBehavior.IsEnabledProperty);

    /// <summary>
    /// Allows binding to the IsVisibleProperty as BindIsVisible for the BackButtonBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BackButtonBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindIsVisible(this BackButtonBehavior _) => Bindings.BindableProperty<bool>.Create(BackButtonBehavior.IsVisibleProperty);

    /// <summary>
    /// Allows binding to the TextOverrideProperty as BindTextOverride for the BackButtonBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BackButtonBehavior.</returns>
    public static Bindings.BindableProperty<string> BindTextOverride(this BackButtonBehavior _) => Bindings.BindableProperty<string>.Create(BackButtonBehavior.TextOverrideProperty);

    // ***** BaseShellItem Bindings *****

    /// <summary>
    /// Allows binding to the FlyoutIconProperty as BindFlyoutIcon for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<ImageSource> BindFlyoutIcon(this BaseShellItem _) => Bindings.BindableProperty<ImageSource>.Create(BaseShellItem.FlyoutIconProperty);

    /// <summary>
    /// Allows binding to the IconProperty as BindIcon for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<ImageSource> BindIcon(this BaseShellItem _) => Bindings.BindableProperty<ImageSource>.Create(BaseShellItem.IconProperty);

    /// <summary>
    /// Allows binding to the IsCheckedProperty as BindIsChecked for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsChecked(this BaseShellItem _) => Bindings.BindableProperty<bool>.Create(BaseShellItem.IsCheckedProperty);

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this BaseShellItem _) => Bindings.BindableProperty<bool>.Create(BaseShellItem.IsEnabledProperty);

    /// <summary>
    /// Allows binding to the IsVisibleProperty as BindIsVisible for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsVisible(this BaseShellItem _) => Bindings.BindableProperty<bool>.Create(BaseShellItem.IsVisibleProperty);

    /// <summary>
    /// Allows binding to the TitleProperty as BindTitle for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<string> BindTitle(this BaseShellItem _) => Bindings.BindableProperty<string>.Create(BaseShellItem.TitleProperty);

    /// <summary>
    /// Allows binding to the WindowProperty as BindWindow for the BaseShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BaseShellItem.</returns>
    public static Bindings.BindableProperty<Window> BindWindow(this BaseShellItem _) => Bindings.BindableProperty<Window>.Create(BaseShellItem.WindowProperty);

    // ***** BezierSegment Bindings *****

    /// <summary>
    /// Allows binding to the Point1Property as BindPoint1 for the BezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BezierSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint1(this BezierSegment _) => Bindings.BindableProperty<Point>.Create(BezierSegment.Point1Property);

    /// <summary>
    /// Allows binding to the Point2Property as BindPoint2 for the BezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BezierSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint2(this BezierSegment _) => Bindings.BindableProperty<Point>.Create(BezierSegment.Point2Property);

    /// <summary>
    /// Allows binding to the Point3Property as BindPoint3 for the BezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BezierSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint3(this BezierSegment _) => Bindings.BindableProperty<Point>.Create(BezierSegment.Point3Property);

    // ***** BindableObject Bindings *****

    /// <summary>
    /// Allows binding to the BindingContextProperty as BindBindingContext for the BindableObject control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BindableObject.</returns>
    public static Bindings.BindableProperty<object> BindBindingContext(this BindableObject _) => Bindings.BindableProperty<object>.Create(BindableObject.BindingContextProperty);

    // ***** Border Bindings *****

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<View> BindContent(this Border _) => Bindings.BindableProperty<View>.Create(Border.ContentProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this Border _) => Bindings.BindableProperty<Thickness>.Create(Border.PaddingProperty);

    /// <summary>
    /// Allows binding to the StrokeDashArrayProperty as BindStrokeDashArray for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<DoubleCollection> BindStrokeDashArray(this Border _) => Bindings.BindableProperty<DoubleCollection>.Create(Border.StrokeDashArrayProperty);

    /// <summary>
    /// Allows binding to the StrokeDashOffsetProperty as BindStrokeDashOffset for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<double> BindStrokeDashOffset(this Border _) => Bindings.BindableProperty<double>.Create(Border.StrokeDashOffsetProperty);

    /// <summary>
    /// Allows binding to the StrokeLineCapProperty as BindStrokeLineCap for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<PenLineCap> BindStrokeLineCap(this Border _) => Bindings.BindableProperty<PenLineCap>.Create(Border.StrokeLineCapProperty);

    /// <summary>
    /// Allows binding to the StrokeLineJoinProperty as BindStrokeLineJoin for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<PenLineJoin> BindStrokeLineJoin(this Border _) => Bindings.BindableProperty<PenLineJoin>.Create(Border.StrokeLineJoinProperty);

    /// <summary>
    /// Allows binding to the StrokeMiterLimitProperty as BindStrokeMiterLimit for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<double> BindStrokeMiterLimit(this Border _) => Bindings.BindableProperty<double>.Create(Border.StrokeMiterLimitProperty);

    /// <summary>
    /// Allows binding to the StrokeProperty as BindStroke for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<Brush> BindStroke(this Border _) => Bindings.BindableProperty<Brush>.Create(Border.StrokeProperty);

    /// <summary>
    /// Allows binding to the StrokeShapeProperty as BindStrokeShape for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<IShape> BindStrokeShape(this Border _) => Bindings.BindableProperty<IShape>.Create(Border.StrokeShapeProperty);

    /// <summary>
    /// Allows binding to the StrokeThicknessProperty as BindStrokeThickness for the Border control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Border.</returns>
    public static Bindings.BindableProperty<double> BindStrokeThickness(this Border _) => Bindings.BindableProperty<double>.Create(Border.StrokeThicknessProperty);

    // ***** BoxView Bindings *****

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the BoxView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BoxView.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this BoxView _) => Bindings.BindableProperty<Color>.Create(BoxView.ColorProperty);

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the BoxView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type BoxView.</returns>
    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this BoxView _) => Bindings.BindableProperty<CornerRadius>.Create(BoxView.CornerRadiusProperty);

    // ***** Button Bindings *****

    /// <summary>
    /// Allows binding to the BorderColorProperty as BindBorderColor for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<Color> BindBorderColor(this Button _) => Bindings.BindableProperty<Color>.Create(Button.BorderColorProperty);

    /// <summary>
    /// Allows binding to the BorderWidthProperty as BindBorderWidth for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<double> BindBorderWidth(this Button _) => Bindings.BindableProperty<double>.Create(Button.BorderWidthProperty);

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Button _) => Bindings.BindableProperty<double>.Create(Button.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this Button _) => Bindings.BindableProperty<object>.Create(Button.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this Button _) => Bindings.BindableProperty<ICommand>.Create(Button.CommandProperty);

    /// <summary>
    /// Allows binding to the ContentLayoutProperty as BindContentLayout for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<ButtonContentLayout> BindContentLayout(this Button _) => Bindings.BindableProperty<ButtonContentLayout>.Create(Button.ContentLayoutProperty);

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<int> BindCornerRadius(this Button _) => Bindings.BindableProperty<int>.Create(Button.CornerRadiusProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Button _) => Bindings.BindableProperty<FontAttributes>.Create(Button.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Button _) => Bindings.BindableProperty<bool>.Create(Button.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this Button _) => Bindings.BindableProperty<string>.Create(Button.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this Button _) => Bindings.BindableProperty<double>.Create(Button.FontSizeProperty);

    /// <summary>
    /// Allows binding to the ImageSourceProperty as BindImageSource for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<ImageSource> BindImageSource(this Button _) => Bindings.BindableProperty<ImageSource>.Create(Button.ImageSourceProperty);

    /// <summary>
    /// Allows binding to the IsPressedProperty as BindIsPressed for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<bool> BindIsPressed(this Button _) => Bindings.BindableProperty<bool>.Create(Button.IsPressedProperty);

    /// <summary>
    /// Allows binding to the LineBreakModeProperty as BindLineBreakMode for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<LineBreakMode> BindLineBreakMode(this Button _) => Bindings.BindableProperty<LineBreakMode>.Create(Button.LineBreakModeProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this Button _) => Bindings.BindableProperty<Thickness>.Create(Button.PaddingProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this Button _) => Bindings.BindableProperty<Color>.Create(Button.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<string> BindText(this Button _) => Bindings.BindableProperty<string>.Create(Button.TextProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the Button control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Button.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this Button _) => Bindings.BindableProperty<TextTransform>.Create(Button.TextTransformProperty);

    // ***** CarouselView Bindings *****

    /// <summary>
    /// Allows binding to the CurrentItemChangedCommandParameterProperty as BindCurrentItemChangedCommandParameter for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<object> BindCurrentItemChangedCommandParameter(this CarouselView _) => Bindings.BindableProperty<object>.Create(CarouselView.CurrentItemChangedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the CurrentItemChangedCommandProperty as BindCurrentItemChangedCommand for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<ICommand> BindCurrentItemChangedCommand(this CarouselView _) => Bindings.BindableProperty<ICommand>.Create(CarouselView.CurrentItemChangedCommandProperty);

    /// <summary>
    /// Allows binding to the CurrentItemProperty as BindCurrentItem for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<object> BindCurrentItem(this CarouselView _) => Bindings.BindableProperty<object>.Create(CarouselView.CurrentItemProperty);

    /// <summary>
    /// Allows binding to the IsBounceEnabledProperty as BindIsBounceEnabled for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<bool> BindIsBounceEnabled(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsBounceEnabledProperty);

    /// <summary>
    /// Allows binding to the IsDraggingProperty as BindIsDragging for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<bool> BindIsDragging(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsDraggingProperty);

    /// <summary>
    /// Allows binding to the IsScrollAnimatedProperty as BindIsScrollAnimated for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<bool> BindIsScrollAnimated(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsScrollAnimatedProperty);

    /// <summary>
    /// Allows binding to the IsSwipeEnabledProperty as BindIsSwipeEnabled for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<bool> BindIsSwipeEnabled(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsSwipeEnabledProperty);

    /// <summary>
    /// Allows binding to the ItemsLayoutProperty as BindItemsLayout for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<LinearItemsLayout> BindItemsLayout(this CarouselView _) => Bindings.BindableProperty<LinearItemsLayout>.Create(CarouselView.ItemsLayoutProperty);

    /// <summary>
    /// Allows binding to the LoopProperty as BindLoop for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<bool> BindLoop(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.LoopProperty);

    /// <summary>
    /// Allows binding to the PeekAreaInsetsProperty as BindPeekAreaInsets for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<Thickness> BindPeekAreaInsets(this CarouselView _) => Bindings.BindableProperty<Thickness>.Create(CarouselView.PeekAreaInsetsProperty);

    /// <summary>
    /// Allows binding to the PositionChangedCommandParameterProperty as BindPositionChangedCommandParameter for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<object> BindPositionChangedCommandParameter(this CarouselView _) => Bindings.BindableProperty<object>.Create(CarouselView.PositionChangedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the PositionChangedCommandProperty as BindPositionChangedCommand for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<ICommand> BindPositionChangedCommand(this CarouselView _) => Bindings.BindableProperty<ICommand>.Create(CarouselView.PositionChangedCommandProperty);

    /// <summary>
    /// Allows binding to the PositionProperty as BindPosition for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<int> BindPosition(this CarouselView _) => Bindings.BindableProperty<int>.Create(CarouselView.PositionProperty);

    /// <summary>
    /// Allows binding to the VisibleViewsProperty as BindVisibleViews for the CarouselView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CarouselView.</returns>
    public static Bindings.BindableProperty<ObservableCollection<View>> BindVisibleViews(this CarouselView _) => Bindings.BindableProperty<ObservableCollection<View>>.Create(CarouselView.VisibleViewsProperty);

    // ***** Cell Bindings *****

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the Cell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Cell.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this Cell _) => Bindings.BindableProperty<bool>.Create(Cell.IsEnabledProperty);

    // ***** CheckBox Bindings *****

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the CheckBox control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CheckBox.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this CheckBox _) => Bindings.BindableProperty<Color>.Create(CheckBox.ColorProperty);

    /// <summary>
    /// Allows binding to the IsCheckedProperty as BindIsChecked for the CheckBox control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CheckBox.</returns>
    public static Bindings.BindableProperty<bool> BindIsChecked(this CheckBox _) => Bindings.BindableProperty<bool>.Create(CheckBox.IsCheckedProperty);

    // ***** ClickGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the ButtonsProperty as BindButtons for the ClickGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ClickGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ButtonsMask> BindButtons(this ClickGestureRecognizer _) => Bindings.BindableProperty<ButtonsMask>.Create(ClickGestureRecognizer.ButtonsProperty);

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the ClickGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ClickGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this ClickGestureRecognizer _) => Bindings.BindableProperty<object>.Create(ClickGestureRecognizer.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the ClickGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ClickGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this ClickGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(ClickGestureRecognizer.CommandProperty);

    /// <summary>
    /// Allows binding to the NumberOfClicksRequiredProperty as BindNumberOfClicksRequired for the ClickGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ClickGestureRecognizer.</returns>
    public static Bindings.BindableProperty<int> BindNumberOfClicksRequired(this ClickGestureRecognizer _) => Bindings.BindableProperty<int>.Create(ClickGestureRecognizer.NumberOfClicksRequiredProperty);

    // ***** ColumnDefinition Bindings *****

    /// <summary>
    /// Allows binding to the WidthProperty as BindWidth for the ColumnDefinition control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ColumnDefinition.</returns>
    public static Bindings.BindableProperty<GridLength> BindWidth(this ColumnDefinition _) => Bindings.BindableProperty<GridLength>.Create(ColumnDefinition.WidthProperty);

    // ***** CompareStateTrigger Bindings *****

    /// <summary>
    /// Allows binding to the PropertyProperty as Bind for the CompareStateTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompareStateTrigger.</returns>
    public static Bindings.BindableProperty<object> Bind(this CompareStateTrigger _) => Bindings.BindableProperty<object>.Create(CompareStateTrigger.PropertyProperty);

    /// <summary>
    /// Allows binding to the ValueProperty as BindValue for the CompareStateTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompareStateTrigger.</returns>
    public static Bindings.BindableProperty<object> BindValue(this CompareStateTrigger _) => Bindings.BindableProperty<object>.Create(CompareStateTrigger.ValueProperty);

    // ***** CompositeTransform Bindings *****

    /// <summary>
    /// Allows binding to the CenterXProperty as BindCenterX for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.CenterXProperty);

    /// <summary>
    /// Allows binding to the CenterYProperty as BindCenterY for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.CenterYProperty);

    /// <summary>
    /// Allows binding to the RotationProperty as BindRotation for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindRotation(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.RotationProperty);

    /// <summary>
    /// Allows binding to the ScaleXProperty as BindScaleX for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindScaleX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.ScaleXProperty);

    /// <summary>
    /// Allows binding to the ScaleYProperty as BindScaleY for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindScaleY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.ScaleYProperty);

    /// <summary>
    /// Allows binding to the SkewXProperty as BindSkewX for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindSkewX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.SkewXProperty);

    /// <summary>
    /// Allows binding to the SkewYProperty as BindSkewY for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindSkewY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.SkewYProperty);

    /// <summary>
    /// Allows binding to the TranslateXProperty as BindTranslateX for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindTranslateX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.TranslateXProperty);

    /// <summary>
    /// Allows binding to the TranslateYProperty as BindTranslateY for the CompositeTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CompositeTransform.</returns>
    public static Bindings.BindableProperty<double> BindTranslateY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.TranslateYProperty);

    // ***** ContentPage Bindings *****

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the ContentPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ContentPage.</returns>
    public static Bindings.BindableProperty<View> BindContent(this ContentPage _) => Bindings.BindableProperty<View>.Create(ContentPage.ContentProperty);

    // ***** ContentPresenter Bindings *****

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the ContentPresenter control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ContentPresenter.</returns>
    public static Bindings.BindableProperty<View> BindContent(this ContentPresenter _) => Bindings.BindableProperty<View>.Create(ContentPresenter.ContentProperty);

    // ***** ContentView Bindings *****

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the ContentView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ContentView.</returns>
    public static Bindings.BindableProperty<View> BindContent(this ContentView _) => Bindings.BindableProperty<View>.Create(ContentView.ContentProperty);

    // ***** DatePicker Bindings *****

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this DatePicker _) => Bindings.BindableProperty<double>.Create(DatePicker.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the DateProperty as BindDate for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<DateTime> BindDate(this DatePicker _) => Bindings.BindableProperty<DateTime>.Create(DatePicker.DateProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this DatePicker _) => Bindings.BindableProperty<FontAttributes>.Create(DatePicker.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this DatePicker _) => Bindings.BindableProperty<bool>.Create(DatePicker.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this DatePicker _) => Bindings.BindableProperty<string>.Create(DatePicker.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this DatePicker _) => Bindings.BindableProperty<double>.Create(DatePicker.FontSizeProperty);

    /// <summary>
    /// Allows binding to the FormatProperty as BindFormat for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<string> BindFormat(this DatePicker _) => Bindings.BindableProperty<string>.Create(DatePicker.FormatProperty);

    /// <summary>
    /// Allows binding to the MaximumDateProperty as BindMaximumDate for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<DateTime> BindMaximumDate(this DatePicker _) => Bindings.BindableProperty<DateTime>.Create(DatePicker.MaximumDateProperty);

    /// <summary>
    /// Allows binding to the MinimumDateProperty as BindMinimumDate for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<DateTime> BindMinimumDate(this DatePicker _) => Bindings.BindableProperty<DateTime>.Create(DatePicker.MinimumDateProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the DatePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DatePicker.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this DatePicker _) => Bindings.BindableProperty<Color>.Create(DatePicker.TextColorProperty);

    // ***** DeviceStateTrigger Bindings *****

    /// <summary>
    /// Allows binding to the DeviceProperty as BindDevice for the DeviceStateTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DeviceStateTrigger.</returns>
    public static Bindings.BindableProperty<string> BindDevice(this DeviceStateTrigger _) => Bindings.BindableProperty<string>.Create(DeviceStateTrigger.DeviceProperty);

    // ***** DragGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the CanDragProperty as BindCanDrag for the DragGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DragGestureRecognizer.</returns>
    public static Bindings.BindableProperty<bool> BindCanDrag(this DragGestureRecognizer _) => Bindings.BindableProperty<bool>.Create(DragGestureRecognizer.CanDragProperty);

    /// <summary>
    /// Allows binding to the DragStartingCommandParameterProperty as BindDragStartingCommandParameter for the DragGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DragGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindDragStartingCommandParameter(this DragGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DragGestureRecognizer.DragStartingCommandParameterProperty);

    /// <summary>
    /// Allows binding to the DragStartingCommandProperty as BindDragStartingCommand for the DragGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DragGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindDragStartingCommand(this DragGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DragGestureRecognizer.DragStartingCommandProperty);

    /// <summary>
    /// Allows binding to the DropCompletedCommandParameterProperty as BindDropCompletedCommandParameter for the DragGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DragGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindDropCompletedCommandParameter(this DragGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DragGestureRecognizer.DropCompletedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the DropCompletedCommandProperty as BindDropCompletedCommand for the DragGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DragGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindDropCompletedCommand(this DragGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DragGestureRecognizer.DropCompletedCommandProperty);

    // ***** DropGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the AllowDropProperty as BindAllowDrop for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<bool> BindAllowDrop(this DropGestureRecognizer _) => Bindings.BindableProperty<bool>.Create(DropGestureRecognizer.AllowDropProperty);

    /// <summary>
    /// Allows binding to the DragLeaveCommandParameterProperty as BindDragLeaveCommandParameter for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindDragLeaveCommandParameter(this DropGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DropGestureRecognizer.DragLeaveCommandParameterProperty);

    /// <summary>
    /// Allows binding to the DragLeaveCommandProperty as BindDragLeaveCommand for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindDragLeaveCommand(this DropGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DropGestureRecognizer.DragLeaveCommandProperty);

    /// <summary>
    /// Allows binding to the DragOverCommandParameterProperty as BindDragOverCommandParameter for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindDragOverCommandParameter(this DropGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DropGestureRecognizer.DragOverCommandParameterProperty);

    /// <summary>
    /// Allows binding to the DragOverCommandProperty as BindDragOverCommand for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindDragOverCommand(this DropGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DropGestureRecognizer.DragOverCommandProperty);

    /// <summary>
    /// Allows binding to the DropCommandParameterProperty as BindDropCommandParameter for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindDropCommandParameter(this DropGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DropGestureRecognizer.DropCommandParameterProperty);

    /// <summary>
    /// Allows binding to the DropCommandProperty as BindDropCommand for the DropGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DropGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindDropCommand(this DropGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DropGestureRecognizer.DropCommandProperty);

    // ***** Editor Bindings *****

    /// <summary>
    /// Allows binding to the AutoSizeProperty as BindAutoSize for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<EditorAutoSizeOption> BindAutoSize(this Editor _) => Bindings.BindableProperty<EditorAutoSizeOption>.Create(Editor.AutoSizeProperty);

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Editor _) => Bindings.BindableProperty<double>.Create(Editor.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the CursorPositionProperty as BindCursorPosition for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<int> BindCursorPosition(this Editor _) => Bindings.BindableProperty<int>.Create(Editor.CursorPositionProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Editor _) => Bindings.BindableProperty<FontAttributes>.Create(Editor.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Editor _) => Bindings.BindableProperty<bool>.Create(Editor.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this Editor _) => Bindings.BindableProperty<string>.Create(Editor.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this Editor _) => Bindings.BindableProperty<double>.Create(Editor.FontSizeProperty);

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Editor _) => Bindings.BindableProperty<TextAlignment>.Create(Editor.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the IsTextPredictionEnabledProperty as BindIsTextPredictionEnabled for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<bool> BindIsTextPredictionEnabled(this Editor _) => Bindings.BindableProperty<bool>.Create(Editor.IsTextPredictionEnabledProperty);

    /// <summary>
    /// Allows binding to the PlaceholderColorProperty as BindPlaceholderColor for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this Editor _) => Bindings.BindableProperty<Color>.Create(Editor.PlaceholderColorProperty);

    /// <summary>
    /// Allows binding to the PlaceholderProperty as BindPlaceholder for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<string> BindPlaceholder(this Editor _) => Bindings.BindableProperty<string>.Create(Editor.PlaceholderProperty);

    /// <summary>
    /// Allows binding to the SelectionLengthProperty as BindSelectionLength for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<int> BindSelectionLength(this Editor _) => Bindings.BindableProperty<int>.Create(Editor.SelectionLengthProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this Editor _) => Bindings.BindableProperty<Color>.Create(Editor.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<string> BindText(this Editor _) => Bindings.BindableProperty<string>.Create(Editor.TextProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the Editor control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Editor.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Editor _) => Bindings.BindableProperty<TextAlignment>.Create(Editor.VerticalTextAlignmentProperty);

    // ***** Element Bindings *****

    /// <summary>
    /// Allows binding to the AutomationIdProperty as BindAutomationId for the Element control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Element.</returns>
    public static Bindings.BindableProperty<string> BindAutomationId(this Element _) => Bindings.BindableProperty<string>.Create(Element.AutomationIdProperty);

    /// <summary>
    /// Allows binding to the ClassIdProperty as BindClassId for the Element control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Element.</returns>
    public static Bindings.BindableProperty<string> BindClassId(this Element _) => Bindings.BindableProperty<string>.Create(Element.ClassIdProperty);

    // ***** EllipseGeometry Bindings *****

    /// <summary>
    /// Allows binding to the CenterProperty as BindCenter for the EllipseGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EllipseGeometry.</returns>
    public static Bindings.BindableProperty<Point> BindCenter(this EllipseGeometry _) => Bindings.BindableProperty<Point>.Create(EllipseGeometry.CenterProperty);

    /// <summary>
    /// Allows binding to the RadiusXProperty as BindRadiusX for the EllipseGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EllipseGeometry.</returns>
    public static Bindings.BindableProperty<double> BindRadiusX(this EllipseGeometry _) => Bindings.BindableProperty<double>.Create(EllipseGeometry.RadiusXProperty);

    /// <summary>
    /// Allows binding to the RadiusYProperty as BindRadiusY for the EllipseGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EllipseGeometry.</returns>
    public static Bindings.BindableProperty<double> BindRadiusY(this EllipseGeometry _) => Bindings.BindableProperty<double>.Create(EllipseGeometry.RadiusYProperty);

    // ***** Entry Bindings *****

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Entry _) => Bindings.BindableProperty<double>.Create(Entry.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the ClearButtonVisibilityProperty as BindClearButtonVisibility for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<ClearButtonVisibility> BindClearButtonVisibility(this Entry _) => Bindings.BindableProperty<ClearButtonVisibility>.Create(Entry.ClearButtonVisibilityProperty);

    /// <summary>
    /// Allows binding to the CursorPositionProperty as BindCursorPosition for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<int> BindCursorPosition(this Entry _) => Bindings.BindableProperty<int>.Create(Entry.CursorPositionProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Entry _) => Bindings.BindableProperty<FontAttributes>.Create(Entry.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Entry _) => Bindings.BindableProperty<bool>.Create(Entry.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this Entry _) => Bindings.BindableProperty<string>.Create(Entry.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this Entry _) => Bindings.BindableProperty<double>.Create(Entry.FontSizeProperty);

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Entry _) => Bindings.BindableProperty<TextAlignment>.Create(Entry.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the IsPasswordProperty as BindIsPassword for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<bool> BindIsPassword(this Entry _) => Bindings.BindableProperty<bool>.Create(Entry.IsPasswordProperty);

    /// <summary>
    /// Allows binding to the IsTextPredictionEnabledProperty as BindIsTextPredictionEnabled for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<bool> BindIsTextPredictionEnabled(this Entry _) => Bindings.BindableProperty<bool>.Create(Entry.IsTextPredictionEnabledProperty);

    /// <summary>
    /// Allows binding to the KeyboardProperty as BindKeyboard for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this Entry _) => Bindings.BindableProperty<Keyboard>.Create(Entry.KeyboardProperty);

    /// <summary>
    /// Allows binding to the PlaceholderColorProperty as BindPlaceholderColor for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this Entry _) => Bindings.BindableProperty<Color>.Create(Entry.PlaceholderColorProperty);

    /// <summary>
    /// Allows binding to the PlaceholderProperty as BindPlaceholder for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<string> BindPlaceholder(this Entry _) => Bindings.BindableProperty<string>.Create(Entry.PlaceholderProperty);

    /// <summary>
    /// Allows binding to the ReturnCommandParameterProperty as BindReturnCommandParameter for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<object> BindReturnCommandParameter(this Entry _) => Bindings.BindableProperty<object>.Create(Entry.ReturnCommandParameterProperty);

    /// <summary>
    /// Allows binding to the ReturnCommandProperty as BindReturnCommand for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<ICommand> BindReturnCommand(this Entry _) => Bindings.BindableProperty<ICommand>.Create(Entry.ReturnCommandProperty);

    /// <summary>
    /// Allows binding to the ReturnTypeProperty as BindReturnType for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<ReturnType> BindReturnType(this Entry _) => Bindings.BindableProperty<ReturnType>.Create(Entry.ReturnTypeProperty);

    /// <summary>
    /// Allows binding to the SelectionLengthProperty as BindSelectionLength for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<int> BindSelectionLength(this Entry _) => Bindings.BindableProperty<int>.Create(Entry.SelectionLengthProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this Entry _) => Bindings.BindableProperty<Color>.Create(Entry.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<string> BindText(this Entry _) => Bindings.BindableProperty<string>.Create(Entry.TextProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the Entry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Entry.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Entry _) => Bindings.BindableProperty<TextAlignment>.Create(Entry.VerticalTextAlignmentProperty);

    // ***** EntryCell Bindings *****

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this EntryCell _) => Bindings.BindableProperty<TextAlignment>.Create(EntryCell.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the KeyboardProperty as BindKeyboard for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this EntryCell _) => Bindings.BindableProperty<Keyboard>.Create(EntryCell.KeyboardProperty);

    /// <summary>
    /// Allows binding to the LabelColorProperty as BindLabelColor for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<Color> BindLabelColor(this EntryCell _) => Bindings.BindableProperty<Color>.Create(EntryCell.LabelColorProperty);

    /// <summary>
    /// Allows binding to the LabelProperty as BindLabel for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<string> BindLabel(this EntryCell _) => Bindings.BindableProperty<string>.Create(EntryCell.LabelProperty);

    /// <summary>
    /// Allows binding to the PlaceholderProperty as BindPlaceholder for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<string> BindPlaceholder(this EntryCell _) => Bindings.BindableProperty<string>.Create(EntryCell.PlaceholderProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<string> BindText(this EntryCell _) => Bindings.BindableProperty<string>.Create(EntryCell.TextProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the EntryCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EntryCell.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this EntryCell _) => Bindings.BindableProperty<TextAlignment>.Create(EntryCell.VerticalTextAlignmentProperty);

    // ***** FileImageSource Bindings *****

    /// <summary>
    /// Allows binding to the FileProperty as BindFile for the FileImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FileImageSource.</returns>
    public static Bindings.BindableProperty<string> BindFile(this FileImageSource _) => Bindings.BindableProperty<string>.Create(FileImageSource.FileProperty);

    // ***** FlexLayout Bindings *****

    /// <summary>
    /// Allows binding to the AlignContentProperty as BindAlignContent for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexAlignContent> BindAlignContent(this FlexLayout _) => Bindings.BindableProperty<FlexAlignContent>.Create(FlexLayout.AlignContentProperty);

    /// <summary>
    /// Allows binding to the AlignItemsProperty as BindAlignItems for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexAlignItems> BindAlignItems(this FlexLayout _) => Bindings.BindableProperty<FlexAlignItems>.Create(FlexLayout.AlignItemsProperty);

    /// <summary>
    /// Allows binding to the AlignSelfProperty as BindAlignSelf for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexAlignSelf> BindAlignSelf(this FlexLayout _) => Bindings.BindableProperty<FlexAlignSelf>.Create(FlexLayout.AlignSelfProperty);

    /// <summary>
    /// Allows binding to the BasisProperty as BindBasis for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexBasis> BindBasis(this FlexLayout _) => Bindings.BindableProperty<FlexBasis>.Create(FlexLayout.BasisProperty);

    /// <summary>
    /// Allows binding to the DirectionProperty as BindDirection for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexDirection> BindDirection(this FlexLayout _) => Bindings.BindableProperty<FlexDirection>.Create(FlexLayout.DirectionProperty);

    /// <summary>
    /// Allows binding to the GrowProperty as BindGrow for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<float> BindGrow(this FlexLayout _) => Bindings.BindableProperty<float>.Create(FlexLayout.GrowProperty);

    /// <summary>
    /// Allows binding to the JustifyContentProperty as BindJustifyContent for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexJustify> BindJustifyContent(this FlexLayout _) => Bindings.BindableProperty<FlexJustify>.Create(FlexLayout.JustifyContentProperty);

    /// <summary>
    /// Allows binding to the OrderProperty as BindOrder for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<int> BindOrder(this FlexLayout _) => Bindings.BindableProperty<int>.Create(FlexLayout.OrderProperty);

    /// <summary>
    /// Allows binding to the PositionProperty as BindPosition for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexPosition> BindPosition(this FlexLayout _) => Bindings.BindableProperty<FlexPosition>.Create(FlexLayout.PositionProperty);

    /// <summary>
    /// Allows binding to the ShrinkProperty as BindShrink for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<float> BindShrink(this FlexLayout _) => Bindings.BindableProperty<float>.Create(FlexLayout.ShrinkProperty);

    /// <summary>
    /// Allows binding to the WrapProperty as BindWrap for the FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexWrap> BindWrap(this FlexLayout _) => Bindings.BindableProperty<FlexWrap>.Create(FlexLayout.WrapProperty);

    // ***** Microsoft.Maui.Controls.Compatibility.FlexLayout Bindings *****

    /// <summary>
    /// Allows binding to the AlignContentProperty as BindAlignContent for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexAlignContent> BindAlignContent(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexAlignContent>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.AlignContentProperty);

    /// <summary>
    /// Allows binding to the AlignItemsProperty as BindAlignItems for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexAlignItems> BindAlignItems(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexAlignItems>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.AlignItemsProperty);

    /// <summary>
    /// Allows binding to the AlignSelfProperty as BindAlignSelf for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexAlignSelf> BindAlignSelf(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexAlignSelf>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.AlignSelfProperty);

    /// <summary>
    /// Allows binding to the BasisProperty as BindBasis for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexBasis> BindBasis(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexBasis>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.BasisProperty);

    /// <summary>
    /// Allows binding to the DirectionProperty as BindDirection for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexDirection> BindDirection(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexDirection>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.DirectionProperty);

    /// <summary>
    /// Allows binding to the GrowProperty as BindGrow for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<float> BindGrow(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<float>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.GrowProperty);

    /// <summary>
    /// Allows binding to the JustifyContentProperty as BindJustifyContent for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexJustify> BindJustifyContent(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexJustify>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.JustifyContentProperty);

    /// <summary>
    /// Allows binding to the OrderProperty as BindOrder for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<int> BindOrder(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<int>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.OrderProperty);

    /// <summary>
    /// Allows binding to the PositionProperty as BindPosition for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexPosition> BindPosition(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexPosition>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.PositionProperty);

    /// <summary>
    /// Allows binding to the ShrinkProperty as BindShrink for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<float> BindShrink(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<float>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.ShrinkProperty);

    /// <summary>
    /// Allows binding to the WrapProperty as BindWrap for the Microsoft.Maui.Controls.Compatibility.FlexLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.FlexLayout.</returns>
    public static Bindings.BindableProperty<FlexWrap> BindWrap(this Microsoft.Maui.Controls.Compatibility.FlexLayout _) => Bindings.BindableProperty<FlexWrap>.Create(Microsoft.Maui.Controls.Compatibility.FlexLayout.WrapProperty);

    // ***** FlyoutBase Bindings *****

    /// <summary>
    /// Allows binding to the ContextFlyoutProperty as BindContextFlyout for the FlyoutBase control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlyoutBase.</returns>
    public static Bindings.BindableProperty<FlyoutBase> BindContextFlyout(this FlyoutBase _) => Bindings.BindableProperty<FlyoutBase>.Create(FlyoutBase.ContextFlyoutProperty);

    // ***** FlyoutItem Bindings *****

    /// <summary>
    /// Allows binding to the IsVisibleProperty as BindIsVisible for the FlyoutItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlyoutItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsVisible(this FlyoutItem _) => Bindings.BindableProperty<bool>.Create(FlyoutItem.IsVisibleProperty);

    // ***** FlyoutPage Bindings *****

    /// <summary>
    /// Allows binding to the FlyoutLayoutBehaviorProperty as BindFlyoutLayoutBehavior for the FlyoutPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlyoutPage.</returns>
    public static Bindings.BindableProperty<FlyoutLayoutBehavior> BindFlyoutLayoutBehavior(this FlyoutPage _) => Bindings.BindableProperty<FlyoutLayoutBehavior>.Create(FlyoutPage.FlyoutLayoutBehaviorProperty);

    /// <summary>
    /// Allows binding to the IsGestureEnabledProperty as BindIsGestureEnabled for the FlyoutPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlyoutPage.</returns>
    public static Bindings.BindableProperty<bool> BindIsGestureEnabled(this FlyoutPage _) => Bindings.BindableProperty<bool>.Create(FlyoutPage.IsGestureEnabledProperty);

    /// <summary>
    /// Allows binding to the IsPresentedProperty as BindIsPresented for the FlyoutPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FlyoutPage.</returns>
    public static Bindings.BindableProperty<bool> BindIsPresented(this FlyoutPage _) => Bindings.BindableProperty<bool>.Create(FlyoutPage.IsPresentedProperty);

    // ***** FontImageSource Bindings *****

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the FontImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FontImageSource.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this FontImageSource _) => Bindings.BindableProperty<Color>.Create(FontImageSource.ColorProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the FontImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FontImageSource.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this FontImageSource _) => Bindings.BindableProperty<bool>.Create(FontImageSource.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the FontImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FontImageSource.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this FontImageSource _) => Bindings.BindableProperty<string>.Create(FontImageSource.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the GlyphProperty as BindGlyph for the FontImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FontImageSource.</returns>
    public static Bindings.BindableProperty<string> BindGlyph(this FontImageSource _) => Bindings.BindableProperty<string>.Create(FontImageSource.GlyphProperty);

    /// <summary>
    /// Allows binding to the SizeProperty as BindSize for the FontImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FontImageSource.</returns>
    public static Bindings.BindableProperty<double> BindSize(this FontImageSource _) => Bindings.BindableProperty<double>.Create(FontImageSource.SizeProperty);

    // ***** Frame Bindings *****

    /// <summary>
    /// Allows binding to the BorderColorProperty as BindBorderColor for the Frame control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Frame.</returns>
    public static Bindings.BindableProperty<Color> BindBorderColor(this Frame _) => Bindings.BindableProperty<Color>.Create(Frame.BorderColorProperty);

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the Frame control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Frame.</returns>
    public static Bindings.BindableProperty<float> BindCornerRadius(this Frame _) => Bindings.BindableProperty<float>.Create(Frame.CornerRadiusProperty);

    /// <summary>
    /// Allows binding to the HasShadowProperty as BindHasShadow for the Frame control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Frame.</returns>
    public static Bindings.BindableProperty<bool> BindHasShadow(this Frame _) => Bindings.BindableProperty<bool>.Create(Frame.HasShadowProperty);

    // ***** GeometryGroup Bindings *****

    /// <summary>
    /// Allows binding to the ChildrenProperty as BindChildren for the GeometryGroup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GeometryGroup.</returns>
    public static Bindings.BindableProperty<GeometryCollection> BindChildren(this GeometryGroup _) => Bindings.BindableProperty<GeometryCollection>.Create(GeometryGroup.ChildrenProperty);

    /// <summary>
    /// Allows binding to the FillRuleProperty as BindFillRule for the GeometryGroup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GeometryGroup.</returns>
    public static Bindings.BindableProperty<FillRule> BindFillRule(this GeometryGroup _) => Bindings.BindableProperty<FillRule>.Create(GeometryGroup.FillRuleProperty);

    // ***** GradientBrush Bindings *****

    /// <summary>
    /// Allows binding to the GradientStopsProperty as BindGradientStops for the GradientBrush control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GradientBrush.</returns>
    public static Bindings.BindableProperty<GradientStopCollection> BindGradientStops(this GradientBrush _) => Bindings.BindableProperty<GradientStopCollection>.Create(GradientBrush.GradientStopsProperty);

    // ***** GradientStop Bindings *****

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the GradientStop control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GradientStop.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this GradientStop _) => Bindings.BindableProperty<Color>.Create(GradientStop.ColorProperty);

    /// <summary>
    /// Allows binding to the OffsetProperty as BindOffset for the GradientStop control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GradientStop.</returns>
    public static Bindings.BindableProperty<float> BindOffset(this GradientStop _) => Bindings.BindableProperty<float>.Create(GradientStop.OffsetProperty);

    // ***** GraphicsView Bindings *****

    /// <summary>
    /// Allows binding to the DrawableProperty as BindDrawable for the GraphicsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GraphicsView.</returns>
    public static Bindings.BindableProperty<IDrawable> BindDrawable(this GraphicsView _) => Bindings.BindableProperty<IDrawable>.Create(GraphicsView.DrawableProperty);

    // ***** Grid Bindings *****

    /// <summary>
    /// Allows binding to the ColumnDefinitionsProperty as BindColumnDefinitions for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<ColumnDefinitionCollection> BindColumnDefinitions(this Grid _) => Bindings.BindableProperty<ColumnDefinitionCollection>.Create(Grid.ColumnDefinitionsProperty);

    /// <summary>
    /// Allows binding to the ColumnProperty as BindColumn for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<int> BindColumn(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.ColumnProperty);

    /// <summary>
    /// Allows binding to the ColumnSpacingProperty as BindColumnSpacing for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<double> BindColumnSpacing(this Grid _) => Bindings.BindableProperty<double>.Create(Grid.ColumnSpacingProperty);

    /// <summary>
    /// Allows binding to the ColumnSpanProperty as BindColumnSpan for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<int> BindColumnSpan(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.ColumnSpanProperty);

    /// <summary>
    /// Allows binding to the RowDefinitionsProperty as BindRowDefinitions for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<RowDefinitionCollection> BindRowDefinitions(this Grid _) => Bindings.BindableProperty<RowDefinitionCollection>.Create(Grid.RowDefinitionsProperty);

    /// <summary>
    /// Allows binding to the RowProperty as BindRow for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<int> BindRow(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.RowProperty);

    /// <summary>
    /// Allows binding to the RowSpacingProperty as BindRowSpacing for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<double> BindRowSpacing(this Grid _) => Bindings.BindableProperty<double>.Create(Grid.RowSpacingProperty);

    /// <summary>
    /// Allows binding to the RowSpanProperty as BindRowSpan for the Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Grid.</returns>
    public static Bindings.BindableProperty<int> BindRowSpan(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.RowSpanProperty);

    // ***** Microsoft.Maui.Controls.Compatibility.Grid Bindings *****

    /// <summary>
    /// Allows binding to the ColumnDefinitionsProperty as BindColumnDefinitions for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<ColumnDefinitionCollection> BindColumnDefinitions(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<ColumnDefinitionCollection>.Create(Microsoft.Maui.Controls.Compatibility.Grid.ColumnDefinitionsProperty);

    /// <summary>
    /// Allows binding to the ColumnProperty as BindColumn for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<int> BindColumn(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<int>.Create(Microsoft.Maui.Controls.Compatibility.Grid.ColumnProperty);

    /// <summary>
    /// Allows binding to the ColumnSpacingProperty as BindColumnSpacing for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<double> BindColumnSpacing(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<double>.Create(Microsoft.Maui.Controls.Compatibility.Grid.ColumnSpacingProperty);

    /// <summary>
    /// Allows binding to the ColumnSpanProperty as BindColumnSpan for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<int> BindColumnSpan(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<int>.Create(Microsoft.Maui.Controls.Compatibility.Grid.ColumnSpanProperty);

    /// <summary>
    /// Allows binding to the RowDefinitionsProperty as BindRowDefinitions for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<RowDefinitionCollection> BindRowDefinitions(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<RowDefinitionCollection>.Create(Microsoft.Maui.Controls.Compatibility.Grid.RowDefinitionsProperty);

    /// <summary>
    /// Allows binding to the RowProperty as BindRow for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<int> BindRow(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<int>.Create(Microsoft.Maui.Controls.Compatibility.Grid.RowProperty);

    /// <summary>
    /// Allows binding to the RowSpacingProperty as BindRowSpacing for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<double> BindRowSpacing(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<double>.Create(Microsoft.Maui.Controls.Compatibility.Grid.RowSpacingProperty);

    /// <summary>
    /// Allows binding to the RowSpanProperty as BindRowSpan for the Microsoft.Maui.Controls.Compatibility.Grid control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Grid.</returns>
    public static Bindings.BindableProperty<int> BindRowSpan(this Microsoft.Maui.Controls.Compatibility.Grid _) => Bindings.BindableProperty<int>.Create(Microsoft.Maui.Controls.Compatibility.Grid.RowSpanProperty);

    // ***** GridItemsLayout Bindings *****

    /// <summary>
    /// Allows binding to the HorizontalItemSpacingProperty as BindHorizontalItemSpacing for the GridItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GridItemsLayout.</returns>
    public static Bindings.BindableProperty<double> BindHorizontalItemSpacing(this GridItemsLayout _) => Bindings.BindableProperty<double>.Create(GridItemsLayout.HorizontalItemSpacingProperty);

    /// <summary>
    /// Allows binding to the SpanProperty as BindSpan for the GridItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GridItemsLayout.</returns>
    public static Bindings.BindableProperty<int> BindSpan(this GridItemsLayout _) => Bindings.BindableProperty<int>.Create(GridItemsLayout.SpanProperty);

    /// <summary>
    /// Allows binding to the VerticalItemSpacingProperty as BindVerticalItemSpacing for the GridItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GridItemsLayout.</returns>
    public static Bindings.BindableProperty<double> BindVerticalItemSpacing(this GridItemsLayout _) => Bindings.BindableProperty<double>.Create(GridItemsLayout.VerticalItemSpacingProperty);

    // ***** GroupableItemsView Bindings *****

    /// <summary>
    /// Allows binding to the GroupFooterTemplateProperty as BindGroupFooterTemplate for the GroupableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GroupableItemsView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindGroupFooterTemplate(this GroupableItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(GroupableItemsView.GroupFooterTemplateProperty);

    /// <summary>
    /// Allows binding to the GroupHeaderTemplateProperty as BindGroupHeaderTemplate for the GroupableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GroupableItemsView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindGroupHeaderTemplate(this GroupableItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(GroupableItemsView.GroupHeaderTemplateProperty);

    /// <summary>
    /// Allows binding to the IsGroupedProperty as BindIsGrouped for the GroupableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GroupableItemsView.</returns>
    public static Bindings.BindableProperty<bool> BindIsGrouped(this GroupableItemsView _) => Bindings.BindableProperty<bool>.Create(GroupableItemsView.IsGroupedProperty);

    // ***** HtmlWebViewSource Bindings *****

    /// <summary>
    /// Allows binding to the BaseUrlProperty as BindBaseUrl for the HtmlWebViewSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type HtmlWebViewSource.</returns>
    public static Bindings.BindableProperty<string> BindBaseUrl(this HtmlWebViewSource _) => Bindings.BindableProperty<string>.Create(HtmlWebViewSource.BaseUrlProperty);

    /// <summary>
    /// Allows binding to the HtmlProperty as BindHtml for the HtmlWebViewSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type HtmlWebViewSource.</returns>
    public static Bindings.BindableProperty<string> BindHtml(this HtmlWebViewSource _) => Bindings.BindableProperty<string>.Create(HtmlWebViewSource.HtmlProperty);

    // ***** Image Bindings *****

    /// <summary>
    /// Allows binding to the AspectProperty as BindAspect for the Image control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Image.</returns>
    public static Bindings.BindableProperty<Aspect> BindAspect(this Image _) => Bindings.BindableProperty<Aspect>.Create(Image.AspectProperty);

    /// <summary>
    /// Allows binding to the IsAnimationPlayingProperty as BindIsAnimationPlaying for the Image control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Image.</returns>
    public static Bindings.BindableProperty<bool> BindIsAnimationPlaying(this Image _) => Bindings.BindableProperty<bool>.Create(Image.IsAnimationPlayingProperty);

    /// <summary>
    /// Allows binding to the IsLoadingProperty as BindIsLoading for the Image control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Image.</returns>
    public static Bindings.BindableProperty<bool> BindIsLoading(this Image _) => Bindings.BindableProperty<bool>.Create(Image.IsLoadingProperty);

    /// <summary>
    /// Allows binding to the IsOpaqueProperty as BindIsOpaque for the Image control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Image.</returns>
    public static Bindings.BindableProperty<bool> BindIsOpaque(this Image _) => Bindings.BindableProperty<bool>.Create(Image.IsOpaqueProperty);

    /// <summary>
    /// Allows binding to the SourceProperty as BindSource for the Image control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Image.</returns>
    public static Bindings.BindableProperty<ImageSource> BindSource(this Image _) => Bindings.BindableProperty<ImageSource>.Create(Image.SourceProperty);

    // ***** ImageButton Bindings *****

    /// <summary>
    /// Allows binding to the AspectProperty as BindAspect for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<Aspect> BindAspect(this ImageButton _) => Bindings.BindableProperty<Aspect>.Create(ImageButton.AspectProperty);

    /// <summary>
    /// Allows binding to the BorderColorProperty as BindBorderColor for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<Color> BindBorderColor(this ImageButton _) => Bindings.BindableProperty<Color>.Create(ImageButton.BorderColorProperty);

    /// <summary>
    /// Allows binding to the BorderWidthProperty as BindBorderWidth for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<double> BindBorderWidth(this ImageButton _) => Bindings.BindableProperty<double>.Create(ImageButton.BorderWidthProperty);

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this ImageButton _) => Bindings.BindableProperty<object>.Create(ImageButton.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this ImageButton _) => Bindings.BindableProperty<ICommand>.Create(ImageButton.CommandProperty);

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<int> BindCornerRadius(this ImageButton _) => Bindings.BindableProperty<int>.Create(ImageButton.CornerRadiusProperty);

    /// <summary>
    /// Allows binding to the IsLoadingProperty as BindIsLoading for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<bool> BindIsLoading(this ImageButton _) => Bindings.BindableProperty<bool>.Create(ImageButton.IsLoadingProperty);

    /// <summary>
    /// Allows binding to the IsOpaqueProperty as BindIsOpaque for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<bool> BindIsOpaque(this ImageButton _) => Bindings.BindableProperty<bool>.Create(ImageButton.IsOpaqueProperty);

    /// <summary>
    /// Allows binding to the IsPressedProperty as BindIsPressed for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<bool> BindIsPressed(this ImageButton _) => Bindings.BindableProperty<bool>.Create(ImageButton.IsPressedProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this ImageButton _) => Bindings.BindableProperty<Thickness>.Create(ImageButton.PaddingProperty);

    /// <summary>
    /// Allows binding to the SourceProperty as BindSource for the ImageButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageButton.</returns>
    public static Bindings.BindableProperty<ImageSource> BindSource(this ImageButton _) => Bindings.BindableProperty<ImageSource>.Create(ImageButton.SourceProperty);

    // ***** ImageCell Bindings *****

    /// <summary>
    /// Allows binding to the ImageSourceProperty as BindImageSource for the ImageCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ImageCell.</returns>
    public static Bindings.BindableProperty<ImageSource> BindImageSource(this ImageCell _) => Bindings.BindableProperty<ImageSource>.Create(ImageCell.ImageSourceProperty);

    // ***** IndicatorView Bindings *****

    /// <summary>
    /// Allows binding to the CountProperty as BindCount for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<int> BindCount(this IndicatorView _) => Bindings.BindableProperty<int>.Create(IndicatorView.CountProperty);

    /// <summary>
    /// Allows binding to the HideSingleProperty as BindHideSingle for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<bool> BindHideSingle(this IndicatorView _) => Bindings.BindableProperty<bool>.Create(IndicatorView.HideSingleProperty);

    /// <summary>
    /// Allows binding to the IndicatorColorProperty as BindIndicatorColor for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<Color> BindIndicatorColor(this IndicatorView _) => Bindings.BindableProperty<Color>.Create(IndicatorView.IndicatorColorProperty);

    /// <summary>
    /// Allows binding to the IndicatorSizeProperty as BindIndicatorSize for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<double> BindIndicatorSize(this IndicatorView _) => Bindings.BindableProperty<double>.Create(IndicatorView.IndicatorSizeProperty);

    /// <summary>
    /// Allows binding to the IndicatorsShapeProperty as BindIndicatorsShape for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<IndicatorShape> BindIndicatorsShape(this IndicatorView _) => Bindings.BindableProperty<IndicatorShape>.Create(IndicatorView.IndicatorsShapeProperty);

    /// <summary>
    /// Allows binding to the IndicatorTemplateProperty as BindIndicatorTemplate for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindIndicatorTemplate(this IndicatorView _) => Bindings.BindableProperty<DataTemplate>.Create(IndicatorView.IndicatorTemplateProperty);

    /// <summary>
    /// Allows binding to the ItemsSourceProperty as BindItemsSource for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<IEnumerable> BindItemsSource(this IndicatorView _) => Bindings.BindableProperty<IEnumerable>.Create(IndicatorView.ItemsSourceProperty);

    /// <summary>
    /// Allows binding to the MaximumVisibleProperty as BindMaximumVisible for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<int> BindMaximumVisible(this IndicatorView _) => Bindings.BindableProperty<int>.Create(IndicatorView.MaximumVisibleProperty);

    /// <summary>
    /// Allows binding to the PositionProperty as BindPosition for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<int> BindPosition(this IndicatorView _) => Bindings.BindableProperty<int>.Create(IndicatorView.PositionProperty);

    /// <summary>
    /// Allows binding to the SelectedIndicatorColorProperty as BindSelectedIndicatorColor for the IndicatorView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IndicatorView.</returns>
    public static Bindings.BindableProperty<Color> BindSelectedIndicatorColor(this IndicatorView _) => Bindings.BindableProperty<Color>.Create(IndicatorView.SelectedIndicatorColorProperty);

    // ***** InputView Bindings *****

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this InputView _) => Bindings.BindableProperty<double>.Create(InputView.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the IsReadOnlyProperty as BindIsReadOnly for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<bool> BindIsReadOnly(this InputView _) => Bindings.BindableProperty<bool>.Create(InputView.IsReadOnlyProperty);

    /// <summary>
    /// Allows binding to the IsSpellCheckEnabledProperty as BindIsSpellCheckEnabled for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<bool> BindIsSpellCheckEnabled(this InputView _) => Bindings.BindableProperty<bool>.Create(InputView.IsSpellCheckEnabledProperty);

    /// <summary>
    /// Allows binding to the KeyboardProperty as BindKeyboard for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this InputView _) => Bindings.BindableProperty<Keyboard>.Create(InputView.KeyboardProperty);

    /// <summary>
    /// Allows binding to the MaxLengthProperty as BindMaxLength for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<int> BindMaxLength(this InputView _) => Bindings.BindableProperty<int>.Create(InputView.MaxLengthProperty);

    /// <summary>
    /// Allows binding to the PlaceholderColorProperty as BindPlaceholderColor for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this InputView _) => Bindings.BindableProperty<Color>.Create(InputView.PlaceholderColorProperty);

    /// <summary>
    /// Allows binding to the PlaceholderProperty as BindPlaceholder for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<string> BindPlaceholder(this InputView _) => Bindings.BindableProperty<string>.Create(InputView.PlaceholderProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this InputView _) => Bindings.BindableProperty<Color>.Create(InputView.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<string> BindText(this InputView _) => Bindings.BindableProperty<string>.Create(InputView.TextProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the InputView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type InputView.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this InputView _) => Bindings.BindableProperty<TextTransform>.Create(InputView.TextTransformProperty);

    // ***** ItemsLayout Bindings *****

    /// <summary>
    /// Allows binding to the SnapPointsAlignmentProperty as BindSnapPointsAlignment for the ItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsLayout.</returns>
    public static Bindings.BindableProperty<SnapPointsAlignment> BindSnapPointsAlignment(this ItemsLayout _) => Bindings.BindableProperty<SnapPointsAlignment>.Create(ItemsLayout.SnapPointsAlignmentProperty);

    /// <summary>
    /// Allows binding to the SnapPointsTypeProperty as BindSnapPointsType for the ItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsLayout.</returns>
    public static Bindings.BindableProperty<SnapPointsType> BindSnapPointsType(this ItemsLayout _) => Bindings.BindableProperty<SnapPointsType>.Create(ItemsLayout.SnapPointsTypeProperty);

    // ***** ItemsView Bindings *****

    /// <summary>
    /// Allows binding to the EmptyViewProperty as BindEmptyView for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<object> BindEmptyView(this ItemsView _) => Bindings.BindableProperty<object>.Create(ItemsView.EmptyViewProperty);

    /// <summary>
    /// Allows binding to the EmptyViewTemplateProperty as BindEmptyViewTemplate for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindEmptyViewTemplate(this ItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(ItemsView.EmptyViewTemplateProperty);

    /// <summary>
    /// Allows binding to the HorizontalScrollBarVisibilityProperty as BindHorizontalScrollBarVisibility for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<ScrollBarVisibility> BindHorizontalScrollBarVisibility(this ItemsView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ItemsView.HorizontalScrollBarVisibilityProperty);

    /// <summary>
    /// Allows binding to the ItemsSourceProperty as BindItemsSource for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<IEnumerable> BindItemsSource(this ItemsView _) => Bindings.BindableProperty<IEnumerable>.Create(ItemsView.ItemsSourceProperty);

    /// <summary>
    /// Allows binding to the ItemsUpdatingScrollModeProperty as BindItemsUpdatingScrollMode for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<ItemsUpdatingScrollMode> BindItemsUpdatingScrollMode(this ItemsView _) => Bindings.BindableProperty<ItemsUpdatingScrollMode>.Create(ItemsView.ItemsUpdatingScrollModeProperty);

    /// <summary>
    /// Allows binding to the ItemTemplateProperty as BindItemTemplate for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindItemTemplate(this ItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(ItemsView.ItemTemplateProperty);

    /// <summary>
    /// Allows binding to the RemainingItemsThresholdProperty as BindRemainingItemsThreshold for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<int> BindRemainingItemsThreshold(this ItemsView _) => Bindings.BindableProperty<int>.Create(ItemsView.RemainingItemsThresholdProperty);

    /// <summary>
    /// Allows binding to the RemainingItemsThresholdReachedCommandParameterProperty as BindRemainingItemsThresholdReachedCommandParameter for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<object> BindRemainingItemsThresholdReachedCommandParameter(this ItemsView _) => Bindings.BindableProperty<object>.Create(ItemsView.RemainingItemsThresholdReachedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the RemainingItemsThresholdReachedCommandProperty as BindRemainingItemsThresholdReachedCommand for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<ICommand> BindRemainingItemsThresholdReachedCommand(this ItemsView _) => Bindings.BindableProperty<ICommand>.Create(ItemsView.RemainingItemsThresholdReachedCommandProperty);

    /// <summary>
    /// Allows binding to the VerticalScrollBarVisibilityProperty as BindVerticalScrollBarVisibility for the ItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ItemsView.</returns>
    public static Bindings.BindableProperty<ScrollBarVisibility> BindVerticalScrollBarVisibility(this ItemsView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ItemsView.VerticalScrollBarVisibilityProperty);

    // ***** Label Bindings *****

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Label _) => Bindings.BindableProperty<double>.Create(Label.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Label _) => Bindings.BindableProperty<FontAttributes>.Create(Label.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Label _) => Bindings.BindableProperty<bool>.Create(Label.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this Label _) => Bindings.BindableProperty<string>.Create(Label.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this Label _) => Bindings.BindableProperty<double>.Create(Label.FontSizeProperty);

    /// <summary>
    /// Allows binding to the FormattedTextProperty as BindFormattedText for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<FormattedString> BindFormattedText(this Label _) => Bindings.BindableProperty<FormattedString>.Create(Label.FormattedTextProperty);

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Label _) => Bindings.BindableProperty<TextAlignment>.Create(Label.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the LineBreakModeProperty as BindLineBreakMode for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<LineBreakMode> BindLineBreakMode(this Label _) => Bindings.BindableProperty<LineBreakMode>.Create(Label.LineBreakModeProperty);

    /// <summary>
    /// Allows binding to the LineHeightProperty as BindLineHeight for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<double> BindLineHeight(this Label _) => Bindings.BindableProperty<double>.Create(Label.LineHeightProperty);

    /// <summary>
    /// Allows binding to the MaxLinesProperty as BindMaxLines for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<int> BindMaxLines(this Label _) => Bindings.BindableProperty<int>.Create(Label.MaxLinesProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this Label _) => Bindings.BindableProperty<Thickness>.Create(Label.PaddingProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this Label _) => Bindings.BindableProperty<Color>.Create(Label.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextDecorationsProperty as BindTextDecorations for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<TextDecorations> BindTextDecorations(this Label _) => Bindings.BindableProperty<TextDecorations>.Create(Label.TextDecorationsProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<string> BindText(this Label _) => Bindings.BindableProperty<string>.Create(Label.TextProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this Label _) => Bindings.BindableProperty<TextTransform>.Create(Label.TextTransformProperty);

    /// <summary>
    /// Allows binding to the TextTypeProperty as BindTextType for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<TextType> BindTextType(this Label _) => Bindings.BindableProperty<TextType>.Create(Label.TextTypeProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the Label control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Label.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Label _) => Bindings.BindableProperty<TextAlignment>.Create(Label.VerticalTextAlignmentProperty);

    // ***** Layout Bindings *****

    /// <summary>
    /// Allows binding to the CascadeInputTransparentProperty as BindCascadeInputTransparent for the Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Layout.</returns>
    public static Bindings.BindableProperty<bool> BindCascadeInputTransparent(this Layout _) => Bindings.BindableProperty<bool>.Create(Layout.CascadeInputTransparentProperty);

    /// <summary>
    /// Allows binding to the IsClippedToBoundsProperty as BindIsClippedToBounds for the Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Layout.</returns>
    public static Bindings.BindableProperty<bool> BindIsClippedToBounds(this Layout _) => Bindings.BindableProperty<bool>.Create(Layout.IsClippedToBoundsProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Layout.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this Layout _) => Bindings.BindableProperty<Thickness>.Create(Layout.PaddingProperty);

    // ***** Microsoft.Maui.Controls.Compatibility.Layout Bindings *****

    /// <summary>
    /// Allows binding to the CascadeInputTransparentProperty as BindCascadeInputTransparent for the Microsoft.Maui.Controls.Compatibility.Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Layout.</returns>
    public static Bindings.BindableProperty<bool> BindCascadeInputTransparent(this Microsoft.Maui.Controls.Compatibility.Layout _) => Bindings.BindableProperty<bool>.Create(Microsoft.Maui.Controls.Compatibility.Layout.CascadeInputTransparentProperty);

    /// <summary>
    /// Allows binding to the IsClippedToBoundsProperty as BindIsClippedToBounds for the Microsoft.Maui.Controls.Compatibility.Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Layout.</returns>
    public static Bindings.BindableProperty<bool> BindIsClippedToBounds(this Microsoft.Maui.Controls.Compatibility.Layout _) => Bindings.BindableProperty<bool>.Create(Microsoft.Maui.Controls.Compatibility.Layout.IsClippedToBoundsProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the Microsoft.Maui.Controls.Compatibility.Layout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.Layout.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this Microsoft.Maui.Controls.Compatibility.Layout _) => Bindings.BindableProperty<Thickness>.Create(Microsoft.Maui.Controls.Compatibility.Layout.PaddingProperty);

    // ***** Line Bindings *****

    /// <summary>
    /// Allows binding to the X1Property as BindX1 for the Line control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Line.</returns>
    public static Bindings.BindableProperty<double> BindX1(this Line _) => Bindings.BindableProperty<double>.Create(Line.X1Property);

    /// <summary>
    /// Allows binding to the X2Property as BindX2 for the Line control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Line.</returns>
    public static Bindings.BindableProperty<double> BindX2(this Line _) => Bindings.BindableProperty<double>.Create(Line.X2Property);

    /// <summary>
    /// Allows binding to the Y1Property as BindY1 for the Line control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Line.</returns>
    public static Bindings.BindableProperty<double> BindY1(this Line _) => Bindings.BindableProperty<double>.Create(Line.Y1Property);

    /// <summary>
    /// Allows binding to the Y2Property as BindY2 for the Line control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Line.</returns>
    public static Bindings.BindableProperty<double> BindY2(this Line _) => Bindings.BindableProperty<double>.Create(Line.Y2Property);

    // ***** LinearGradientBrush Bindings *****

    /// <summary>
    /// Allows binding to the EndPointProperty as BindEndPoint for the LinearGradientBrush control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LinearGradientBrush.</returns>
    public static Bindings.BindableProperty<Point> BindEndPoint(this LinearGradientBrush _) => Bindings.BindableProperty<Point>.Create(LinearGradientBrush.EndPointProperty);

    /// <summary>
    /// Allows binding to the StartPointProperty as BindStartPoint for the LinearGradientBrush control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LinearGradientBrush.</returns>
    public static Bindings.BindableProperty<Point> BindStartPoint(this LinearGradientBrush _) => Bindings.BindableProperty<Point>.Create(LinearGradientBrush.StartPointProperty);

    // ***** LinearItemsLayout Bindings *****

    /// <summary>
    /// Allows binding to the ItemSpacingProperty as BindItemSpacing for the LinearItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LinearItemsLayout.</returns>
    public static Bindings.BindableProperty<double> BindItemSpacing(this LinearItemsLayout _) => Bindings.BindableProperty<double>.Create(LinearItemsLayout.ItemSpacingProperty);

    // ***** LineGeometry Bindings *****

    /// <summary>
    /// Allows binding to the EndPointProperty as BindEndPoint for the LineGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LineGeometry.</returns>
    public static Bindings.BindableProperty<Point> BindEndPoint(this LineGeometry _) => Bindings.BindableProperty<Point>.Create(LineGeometry.EndPointProperty);

    /// <summary>
    /// Allows binding to the StartPointProperty as BindStartPoint for the LineGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LineGeometry.</returns>
    public static Bindings.BindableProperty<Point> BindStartPoint(this LineGeometry _) => Bindings.BindableProperty<Point>.Create(LineGeometry.StartPointProperty);

    // ***** LineSegment Bindings *****

    /// <summary>
    /// Allows binding to the PointProperty as BindPoint for the LineSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LineSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint(this LineSegment _) => Bindings.BindableProperty<Point>.Create(LineSegment.PointProperty);

    // ***** ListView Bindings *****

    /// <summary>
    /// Allows binding to the FooterProperty as BindFooter for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<object> BindFooter(this ListView _) => Bindings.BindableProperty<object>.Create(ListView.FooterProperty);

    /// <summary>
    /// Allows binding to the FooterTemplateProperty as BindFooterTemplate for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindFooterTemplate(this ListView _) => Bindings.BindableProperty<DataTemplate>.Create(ListView.FooterTemplateProperty);

    /// <summary>
    /// Allows binding to the GroupHeaderTemplateProperty as BindGroupHeaderTemplate for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindGroupHeaderTemplate(this ListView _) => Bindings.BindableProperty<DataTemplate>.Create(ListView.GroupHeaderTemplateProperty);

    /// <summary>
    /// Allows binding to the HasUnevenRowsProperty as BindHasUnevenRows for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<bool> BindHasUnevenRows(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.HasUnevenRowsProperty);

    /// <summary>
    /// Allows binding to the HeaderProperty as BindHeader for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<object> BindHeader(this ListView _) => Bindings.BindableProperty<object>.Create(ListView.HeaderProperty);

    /// <summary>
    /// Allows binding to the HeaderTemplateProperty as BindHeaderTemplate for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindHeaderTemplate(this ListView _) => Bindings.BindableProperty<DataTemplate>.Create(ListView.HeaderTemplateProperty);

    /// <summary>
    /// Allows binding to the HorizontalScrollBarVisibilityProperty as BindHorizontalScrollBarVisibility for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<ScrollBarVisibility> BindHorizontalScrollBarVisibility(this ListView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ListView.HorizontalScrollBarVisibilityProperty);

    /// <summary>
    /// Allows binding to the IsGroupingEnabledProperty as BindIsGroupingEnabled for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<bool> BindIsGroupingEnabled(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.IsGroupingEnabledProperty);

    /// <summary>
    /// Allows binding to the IsPullToRefreshEnabledProperty as BindIsPullToRefreshEnabled for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<bool> BindIsPullToRefreshEnabled(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.IsPullToRefreshEnabledProperty);

    /// <summary>
    /// Allows binding to the IsRefreshingProperty as BindIsRefreshing for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<bool> BindIsRefreshing(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.IsRefreshingProperty);

    /// <summary>
    /// Allows binding to the RefreshCommandProperty as BindRefreshCommand for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<ICommand> BindRefreshCommand(this ListView _) => Bindings.BindableProperty<ICommand>.Create(ListView.RefreshCommandProperty);

    /// <summary>
    /// Allows binding to the RefreshControlColorProperty as BindRefreshControlColor for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<Color> BindRefreshControlColor(this ListView _) => Bindings.BindableProperty<Color>.Create(ListView.RefreshControlColorProperty);

    /// <summary>
    /// Allows binding to the RowHeightProperty as BindRowHeight for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<int> BindRowHeight(this ListView _) => Bindings.BindableProperty<int>.Create(ListView.RowHeightProperty);

    /// <summary>
    /// Allows binding to the SelectedItemProperty as BindSelectedItem for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<object> BindSelectedItem(this ListView _) => Bindings.BindableProperty<object>.Create(ListView.SelectedItemProperty);

    /// <summary>
    /// Allows binding to the SelectionModeProperty as BindSelectionMode for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<ListViewSelectionMode> BindSelectionMode(this ListView _) => Bindings.BindableProperty<ListViewSelectionMode>.Create(ListView.SelectionModeProperty);

    /// <summary>
    /// Allows binding to the SeparatorColorProperty as BindSeparatorColor for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<Color> BindSeparatorColor(this ListView _) => Bindings.BindableProperty<Color>.Create(ListView.SeparatorColorProperty);

    /// <summary>
    /// Allows binding to the SeparatorVisibilityProperty as BindSeparatorVisibility for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<SeparatorVisibility> BindSeparatorVisibility(this ListView _) => Bindings.BindableProperty<SeparatorVisibility>.Create(ListView.SeparatorVisibilityProperty);

    /// <summary>
    /// Allows binding to the VerticalScrollBarVisibilityProperty as BindVerticalScrollBarVisibility for the ListView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ListView.</returns>
    public static Bindings.BindableProperty<ScrollBarVisibility> BindVerticalScrollBarVisibility(this ListView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ListView.VerticalScrollBarVisibilityProperty);

    // ***** MatrixTransform Bindings *****

    /// <summary>
    /// Allows binding to the MatrixProperty as BindMatrix for the MatrixTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MatrixTransform.</returns>
    public static Bindings.BindableProperty<Matrix> BindMatrix(this MatrixTransform _) => Bindings.BindableProperty<Matrix>.Create(MatrixTransform.MatrixProperty);

    // ***** MenuBar Bindings *****

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the MenuBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuBar.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this MenuBar _) => Bindings.BindableProperty<bool>.Create(MenuBar.IsEnabledProperty);

    // ***** MenuBarItem Bindings *****

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the MenuBarItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuBarItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this MenuBarItem _) => Bindings.BindableProperty<bool>.Create(MenuBarItem.IsEnabledProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the MenuBarItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuBarItem.</returns>
    public static Bindings.BindableProperty<string> BindText(this MenuBarItem _) => Bindings.BindableProperty<string>.Create(MenuBarItem.TextProperty);

    // ***** MenuItem Bindings *****

    /// <summary>
    /// Allows binding to the AcceleratorProperty as BindAccelerator for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<Accelerator> BindAccelerator(this MenuItem _) => Bindings.BindableProperty<Accelerator>.Create(MenuItem.AcceleratorProperty);

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this MenuItem _) => Bindings.BindableProperty<object>.Create(MenuItem.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this MenuItem _) => Bindings.BindableProperty<ICommand>.Create(MenuItem.CommandProperty);

    /// <summary>
    /// Allows binding to the IconImageSourceProperty as BindIconImageSource for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<ImageSource> BindIconImageSource(this MenuItem _) => Bindings.BindableProperty<ImageSource>.Create(MenuItem.IconImageSourceProperty);

    /// <summary>
    /// Allows binding to the IsDestructiveProperty as BindIsDestructive for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsDestructive(this MenuItem _) => Bindings.BindableProperty<bool>.Create(MenuItem.IsDestructiveProperty);

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this MenuItem _) => Bindings.BindableProperty<bool>.Create(MenuItem.IsEnabledProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the MenuItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MenuItem.</returns>
    public static Bindings.BindableProperty<string> BindText(this MenuItem _) => Bindings.BindableProperty<string>.Create(MenuItem.TextProperty);

    // ***** NavigableElement Bindings *****

    /// <summary>
    /// Allows binding to the NavigationProperty as BindNavigation for the NavigableElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigableElement.</returns>
    public static Bindings.BindableProperty<INavigation> BindNavigation(this NavigableElement _) => Bindings.BindableProperty<INavigation>.Create(NavigableElement.NavigationProperty);

    /// <summary>
    /// Allows binding to the StyleProperty as BindStyle for the NavigableElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigableElement.</returns>
    public static Bindings.BindableProperty<Style> BindStyle(this NavigableElement _) => Bindings.BindableProperty<Style>.Create(NavigableElement.StyleProperty);

    // ***** NavigationPage Bindings *****

    /// <summary>
    /// Allows binding to the BackButtonTitleProperty as BindBackButtonTitle for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<string> BindBackButtonTitle(this NavigationPage _) => Bindings.BindableProperty<string>.Create(NavigationPage.BackButtonTitleProperty);

    /// <summary>
    /// Allows binding to the BarBackgroundColorProperty as BindBarBackgroundColor for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<Color> BindBarBackgroundColor(this NavigationPage _) => Bindings.BindableProperty<Color>.Create(NavigationPage.BarBackgroundColorProperty);

    /// <summary>
    /// Allows binding to the BarBackgroundProperty as BindBarBackground for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<Brush> BindBarBackground(this NavigationPage _) => Bindings.BindableProperty<Brush>.Create(NavigationPage.BarBackgroundProperty);

    /// <summary>
    /// Allows binding to the BarTextColorProperty as BindBarTextColor for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<Color> BindBarTextColor(this NavigationPage _) => Bindings.BindableProperty<Color>.Create(NavigationPage.BarTextColorProperty);

    /// <summary>
    /// Allows binding to the CurrentPageProperty as BindCurrentPage for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<Page> BindCurrentPage(this NavigationPage _) => Bindings.BindableProperty<Page>.Create(NavigationPage.CurrentPageProperty);

    /// <summary>
    /// Allows binding to the HasBackButtonProperty as BindHasBackButton for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<bool> BindHasBackButton(this NavigationPage _) => Bindings.BindableProperty<bool>.Create(NavigationPage.HasBackButtonProperty);

    /// <summary>
    /// Allows binding to the HasNavigationBarProperty as BindHasNavigationBar for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<bool> BindHasNavigationBar(this NavigationPage _) => Bindings.BindableProperty<bool>.Create(NavigationPage.HasNavigationBarProperty);

    /// <summary>
    /// Allows binding to the IconColorProperty as BindIconColor for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<Color> BindIconColor(this NavigationPage _) => Bindings.BindableProperty<Color>.Create(NavigationPage.IconColorProperty);

    /// <summary>
    /// Allows binding to the RootPageProperty as BindRootPage for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<Page> BindRootPage(this NavigationPage _) => Bindings.BindableProperty<Page>.Create(NavigationPage.RootPageProperty);

    /// <summary>
    /// Allows binding to the TitleIconImageSourceProperty as BindTitleIconImageSource for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<ImageSource> BindTitleIconImageSource(this NavigationPage _) => Bindings.BindableProperty<ImageSource>.Create(NavigationPage.TitleIconImageSourceProperty);

    /// <summary>
    /// Allows binding to the TitleViewProperty as BindTitleView for the NavigationPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NavigationPage.</returns>
    public static Bindings.BindableProperty<View> BindTitleView(this NavigationPage _) => Bindings.BindableProperty<View>.Create(NavigationPage.TitleViewProperty);

    // ***** OpenGLView Bindings *****

    /// <summary>
    /// Allows binding to the HasRenderLoopProperty as BindHasRenderLoop for the OpenGLView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type OpenGLView.</returns>
    [Obsolete("OpenGLView is obsolete as of .NET 7. To enable this view you will need to call `builder.UseMauiCompatibility` but it is currently untested and unsupported.")]
    public static Bindings.BindableProperty<bool> BindHasRenderLoop(this OpenGLView _) => Bindings.BindableProperty<bool>.Create(OpenGLView.HasRenderLoopProperty);

    // ***** OrientationStateTrigger Bindings *****

    /// <summary>
    /// Allows binding to the OrientationProperty as BindOrientation for the OrientationStateTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type OrientationStateTrigger.</returns>
    public static Bindings.BindableProperty<DisplayOrientation> BindOrientation(this OrientationStateTrigger _) => Bindings.BindableProperty<DisplayOrientation>.Create(OrientationStateTrigger.OrientationProperty);

    // ***** Page Bindings *****

    /// <summary>
    /// Allows binding to the BackgroundImageSourceProperty as BindBackgroundImageSource for the Page control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Page.</returns>
    public static Bindings.BindableProperty<ImageSource> BindBackgroundImageSource(this Page _) => Bindings.BindableProperty<ImageSource>.Create(Page.BackgroundImageSourceProperty);

    /// <summary>
    /// Allows binding to the IconImageSourceProperty as BindIconImageSource for the Page control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Page.</returns>
    public static Bindings.BindableProperty<ImageSource> BindIconImageSource(this Page _) => Bindings.BindableProperty<ImageSource>.Create(Page.IconImageSourceProperty);

    /// <summary>
    /// Allows binding to the IsBusyProperty as BindIsBusy for the Page control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Page.</returns>
    public static Bindings.BindableProperty<bool> BindIsBusy(this Page _) => Bindings.BindableProperty<bool>.Create(Page.IsBusyProperty);

    /// <summary>
    /// Allows binding to the PaddingProperty as BindPadding for the Page control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Page.</returns>
    public static Bindings.BindableProperty<Thickness> BindPadding(this Page _) => Bindings.BindableProperty<Thickness>.Create(Page.PaddingProperty);

    /// <summary>
    /// Allows binding to the TitleProperty as BindTitle for the Page control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Page.</returns>
    public static Bindings.BindableProperty<string> BindTitle(this Page _) => Bindings.BindableProperty<string>.Create(Page.TitleProperty);

    // ***** PanGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the TouchPointsProperty as BindTouchPoints for the PanGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PanGestureRecognizer.</returns>
    public static Bindings.BindableProperty<int> BindTouchPoints(this PanGestureRecognizer _) => Bindings.BindableProperty<int>.Create(PanGestureRecognizer.TouchPointsProperty);

    // ***** Path Bindings *****

    /// <summary>
    /// Allows binding to the DataProperty as BindData for the Path control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Path.</returns>
    public static Bindings.BindableProperty<Geometry> BindData(this Path _) => Bindings.BindableProperty<Geometry>.Create(Path.DataProperty);

    /// <summary>
    /// Allows binding to the RenderTransformProperty as BindRenderTransform for the Path control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Path.</returns>
    public static Bindings.BindableProperty<Transform> BindRenderTransform(this Path _) => Bindings.BindableProperty<Transform>.Create(Path.RenderTransformProperty);

    // ***** PathFigure Bindings *****

    /// <summary>
    /// Allows binding to the IsClosedProperty as BindIsClosed for the PathFigure control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PathFigure.</returns>
    public static Bindings.BindableProperty<bool> BindIsClosed(this PathFigure _) => Bindings.BindableProperty<bool>.Create(PathFigure.IsClosedProperty);

    /// <summary>
    /// Allows binding to the IsFilledProperty as BindIsFilled for the PathFigure control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PathFigure.</returns>
    public static Bindings.BindableProperty<bool> BindIsFilled(this PathFigure _) => Bindings.BindableProperty<bool>.Create(PathFigure.IsFilledProperty);

    /// <summary>
    /// Allows binding to the SegmentsProperty as BindSegments for the PathFigure control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PathFigure.</returns>
    public static Bindings.BindableProperty<PathSegmentCollection> BindSegments(this PathFigure _) => Bindings.BindableProperty<PathSegmentCollection>.Create(PathFigure.SegmentsProperty);

    /// <summary>
    /// Allows binding to the StartPointProperty as BindStartPoint for the PathFigure control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PathFigure.</returns>
    public static Bindings.BindableProperty<Point> BindStartPoint(this PathFigure _) => Bindings.BindableProperty<Point>.Create(PathFigure.StartPointProperty);

    // ***** PathGeometry Bindings *****

    /// <summary>
    /// Allows binding to the FiguresProperty as BindFigures for the PathGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PathGeometry.</returns>
    public static Bindings.BindableProperty<PathFigureCollection> BindFigures(this PathGeometry _) => Bindings.BindableProperty<PathFigureCollection>.Create(PathGeometry.FiguresProperty);

    /// <summary>
    /// Allows binding to the FillRuleProperty as BindFillRule for the PathGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PathGeometry.</returns>
    public static Bindings.BindableProperty<FillRule> BindFillRule(this PathGeometry _) => Bindings.BindableProperty<FillRule>.Create(PathGeometry.FillRuleProperty);

    // ***** Picker Bindings *****

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Picker _) => Bindings.BindableProperty<double>.Create(Picker.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Picker _) => Bindings.BindableProperty<FontAttributes>.Create(Picker.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Picker _) => Bindings.BindableProperty<bool>.Create(Picker.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this Picker _) => Bindings.BindableProperty<string>.Create(Picker.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this Picker _) => Bindings.BindableProperty<double>.Create(Picker.FontSizeProperty);

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Picker _) => Bindings.BindableProperty<TextAlignment>.Create(Picker.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the ItemsSourceProperty as BindItemsSource for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<IList> BindItemsSource(this Picker _) => Bindings.BindableProperty<IList>.Create(Picker.ItemsSourceProperty);

    /// <summary>
    /// Allows binding to the SelectedIndexProperty as BindSelectedIndex for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<int> BindSelectedIndex(this Picker _) => Bindings.BindableProperty<int>.Create(Picker.SelectedIndexProperty);

    /// <summary>
    /// Allows binding to the SelectedItemProperty as BindSelectedItem for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<object> BindSelectedItem(this Picker _) => Bindings.BindableProperty<object>.Create(Picker.SelectedItemProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this Picker _) => Bindings.BindableProperty<Color>.Create(Picker.TextColorProperty);

    /// <summary>
    /// Allows binding to the TitleColorProperty as BindTitleColor for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<Color> BindTitleColor(this Picker _) => Bindings.BindableProperty<Color>.Create(Picker.TitleColorProperty);

    /// <summary>
    /// Allows binding to the TitleProperty as BindTitle for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<string> BindTitle(this Picker _) => Bindings.BindableProperty<string>.Create(Picker.TitleProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the Picker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Picker.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Picker _) => Bindings.BindableProperty<TextAlignment>.Create(Picker.VerticalTextAlignmentProperty);

    // ***** PointerGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the PointerEnteredCommandParameterProperty as BindPointerEnteredCommandParameter for the PointerGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PointerGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindPointerEnteredCommandParameter(this PointerGestureRecognizer _) => Bindings.BindableProperty<object>.Create(PointerGestureRecognizer.PointerEnteredCommandParameterProperty);

    /// <summary>
    /// Allows binding to the PointerEnteredCommandProperty as BindPointerEnteredCommand for the PointerGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PointerGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindPointerEnteredCommand(this PointerGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(PointerGestureRecognizer.PointerEnteredCommandProperty);

    /// <summary>
    /// Allows binding to the PointerExitedCommandParameterProperty as BindPointerExitedCommandParameter for the PointerGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PointerGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindPointerExitedCommandParameter(this PointerGestureRecognizer _) => Bindings.BindableProperty<object>.Create(PointerGestureRecognizer.PointerExitedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the PointerExitedCommandProperty as BindPointerExitedCommand for the PointerGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PointerGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindPointerExitedCommand(this PointerGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(PointerGestureRecognizer.PointerExitedCommandProperty);

    /// <summary>
    /// Allows binding to the PointerMovedCommandParameterProperty as BindPointerMovedCommandParameter for the PointerGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PointerGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindPointerMovedCommandParameter(this PointerGestureRecognizer _) => Bindings.BindableProperty<object>.Create(PointerGestureRecognizer.PointerMovedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the PointerMovedCommandProperty as BindPointerMovedCommand for the PointerGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PointerGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindPointerMovedCommand(this PointerGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(PointerGestureRecognizer.PointerMovedCommandProperty);

    // ***** PolyBezierSegment Bindings *****

    /// <summary>
    /// Allows binding to the PointsProperty as BindPoints for the PolyBezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PolyBezierSegment.</returns>
    public static Bindings.BindableProperty<PointCollection> BindPoints(this PolyBezierSegment _) => Bindings.BindableProperty<PointCollection>.Create(PolyBezierSegment.PointsProperty);

    // ***** Polygon Bindings *****

    /// <summary>
    /// Allows binding to the FillRuleProperty as BindFillRule for the Polygon control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Polygon.</returns>
    public static Bindings.BindableProperty<FillRule> BindFillRule(this Polygon _) => Bindings.BindableProperty<FillRule>.Create(Polygon.FillRuleProperty);

    /// <summary>
    /// Allows binding to the PointsProperty as BindPoints for the Polygon control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Polygon.</returns>
    public static Bindings.BindableProperty<PointCollection> BindPoints(this Polygon _) => Bindings.BindableProperty<PointCollection>.Create(Polygon.PointsProperty);

    // ***** Polyline Bindings *****

    /// <summary>
    /// Allows binding to the FillRuleProperty as BindFillRule for the Polyline control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Polyline.</returns>
    public static Bindings.BindableProperty<FillRule> BindFillRule(this Polyline _) => Bindings.BindableProperty<FillRule>.Create(Polyline.FillRuleProperty);

    /// <summary>
    /// Allows binding to the PointsProperty as BindPoints for the Polyline control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Polyline.</returns>
    public static Bindings.BindableProperty<PointCollection> BindPoints(this Polyline _) => Bindings.BindableProperty<PointCollection>.Create(Polyline.PointsProperty);

    // ***** PolyLineSegment Bindings *****

    /// <summary>
    /// Allows binding to the PointsProperty as BindPoints for the PolyLineSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PolyLineSegment.</returns>
    public static Bindings.BindableProperty<PointCollection> BindPoints(this PolyLineSegment _) => Bindings.BindableProperty<PointCollection>.Create(PolyLineSegment.PointsProperty);

    // ***** PolyQuadraticBezierSegment Bindings *****

    /// <summary>
    /// Allows binding to the PointsProperty as BindPoints for the PolyQuadraticBezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type PolyQuadraticBezierSegment.</returns>
    public static Bindings.BindableProperty<PointCollection> BindPoints(this PolyQuadraticBezierSegment _) => Bindings.BindableProperty<PointCollection>.Create(PolyQuadraticBezierSegment.PointsProperty);

    // ***** ProgressBar Bindings *****

    /// <summary>
    /// Allows binding to the ProgressColorProperty as BindProgressColor for the ProgressBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ProgressBar.</returns>
    public static Bindings.BindableProperty<Color> BindProgressColor(this ProgressBar _) => Bindings.BindableProperty<Color>.Create(ProgressBar.ProgressColorProperty);

    /// <summary>
    /// Allows binding to the ProgressProperty as BindProgress for the ProgressBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ProgressBar.</returns>
    public static Bindings.BindableProperty<double> BindProgress(this ProgressBar _) => Bindings.BindableProperty<double>.Create(ProgressBar.ProgressProperty);

    // ***** QuadraticBezierSegment Bindings *****

    /// <summary>
    /// Allows binding to the Point1Property as BindPoint1 for the QuadraticBezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type QuadraticBezierSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint1(this QuadraticBezierSegment _) => Bindings.BindableProperty<Point>.Create(QuadraticBezierSegment.Point1Property);

    /// <summary>
    /// Allows binding to the Point2Property as BindPoint2 for the QuadraticBezierSegment control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type QuadraticBezierSegment.</returns>
    public static Bindings.BindableProperty<Point> BindPoint2(this QuadraticBezierSegment _) => Bindings.BindableProperty<Point>.Create(QuadraticBezierSegment.Point2Property);

    // ***** RadialGradientBrush Bindings *****

    /// <summary>
    /// Allows binding to the CenterProperty as BindCenter for the RadialGradientBrush control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadialGradientBrush.</returns>
    public static Bindings.BindableProperty<Point> BindCenter(this RadialGradientBrush _) => Bindings.BindableProperty<Point>.Create(RadialGradientBrush.CenterProperty);

    /// <summary>
    /// Allows binding to the RadiusProperty as BindRadius for the RadialGradientBrush control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadialGradientBrush.</returns>
    public static Bindings.BindableProperty<double> BindRadius(this RadialGradientBrush _) => Bindings.BindableProperty<double>.Create(RadialGradientBrush.RadiusProperty);

    // ***** RadioButton Bindings *****

    /// <summary>
    /// Allows binding to the BorderColorProperty as BindBorderColor for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<Color> BindBorderColor(this RadioButton _) => Bindings.BindableProperty<Color>.Create(RadioButton.BorderColorProperty);

    /// <summary>
    /// Allows binding to the BorderWidthProperty as BindBorderWidth for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<double> BindBorderWidth(this RadioButton _) => Bindings.BindableProperty<double>.Create(RadioButton.BorderWidthProperty);

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this RadioButton _) => Bindings.BindableProperty<double>.Create(RadioButton.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<object> BindContent(this RadioButton _) => Bindings.BindableProperty<object>.Create(RadioButton.ContentProperty);

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<int> BindCornerRadius(this RadioButton _) => Bindings.BindableProperty<int>.Create(RadioButton.CornerRadiusProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this RadioButton _) => Bindings.BindableProperty<FontAttributes>.Create(RadioButton.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this RadioButton _) => Bindings.BindableProperty<bool>.Create(RadioButton.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this RadioButton _) => Bindings.BindableProperty<string>.Create(RadioButton.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this RadioButton _) => Bindings.BindableProperty<double>.Create(RadioButton.FontSizeProperty);

    /// <summary>
    /// Allows binding to the GroupNameProperty as BindGroupName for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<string> BindGroupName(this RadioButton _) => Bindings.BindableProperty<string>.Create(RadioButton.GroupNameProperty);

    /// <summary>
    /// Allows binding to the IsCheckedProperty as BindIsChecked for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<bool> BindIsChecked(this RadioButton _) => Bindings.BindableProperty<bool>.Create(RadioButton.IsCheckedProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this RadioButton _) => Bindings.BindableProperty<Color>.Create(RadioButton.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this RadioButton _) => Bindings.BindableProperty<TextTransform>.Create(RadioButton.TextTransformProperty);

    /// <summary>
    /// Allows binding to the ValueProperty as BindValue for the RadioButton control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RadioButton.</returns>
    public static Bindings.BindableProperty<object> BindValue(this RadioButton _) => Bindings.BindableProperty<object>.Create(RadioButton.ValueProperty);

    // ***** Rectangle Bindings *****

    /// <summary>
    /// Allows binding to the RadiusXProperty as BindRadiusX for the Rectangle control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Rectangle.</returns>
    public static Bindings.BindableProperty<double> BindRadiusX(this Rectangle _) => Bindings.BindableProperty<double>.Create(Rectangle.RadiusXProperty);

    /// <summary>
    /// Allows binding to the RadiusYProperty as BindRadiusY for the Rectangle control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Rectangle.</returns>
    public static Bindings.BindableProperty<double> BindRadiusY(this Rectangle _) => Bindings.BindableProperty<double>.Create(Rectangle.RadiusYProperty);

    // ***** RectangleGeometry Bindings *****

    /// <summary>
    /// Allows binding to the RectProperty as BindRect for the RectangleGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RectangleGeometry.</returns>
    public static Bindings.BindableProperty<Rect> BindRect(this RectangleGeometry _) => Bindings.BindableProperty<Rect>.Create(RectangleGeometry.RectProperty);

    // ***** RefreshView Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the RefreshView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RefreshView.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this RefreshView _) => Bindings.BindableProperty<object>.Create(RefreshView.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the RefreshView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RefreshView.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this RefreshView _) => Bindings.BindableProperty<ICommand>.Create(RefreshView.CommandProperty);

    /// <summary>
    /// Allows binding to the IsRefreshingProperty as BindIsRefreshing for the RefreshView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RefreshView.</returns>
    public static Bindings.BindableProperty<bool> BindIsRefreshing(this RefreshView _) => Bindings.BindableProperty<bool>.Create(RefreshView.IsRefreshingProperty);

    /// <summary>
    /// Allows binding to the RefreshColorProperty as BindRefreshColor for the RefreshView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RefreshView.</returns>
    public static Bindings.BindableProperty<Color> BindRefreshColor(this RefreshView _) => Bindings.BindableProperty<Color>.Create(RefreshView.RefreshColorProperty);

    // ***** Microsoft.Maui.Controls.Compatibility.RelativeLayout Bindings *****

    /// <summary>
    /// Allows binding to the BoundsConstraintProperty as BindBoundsConstraint for the Microsoft.Maui.Controls.Compatibility.RelativeLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.RelativeLayout.</returns>
    public static Bindings.BindableProperty<BoundsConstraint> BindBoundsConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<BoundsConstraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.BoundsConstraintProperty);

    /// <summary>
    /// Allows binding to the HeightConstraintProperty as BindHeightConstraint for the Microsoft.Maui.Controls.Compatibility.RelativeLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.RelativeLayout.</returns>
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindHeightConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.HeightConstraintProperty);

    /// <summary>
    /// Allows binding to the WidthConstraintProperty as BindWidthConstraint for the Microsoft.Maui.Controls.Compatibility.RelativeLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.RelativeLayout.</returns>
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindWidthConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.WidthConstraintProperty);

    /// <summary>
    /// Allows binding to the XConstraintProperty as BindXConstraint for the Microsoft.Maui.Controls.Compatibility.RelativeLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.RelativeLayout.</returns>
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindXConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.XConstraintProperty);

    /// <summary>
    /// Allows binding to the YConstraintProperty as BindYConstraint for the Microsoft.Maui.Controls.Compatibility.RelativeLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.RelativeLayout.</returns>
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindYConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.YConstraintProperty);

    // ***** ReorderableItemsView Bindings *****

    /// <summary>
    /// Allows binding to the CanMixGroupsProperty as BindCanMixGroups for the ReorderableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ReorderableItemsView.</returns>
    public static Bindings.BindableProperty<bool> BindCanMixGroups(this ReorderableItemsView _) => Bindings.BindableProperty<bool>.Create(ReorderableItemsView.CanMixGroupsProperty);

    /// <summary>
    /// Allows binding to the CanReorderItemsProperty as BindCanReorderItems for the ReorderableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ReorderableItemsView.</returns>
    public static Bindings.BindableProperty<bool> BindCanReorderItems(this ReorderableItemsView _) => Bindings.BindableProperty<bool>.Create(ReorderableItemsView.CanReorderItemsProperty);

    // ***** RotateTransform Bindings *****

    /// <summary>
    /// Allows binding to the AngleProperty as BindAngle for the RotateTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RotateTransform.</returns>
    public static Bindings.BindableProperty<double> BindAngle(this RotateTransform _) => Bindings.BindableProperty<double>.Create(RotateTransform.AngleProperty);

    /// <summary>
    /// Allows binding to the CenterXProperty as BindCenterX for the RotateTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RotateTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterX(this RotateTransform _) => Bindings.BindableProperty<double>.Create(RotateTransform.CenterXProperty);

    /// <summary>
    /// Allows binding to the CenterYProperty as BindCenterY for the RotateTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RotateTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterY(this RotateTransform _) => Bindings.BindableProperty<double>.Create(RotateTransform.CenterYProperty);

    // ***** RoundRectangle Bindings *****

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the RoundRectangle control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RoundRectangle.</returns>
    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this RoundRectangle _) => Bindings.BindableProperty<CornerRadius>.Create(RoundRectangle.CornerRadiusProperty);

    // ***** RoundRectangleGeometry Bindings *****

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the RoundRectangleGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RoundRectangleGeometry.</returns>
    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this RoundRectangleGeometry _) => Bindings.BindableProperty<CornerRadius>.Create(RoundRectangleGeometry.CornerRadiusProperty);

    /// <summary>
    /// Allows binding to the RectProperty as BindRect for the RoundRectangleGeometry control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RoundRectangleGeometry.</returns>
    public static Bindings.BindableProperty<Rect> BindRect(this RoundRectangleGeometry _) => Bindings.BindableProperty<Rect>.Create(RoundRectangleGeometry.RectProperty);

    // ***** RowDefinition Bindings *****

    /// <summary>
    /// Allows binding to the HeightProperty as BindHeight for the RowDefinition control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RowDefinition.</returns>
    public static Bindings.BindableProperty<GridLength> BindHeight(this RowDefinition _) => Bindings.BindableProperty<GridLength>.Create(RowDefinition.HeightProperty);

    // ***** ScaleTransform Bindings *****

    /// <summary>
    /// Allows binding to the CenterXProperty as BindCenterX for the ScaleTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScaleTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterX(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.CenterXProperty);

    /// <summary>
    /// Allows binding to the CenterYProperty as BindCenterY for the ScaleTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScaleTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterY(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.CenterYProperty);

    /// <summary>
    /// Allows binding to the ScaleXProperty as BindScaleX for the ScaleTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScaleTransform.</returns>
    public static Bindings.BindableProperty<double> BindScaleX(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.ScaleXProperty);

    /// <summary>
    /// Allows binding to the ScaleYProperty as BindScaleY for the ScaleTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScaleTransform.</returns>
    public static Bindings.BindableProperty<double> BindScaleY(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.ScaleYProperty);

    // ***** ScrollView Bindings *****

    /// <summary>
    /// Allows binding to the ContentSizeProperty as BindContentSize for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScrollView.</returns>
    public static Bindings.BindableProperty<Size> BindContentSize(this ScrollView _) => Bindings.BindableProperty<Size>.Create(ScrollView.ContentSizeProperty);

    /// <summary>
    /// Allows binding to the HorizontalScrollBarVisibilityProperty as BindHorizontalScrollBarVisibility for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScrollView.</returns>
    public static Bindings.BindableProperty<ScrollBarVisibility> BindHorizontalScrollBarVisibility(this ScrollView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ScrollView.HorizontalScrollBarVisibilityProperty);

    /// <summary>
    /// Allows binding to the OrientationProperty as BindOrientation for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScrollView.</returns>
    public static Bindings.BindableProperty<ScrollOrientation> BindOrientation(this ScrollView _) => Bindings.BindableProperty<ScrollOrientation>.Create(ScrollView.OrientationProperty);

    /// <summary>
    /// Allows binding to the ScrollXProperty as BindScrollX for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScrollView.</returns>
    public static Bindings.BindableProperty<double> BindScrollX(this ScrollView _) => Bindings.BindableProperty<double>.Create(ScrollView.ScrollXProperty);

    /// <summary>
    /// Allows binding to the ScrollYProperty as BindScrollY for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScrollView.</returns>
    public static Bindings.BindableProperty<double> BindScrollY(this ScrollView _) => Bindings.BindableProperty<double>.Create(ScrollView.ScrollYProperty);

    /// <summary>
    /// Allows binding to the VerticalScrollBarVisibilityProperty as BindVerticalScrollBarVisibility for the ScrollView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ScrollView.</returns>
    public static Bindings.BindableProperty<ScrollBarVisibility> BindVerticalScrollBarVisibility(this ScrollView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ScrollView.VerticalScrollBarVisibilityProperty);

    // ***** SearchBar Bindings *****

    /// <summary>
    /// Allows binding to the CancelButtonColorProperty as BindCancelButtonColor for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<Color> BindCancelButtonColor(this SearchBar _) => Bindings.BindableProperty<Color>.Create(SearchBar.CancelButtonColorProperty);

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this SearchBar _) => Bindings.BindableProperty<double>.Create(SearchBar.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the CursorPositionProperty as BindCursorPosition for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<int> BindCursorPosition(this SearchBar _) => Bindings.BindableProperty<int>.Create(SearchBar.CursorPositionProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this SearchBar _) => Bindings.BindableProperty<FontAttributes>.Create(SearchBar.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this SearchBar _) => Bindings.BindableProperty<bool>.Create(SearchBar.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this SearchBar _) => Bindings.BindableProperty<string>.Create(SearchBar.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this SearchBar _) => Bindings.BindableProperty<double>.Create(SearchBar.FontSizeProperty);

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this SearchBar _) => Bindings.BindableProperty<TextAlignment>.Create(SearchBar.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the IsTextPredictionEnabledProperty as BindIsTextPredictionEnabled for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<bool> BindIsTextPredictionEnabled(this SearchBar _) => Bindings.BindableProperty<bool>.Create(SearchBar.IsTextPredictionEnabledProperty);

    /// <summary>
    /// Allows binding to the PlaceholderColorProperty as BindPlaceholderColor for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this SearchBar _) => Bindings.BindableProperty<Color>.Create(SearchBar.PlaceholderColorProperty);

    /// <summary>
    /// Allows binding to the PlaceholderProperty as BindPlaceholder for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<string> BindPlaceholder(this SearchBar _) => Bindings.BindableProperty<string>.Create(SearchBar.PlaceholderProperty);

    /// <summary>
    /// Allows binding to the SearchCommandParameterProperty as BindSearchCommandParameter for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<object> BindSearchCommandParameter(this SearchBar _) => Bindings.BindableProperty<object>.Create(SearchBar.SearchCommandParameterProperty);

    /// <summary>
    /// Allows binding to the SearchCommandProperty as BindSearchCommand for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<ICommand> BindSearchCommand(this SearchBar _) => Bindings.BindableProperty<ICommand>.Create(SearchBar.SearchCommandProperty);

    /// <summary>
    /// Allows binding to the SelectionLengthProperty as BindSelectionLength for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<int> BindSelectionLength(this SearchBar _) => Bindings.BindableProperty<int>.Create(SearchBar.SelectionLengthProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this SearchBar _) => Bindings.BindableProperty<Color>.Create(SearchBar.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<string> BindText(this SearchBar _) => Bindings.BindableProperty<string>.Create(SearchBar.TextProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the SearchBar control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchBar.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this SearchBar _) => Bindings.BindableProperty<TextAlignment>.Create(SearchBar.VerticalTextAlignmentProperty);

    // ***** SearchHandler Bindings *****

    /// <summary>
    /// Allows binding to the AutomationIdProperty as BindAutomationId for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindAutomationId(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.AutomationIdProperty);

    /// <summary>
    /// Allows binding to the BackgroundColorProperty as BindBackgroundColor for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.BackgroundColorProperty);

    /// <summary>
    /// Allows binding to the CancelButtonColorProperty as BindCancelButtonColor for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<Color> BindCancelButtonColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.CancelButtonColorProperty);

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this SearchHandler _) => Bindings.BindableProperty<double>.Create(SearchHandler.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the ClearIconHelpTextProperty as BindClearIconHelpText for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindClearIconHelpText(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearIconHelpTextProperty);

    /// <summary>
    /// Allows binding to the ClearIconNameProperty as BindClearIconName for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindClearIconName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearIconNameProperty);

    /// <summary>
    /// Allows binding to the ClearIconProperty as BindClearIcon for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<ImageSource> BindClearIcon(this SearchHandler _) => Bindings.BindableProperty<ImageSource>.Create(SearchHandler.ClearIconProperty);

    /// <summary>
    /// Allows binding to the ClearPlaceholderCommandParameterProperty as BindClearPlaceholderCommandParameter for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<object> BindClearPlaceholderCommandParameter(this SearchHandler _) => Bindings.BindableProperty<object>.Create(SearchHandler.ClearPlaceholderCommandParameterProperty);

    /// <summary>
    /// Allows binding to the ClearPlaceholderCommandProperty as BindClearPlaceholderCommand for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<ICommand> BindClearPlaceholderCommand(this SearchHandler _) => Bindings.BindableProperty<ICommand>.Create(SearchHandler.ClearPlaceholderCommandProperty);

    /// <summary>
    /// Allows binding to the ClearPlaceholderEnabledProperty as BindClearPlaceholderEnabled for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<bool> BindClearPlaceholderEnabled(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.ClearPlaceholderEnabledProperty);

    /// <summary>
    /// Allows binding to the ClearPlaceholderHelpTextProperty as BindClearPlaceholderHelpText for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindClearPlaceholderHelpText(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearPlaceholderHelpTextProperty);

    /// <summary>
    /// Allows binding to the ClearPlaceholderIconProperty as BindClearPlaceholderIcon for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<ImageSource> BindClearPlaceholderIcon(this SearchHandler _) => Bindings.BindableProperty<ImageSource>.Create(SearchHandler.ClearPlaceholderIconProperty);

    /// <summary>
    /// Allows binding to the ClearPlaceholderNameProperty as BindClearPlaceholderName for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindClearPlaceholderName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearPlaceholderNameProperty);

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this SearchHandler _) => Bindings.BindableProperty<object>.Create(SearchHandler.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this SearchHandler _) => Bindings.BindableProperty<ICommand>.Create(SearchHandler.CommandProperty);

    /// <summary>
    /// Allows binding to the DisplayMemberNameProperty as BindDisplayMemberName for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindDisplayMemberName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.DisplayMemberNameProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this SearchHandler _) => Bindings.BindableProperty<FontAttributes>.Create(SearchHandler.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this SearchHandler _) => Bindings.BindableProperty<double>.Create(SearchHandler.FontSizeProperty);

    /// <summary>
    /// Allows binding to the HorizontalTextAlignmentProperty as BindHorizontalTextAlignment for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this SearchHandler _) => Bindings.BindableProperty<TextAlignment>.Create(SearchHandler.HorizontalTextAlignmentProperty);

    /// <summary>
    /// Allows binding to the IsFocusedProperty as BindIsFocused for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<bool> BindIsFocused(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.IsFocusedProperty);

    /// <summary>
    /// Allows binding to the IsSearchEnabledProperty as BindIsSearchEnabled for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<bool> BindIsSearchEnabled(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.IsSearchEnabledProperty);

    /// <summary>
    /// Allows binding to the ItemsSourceProperty as BindItemsSource for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<IEnumerable> BindItemsSource(this SearchHandler _) => Bindings.BindableProperty<IEnumerable>.Create(SearchHandler.ItemsSourceProperty);

    /// <summary>
    /// Allows binding to the ItemTemplateProperty as BindItemTemplate for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindItemTemplate(this SearchHandler _) => Bindings.BindableProperty<DataTemplate>.Create(SearchHandler.ItemTemplateProperty);

    /// <summary>
    /// Allows binding to the KeyboardProperty as BindKeyboard for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this SearchHandler _) => Bindings.BindableProperty<Keyboard>.Create(SearchHandler.KeyboardProperty);

    /// <summary>
    /// Allows binding to the PlaceholderColorProperty as BindPlaceholderColor for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.PlaceholderColorProperty);

    /// <summary>
    /// Allows binding to the PlaceholderProperty as BindPlaceholder for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindPlaceholder(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.PlaceholderProperty);

    /// <summary>
    /// Allows binding to the QueryIconHelpTextProperty as BindQueryIconHelpText for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindQueryIconHelpText(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.QueryIconHelpTextProperty);

    /// <summary>
    /// Allows binding to the QueryIconNameProperty as BindQueryIconName for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindQueryIconName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.QueryIconNameProperty);

    /// <summary>
    /// Allows binding to the QueryIconProperty as BindQueryIcon for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<ImageSource> BindQueryIcon(this SearchHandler _) => Bindings.BindableProperty<ImageSource>.Create(SearchHandler.QueryIconProperty);

    /// <summary>
    /// Allows binding to the QueryProperty as BindQuery for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<string> BindQuery(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.QueryProperty);

    /// <summary>
    /// Allows binding to the SearchBoxVisibilityProperty as BindSearchBoxVisibility for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<SearchBoxVisibility> BindSearchBoxVisibility(this SearchHandler _) => Bindings.BindableProperty<SearchBoxVisibility>.Create(SearchHandler.SearchBoxVisibilityProperty);

    /// <summary>
    /// Allows binding to the SelectedItemProperty as BindSelectedItem for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<object> BindSelectedItem(this SearchHandler _) => Bindings.BindableProperty<object>.Create(SearchHandler.SelectedItemProperty);

    /// <summary>
    /// Allows binding to the ShowsResultsProperty as BindShowsResults for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<bool> BindShowsResults(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.ShowsResultsProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this SearchHandler _) => Bindings.BindableProperty<TextTransform>.Create(SearchHandler.TextTransformProperty);

    /// <summary>
    /// Allows binding to the VerticalTextAlignmentProperty as BindVerticalTextAlignment for the SearchHandler control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SearchHandler.</returns>
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this SearchHandler _) => Bindings.BindableProperty<TextAlignment>.Create(SearchHandler.VerticalTextAlignmentProperty);

    // ***** SelectableItemsView Bindings *****

    /// <summary>
    /// Allows binding to the SelectedItemProperty as BindSelectedItem for the SelectableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SelectableItemsView.</returns>
    public static Bindings.BindableProperty<object> BindSelectedItem(this SelectableItemsView _) => Bindings.BindableProperty<object>.Create(SelectableItemsView.SelectedItemProperty);

    /// <summary>
    /// Allows binding to the SelectedItemsProperty as BindSelectedItems for the SelectableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SelectableItemsView.</returns>
    public static Bindings.BindableProperty<IList<object>> BindSelectedItems(this SelectableItemsView _) => Bindings.BindableProperty<IList<object>>.Create(SelectableItemsView.SelectedItemsProperty);

    /// <summary>
    /// Allows binding to the SelectionChangedCommandParameterProperty as BindSelectionChangedCommandParameter for the SelectableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SelectableItemsView.</returns>
    public static Bindings.BindableProperty<object> BindSelectionChangedCommandParameter(this SelectableItemsView _) => Bindings.BindableProperty<object>.Create(SelectableItemsView.SelectionChangedCommandParameterProperty);

    /// <summary>
    /// Allows binding to the SelectionChangedCommandProperty as BindSelectionChangedCommand for the SelectableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SelectableItemsView.</returns>
    public static Bindings.BindableProperty<ICommand> BindSelectionChangedCommand(this SelectableItemsView _) => Bindings.BindableProperty<ICommand>.Create(SelectableItemsView.SelectionChangedCommandProperty);

    /// <summary>
    /// Allows binding to the SelectionModeProperty as BindSelectionMode for the SelectableItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SelectableItemsView.</returns>
    public static Bindings.BindableProperty<SelectionMode> BindSelectionMode(this SelectableItemsView _) => Bindings.BindableProperty<SelectionMode>.Create(SelectableItemsView.SelectionModeProperty);

    // ***** Shadow Bindings *****

    /// <summary>
    /// Allows binding to the BrushProperty as BindBrush for the Shadow control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shadow.</returns>
    public static Bindings.BindableProperty<Brush> BindBrush(this Shadow _) => Bindings.BindableProperty<Brush>.Create(Shadow.BrushProperty);

    /// <summary>
    /// Allows binding to the OffsetProperty as BindOffset for the Shadow control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shadow.</returns>
    public static Bindings.BindableProperty<Point> BindOffset(this Shadow _) => Bindings.BindableProperty<Point>.Create(Shadow.OffsetProperty);

    /// <summary>
    /// Allows binding to the OpacityProperty as BindOpacity for the Shadow control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shadow.</returns>
    public static Bindings.BindableProperty<float> BindOpacity(this Shadow _) => Bindings.BindableProperty<float>.Create(Shadow.OpacityProperty);

    /// <summary>
    /// Allows binding to the RadiusProperty as BindRadius for the Shadow control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shadow.</returns>
    public static Bindings.BindableProperty<float> BindRadius(this Shadow _) => Bindings.BindableProperty<float>.Create(Shadow.RadiusProperty);

    // ***** Shape Bindings *****

    /// <summary>
    /// Allows binding to the AspectProperty as BindAspect for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<Stretch> BindAspect(this Shape _) => Bindings.BindableProperty<Stretch>.Create(Shape.AspectProperty);

    /// <summary>
    /// Allows binding to the FillProperty as BindFill for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<Brush> BindFill(this Shape _) => Bindings.BindableProperty<Brush>.Create(Shape.FillProperty);

    /// <summary>
    /// Allows binding to the StrokeDashArrayProperty as BindStrokeDashArray for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<DoubleCollection> BindStrokeDashArray(this Shape _) => Bindings.BindableProperty<DoubleCollection>.Create(Shape.StrokeDashArrayProperty);

    /// <summary>
    /// Allows binding to the StrokeDashOffsetProperty as BindStrokeDashOffset for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<double> BindStrokeDashOffset(this Shape _) => Bindings.BindableProperty<double>.Create(Shape.StrokeDashOffsetProperty);

    /// <summary>
    /// Allows binding to the StrokeLineCapProperty as BindStrokeLineCap for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<PenLineCap> BindStrokeLineCap(this Shape _) => Bindings.BindableProperty<PenLineCap>.Create(Shape.StrokeLineCapProperty);

    /// <summary>
    /// Allows binding to the StrokeLineJoinProperty as BindStrokeLineJoin for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<PenLineJoin> BindStrokeLineJoin(this Shape _) => Bindings.BindableProperty<PenLineJoin>.Create(Shape.StrokeLineJoinProperty);

    /// <summary>
    /// Allows binding to the StrokeMiterLimitProperty as BindStrokeMiterLimit for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<double> BindStrokeMiterLimit(this Shape _) => Bindings.BindableProperty<double>.Create(Shape.StrokeMiterLimitProperty);

    /// <summary>
    /// Allows binding to the StrokeProperty as BindStroke for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<Brush> BindStroke(this Shape _) => Bindings.BindableProperty<Brush>.Create(Shape.StrokeProperty);

    /// <summary>
    /// Allows binding to the StrokeThicknessProperty as BindStrokeThickness for the Shape control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shape.</returns>
    public static Bindings.BindableProperty<double> BindStrokeThickness(this Shape _) => Bindings.BindableProperty<double>.Create(Shape.StrokeThicknessProperty);

    // ***** Shell Bindings *****

    /// <summary>
    /// Allows binding to the BackButtonBehaviorProperty as BindBackButtonBehavior for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<BackButtonBehavior> BindBackButtonBehavior(this Shell _) => Bindings.BindableProperty<BackButtonBehavior>.Create(Shell.BackButtonBehaviorProperty);

    /// <summary>
    /// Allows binding to the BackgroundColorProperty as BindBackgroundColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.BackgroundColorProperty);

    /// <summary>
    /// Allows binding to the CurrentItemProperty as BindCurrentItem for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<ShellItem> BindCurrentItem(this Shell _) => Bindings.BindableProperty<ShellItem>.Create(Shell.CurrentItemProperty);

    /// <summary>
    /// Allows binding to the CurrentStateProperty as BindCurrentState for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<ShellNavigationState> BindCurrentState(this Shell _) => Bindings.BindableProperty<ShellNavigationState>.Create(Shell.CurrentStateProperty);

    /// <summary>
    /// Allows binding to the DisabledColorProperty as BindDisabledColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindDisabledColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.DisabledColorProperty);

    /// <summary>
    /// Allows binding to the FlyoutBackdropProperty as BindFlyoutBackdrop for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Brush> BindFlyoutBackdrop(this Shell _) => Bindings.BindableProperty<Brush>.Create(Shell.FlyoutBackdropProperty);

    /// <summary>
    /// Allows binding to the FlyoutBackgroundColorProperty as BindFlyoutBackgroundColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindFlyoutBackgroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.FlyoutBackgroundColorProperty);

    /// <summary>
    /// Allows binding to the FlyoutBackgroundImageAspectProperty as BindFlyoutBackgroundImageAspect for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Aspect> BindFlyoutBackgroundImageAspect(this Shell _) => Bindings.BindableProperty<Aspect>.Create(Shell.FlyoutBackgroundImageAspectProperty);

    /// <summary>
    /// Allows binding to the FlyoutBackgroundImageProperty as BindFlyoutBackgroundImage for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<ImageSource> BindFlyoutBackgroundImage(this Shell _) => Bindings.BindableProperty<ImageSource>.Create(Shell.FlyoutBackgroundImageProperty);

    /// <summary>
    /// Allows binding to the FlyoutBackgroundProperty as BindFlyoutBackground for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Brush> BindFlyoutBackground(this Shell _) => Bindings.BindableProperty<Brush>.Create(Shell.FlyoutBackgroundProperty);

    /// <summary>
    /// Allows binding to the FlyoutBehaviorProperty as BindFlyoutBehavior for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<FlyoutBehavior> BindFlyoutBehavior(this Shell _) => Bindings.BindableProperty<FlyoutBehavior>.Create(Shell.FlyoutBehaviorProperty);

    /// <summary>
    /// Allows binding to the FlyoutContentProperty as BindFlyoutContent for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<object> BindFlyoutContent(this Shell _) => Bindings.BindableProperty<object>.Create(Shell.FlyoutContentProperty);

    /// <summary>
    /// Allows binding to the FlyoutContentTemplateProperty as BindFlyoutContentTemplate for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindFlyoutContentTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.FlyoutContentTemplateProperty);

    /// <summary>
    /// Allows binding to the FlyoutFooterProperty as BindFlyoutFooter for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<object> BindFlyoutFooter(this Shell _) => Bindings.BindableProperty<object>.Create(Shell.FlyoutFooterProperty);

    /// <summary>
    /// Allows binding to the FlyoutFooterTemplateProperty as BindFlyoutFooterTemplate for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindFlyoutFooterTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.FlyoutFooterTemplateProperty);

    /// <summary>
    /// Allows binding to the FlyoutHeaderBehaviorProperty as BindFlyoutHeaderBehavior for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<FlyoutHeaderBehavior> BindFlyoutHeaderBehavior(this Shell _) => Bindings.BindableProperty<FlyoutHeaderBehavior>.Create(Shell.FlyoutHeaderBehaviorProperty);

    /// <summary>
    /// Allows binding to the FlyoutHeaderProperty as BindFlyoutHeader for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<object> BindFlyoutHeader(this Shell _) => Bindings.BindableProperty<object>.Create(Shell.FlyoutHeaderProperty);

    /// <summary>
    /// Allows binding to the FlyoutHeaderTemplateProperty as BindFlyoutHeaderTemplate for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindFlyoutHeaderTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.FlyoutHeaderTemplateProperty);

    /// <summary>
    /// Allows binding to the FlyoutHeightProperty as BindFlyoutHeight for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<double> BindFlyoutHeight(this Shell _) => Bindings.BindableProperty<double>.Create(Shell.FlyoutHeightProperty);

    /// <summary>
    /// Allows binding to the FlyoutIconProperty as BindFlyoutIcon for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<ImageSource> BindFlyoutIcon(this Shell _) => Bindings.BindableProperty<ImageSource>.Create(Shell.FlyoutIconProperty);

    /// <summary>
    /// Allows binding to the FlyoutIsPresentedProperty as BindFlyoutIsPresented for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<bool> BindFlyoutIsPresented(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.FlyoutIsPresentedProperty);

    /// <summary>
    /// Allows binding to the FlyoutItemIsVisibleProperty as BindFlyoutItemIsVisible for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<bool> BindFlyoutItemIsVisible(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.FlyoutItemIsVisibleProperty);

    /// <summary>
    /// Allows binding to the FlyoutVerticalScrollModeProperty as BindFlyoutVerticalScrollMode for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<ScrollMode> BindFlyoutVerticalScrollMode(this Shell _) => Bindings.BindableProperty<ScrollMode>.Create(Shell.FlyoutVerticalScrollModeProperty);

    /// <summary>
    /// Allows binding to the FlyoutWidthProperty as BindFlyoutWidth for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<double> BindFlyoutWidth(this Shell _) => Bindings.BindableProperty<double>.Create(Shell.FlyoutWidthProperty);

    /// <summary>
    /// Allows binding to the ForegroundColorProperty as BindForegroundColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindForegroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.ForegroundColorProperty);

    /// <summary>
    /// Allows binding to the ItemTemplateProperty as BindItemTemplate for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindItemTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.ItemTemplateProperty);

    /// <summary>
    /// Allows binding to the MenuItemTemplateProperty as BindMenuItemTemplate for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindMenuItemTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.MenuItemTemplateProperty);

    /// <summary>
    /// Allows binding to the NavBarHasShadowProperty as BindNavBarHasShadow for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<bool> BindNavBarHasShadow(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.NavBarHasShadowProperty);

    /// <summary>
    /// Allows binding to the NavBarIsVisibleProperty as BindNavBarIsVisible for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<bool> BindNavBarIsVisible(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.NavBarIsVisibleProperty);

    /// <summary>
    /// Allows binding to the PresentationModeProperty as BindPresentationMode for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<PresentationMode> BindPresentationMode(this Shell _) => Bindings.BindableProperty<PresentationMode>.Create(Shell.PresentationModeProperty);

    /// <summary>
    /// Allows binding to the SearchHandlerProperty as BindSearchHandler for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<SearchHandler> BindSearchHandler(this Shell _) => Bindings.BindableProperty<SearchHandler>.Create(Shell.SearchHandlerProperty);

    /// <summary>
    /// Allows binding to the TabBarBackgroundColorProperty as BindTabBarBackgroundColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindTabBarBackgroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarBackgroundColorProperty);

    /// <summary>
    /// Allows binding to the TabBarDisabledColorProperty as BindTabBarDisabledColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindTabBarDisabledColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarDisabledColorProperty);

    /// <summary>
    /// Allows binding to the TabBarForegroundColorProperty as BindTabBarForegroundColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindTabBarForegroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarForegroundColorProperty);

    /// <summary>
    /// Allows binding to the TabBarIsVisibleProperty as BindTabBarIsVisible for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<bool> BindTabBarIsVisible(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.TabBarIsVisibleProperty);

    /// <summary>
    /// Allows binding to the TabBarTitleColorProperty as BindTabBarTitleColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindTabBarTitleColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarTitleColorProperty);

    /// <summary>
    /// Allows binding to the TabBarUnselectedColorProperty as BindTabBarUnselectedColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindTabBarUnselectedColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarUnselectedColorProperty);

    /// <summary>
    /// Allows binding to the TitleColorProperty as BindTitleColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindTitleColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TitleColorProperty);

    /// <summary>
    /// Allows binding to the TitleViewProperty as BindTitleView for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<View> BindTitleView(this Shell _) => Bindings.BindableProperty<View>.Create(Shell.TitleViewProperty);

    /// <summary>
    /// Allows binding to the UnselectedColorProperty as BindUnselectedColor for the Shell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Shell.</returns>
    public static Bindings.BindableProperty<Color> BindUnselectedColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.UnselectedColorProperty);

    // ***** ShellContent Bindings *****

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the ShellContent control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ShellContent.</returns>
    public static Bindings.BindableProperty<object> BindContent(this ShellContent _) => Bindings.BindableProperty<object>.Create(ShellContent.ContentProperty);

    /// <summary>
    /// Allows binding to the ContentTemplateProperty as BindContentTemplate for the ShellContent control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ShellContent.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindContentTemplate(this ShellContent _) => Bindings.BindableProperty<DataTemplate>.Create(ShellContent.ContentTemplateProperty);

    /// <summary>
    /// Allows binding to the MenuItemsProperty as BindMenuItems for the ShellContent control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ShellContent.</returns>
    public static Bindings.BindableProperty<MenuItemCollection> BindMenuItems(this ShellContent _) => Bindings.BindableProperty<MenuItemCollection>.Create(ShellContent.MenuItemsProperty);

    // ***** ShellGroupItem Bindings *****

    /// <summary>
    /// Allows binding to the FlyoutDisplayOptionsProperty as BindFlyoutDisplayOptions for the ShellGroupItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ShellGroupItem.</returns>
    public static Bindings.BindableProperty<FlyoutDisplayOptions> BindFlyoutDisplayOptions(this ShellGroupItem _) => Bindings.BindableProperty<FlyoutDisplayOptions>.Create(ShellGroupItem.FlyoutDisplayOptionsProperty);

    // ***** ShellItem Bindings *****

    /// <summary>
    /// Allows binding to the CurrentItemProperty as BindCurrentItem for the ShellItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ShellItem.</returns>
    public static Bindings.BindableProperty<ShellSection> BindCurrentItem(this ShellItem _) => Bindings.BindableProperty<ShellSection>.Create(ShellItem.CurrentItemProperty);

    // ***** ShellSection Bindings *****

    /// <summary>
    /// Allows binding to the CurrentItemProperty as BindCurrentItem for the ShellSection control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ShellSection.</returns>
    public static Bindings.BindableProperty<ShellContent> BindCurrentItem(this ShellSection _) => Bindings.BindableProperty<ShellContent>.Create(ShellSection.CurrentItemProperty);

    // ***** SkewTransform Bindings *****

    /// <summary>
    /// Allows binding to the AngleXProperty as BindAngleX for the SkewTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SkewTransform.</returns>
    public static Bindings.BindableProperty<double> BindAngleX(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.AngleXProperty);

    /// <summary>
    /// Allows binding to the AngleYProperty as BindAngleY for the SkewTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SkewTransform.</returns>
    public static Bindings.BindableProperty<double> BindAngleY(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.AngleYProperty);

    /// <summary>
    /// Allows binding to the CenterXProperty as BindCenterX for the SkewTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SkewTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterX(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.CenterXProperty);

    /// <summary>
    /// Allows binding to the CenterYProperty as BindCenterY for the SkewTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SkewTransform.</returns>
    public static Bindings.BindableProperty<double> BindCenterY(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.CenterYProperty);

    // ***** Slider Bindings *****

    /// <summary>
    /// Allows binding to the DragCompletedCommandProperty as BindDragCompletedCommand for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<ICommand> BindDragCompletedCommand(this Slider _) => Bindings.BindableProperty<ICommand>.Create(Slider.DragCompletedCommandProperty);

    /// <summary>
    /// Allows binding to the DragStartedCommandProperty as BindDragStartedCommand for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<ICommand> BindDragStartedCommand(this Slider _) => Bindings.BindableProperty<ICommand>.Create(Slider.DragStartedCommandProperty);

    /// <summary>
    /// Allows binding to the MaximumProperty as BindMaximum for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<double> BindMaximum(this Slider _) => Bindings.BindableProperty<double>.Create(Slider.MaximumProperty);

    /// <summary>
    /// Allows binding to the MaximumTrackColorProperty as BindMaximumTrackColor for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<Color> BindMaximumTrackColor(this Slider _) => Bindings.BindableProperty<Color>.Create(Slider.MaximumTrackColorProperty);

    /// <summary>
    /// Allows binding to the MinimumProperty as BindMinimum for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<double> BindMinimum(this Slider _) => Bindings.BindableProperty<double>.Create(Slider.MinimumProperty);

    /// <summary>
    /// Allows binding to the MinimumTrackColorProperty as BindMinimumTrackColor for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<Color> BindMinimumTrackColor(this Slider _) => Bindings.BindableProperty<Color>.Create(Slider.MinimumTrackColorProperty);

    /// <summary>
    /// Allows binding to the ThumbColorProperty as BindThumbColor for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<Color> BindThumbColor(this Slider _) => Bindings.BindableProperty<Color>.Create(Slider.ThumbColorProperty);

    /// <summary>
    /// Allows binding to the ThumbImageSourceProperty as BindThumbImageSource for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<ImageSource> BindThumbImageSource(this Slider _) => Bindings.BindableProperty<ImageSource>.Create(Slider.ThumbImageSourceProperty);

    /// <summary>
    /// Allows binding to the ValueProperty as BindValue for the Slider control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Slider.</returns>
    public static Bindings.BindableProperty<double> BindValue(this Slider _) => Bindings.BindableProperty<double>.Create(Slider.ValueProperty);

    // ***** SolidColorBrush Bindings *****

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the SolidColorBrush control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SolidColorBrush.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this SolidColorBrush _) => Bindings.BindableProperty<Color>.Create(SolidColorBrush.ColorProperty);

    // ***** Span Bindings *****

    /// <summary>
    /// Allows binding to the BackgroundColorProperty as BindBackgroundColor for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this Span _) => Bindings.BindableProperty<Color>.Create(Span.BackgroundColorProperty);

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Span _) => Bindings.BindableProperty<double>.Create(Span.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Span _) => Bindings.BindableProperty<FontAttributes>.Create(Span.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Span _) => Bindings.BindableProperty<bool>.Create(Span.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this Span _) => Bindings.BindableProperty<string>.Create(Span.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this Span _) => Bindings.BindableProperty<double>.Create(Span.FontSizeProperty);

    /// <summary>
    /// Allows binding to the LineHeightProperty as BindLineHeight for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<double> BindLineHeight(this Span _) => Bindings.BindableProperty<double>.Create(Span.LineHeightProperty);

    /// <summary>
    /// Allows binding to the StyleProperty as BindStyle for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<Style> BindStyle(this Span _) => Bindings.BindableProperty<Style>.Create(Span.StyleProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this Span _) => Bindings.BindableProperty<Color>.Create(Span.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextDecorationsProperty as BindTextDecorations for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<TextDecorations> BindTextDecorations(this Span _) => Bindings.BindableProperty<TextDecorations>.Create(Span.TextDecorationsProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<string> BindText(this Span _) => Bindings.BindableProperty<string>.Create(Span.TextProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the Span control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Span.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this Span _) => Bindings.BindableProperty<TextTransform>.Create(Span.TextTransformProperty);

    // ***** StackBase Bindings *****

    /// <summary>
    /// Allows binding to the SpacingProperty as BindSpacing for the StackBase control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StackBase.</returns>
    public static Bindings.BindableProperty<double> BindSpacing(this StackBase _) => Bindings.BindableProperty<double>.Create(StackBase.SpacingProperty);

    // ***** StackLayout Bindings *****

    /// <summary>
    /// Allows binding to the OrientationProperty as BindOrientation for the StackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StackLayout.</returns>
    public static Bindings.BindableProperty<StackOrientation> BindOrientation(this StackLayout _) => Bindings.BindableProperty<StackOrientation>.Create(StackLayout.OrientationProperty);

    // ***** Microsoft.Maui.Controls.Compatibility.StackLayout Bindings *****

    /// <summary>
    /// Allows binding to the OrientationProperty as BindOrientation for the Microsoft.Maui.Controls.Compatibility.StackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.StackLayout.</returns>
    public static Bindings.BindableProperty<StackOrientation> BindOrientation(this Microsoft.Maui.Controls.Compatibility.StackLayout _) => Bindings.BindableProperty<StackOrientation>.Create(Microsoft.Maui.Controls.Compatibility.StackLayout.OrientationProperty);

    /// <summary>
    /// Allows binding to the SpacingProperty as BindSpacing for the Microsoft.Maui.Controls.Compatibility.StackLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Microsoft.Maui.Controls.Compatibility.StackLayout.</returns>
    public static Bindings.BindableProperty<double> BindSpacing(this Microsoft.Maui.Controls.Compatibility.StackLayout _) => Bindings.BindableProperty<double>.Create(Microsoft.Maui.Controls.Compatibility.StackLayout.SpacingProperty);

    // ***** StateTrigger Bindings *****

    /// <summary>
    /// Allows binding to the IsActiveProperty as BindIsActive for the StateTrigger control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StateTrigger.</returns>
    public static Bindings.BindableProperty<bool> BindIsActive(this StateTrigger _) => Bindings.BindableProperty<bool>.Create(StateTrigger.IsActiveProperty);

    // ***** Stepper Bindings *****

    /// <summary>
    /// Allows binding to the IncrementProperty as BindIncrement for the Stepper control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Stepper.</returns>
    public static Bindings.BindableProperty<double> BindIncrement(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.IncrementProperty);

    /// <summary>
    /// Allows binding to the MaximumProperty as BindMaximum for the Stepper control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Stepper.</returns>
    public static Bindings.BindableProperty<double> BindMaximum(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.MaximumProperty);

    /// <summary>
    /// Allows binding to the MinimumProperty as BindMinimum for the Stepper control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Stepper.</returns>
    public static Bindings.BindableProperty<double> BindMinimum(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.MinimumProperty);

    /// <summary>
    /// Allows binding to the ValueProperty as BindValue for the Stepper control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Stepper.</returns>
    public static Bindings.BindableProperty<double> BindValue(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.ValueProperty);

    // ***** StreamImageSource Bindings *****

    /// <summary>
    /// Allows binding to the StreamProperty as BindStream for the StreamImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StreamImageSource.</returns>
    public static Bindings.BindableProperty<Func<Task<Stream>>> BindStream(this StreamImageSource _) => Bindings.BindableProperty<Func<Task<Stream>>>.Create(StreamImageSource.StreamProperty);

    // ***** StructuredItemsView Bindings *****

    /// <summary>
    /// Allows binding to the FooterProperty as BindFooter for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StructuredItemsView.</returns>
    public static Bindings.BindableProperty<object> BindFooter(this StructuredItemsView _) => Bindings.BindableProperty<object>.Create(StructuredItemsView.FooterProperty);

    /// <summary>
    /// Allows binding to the FooterTemplateProperty as BindFooterTemplate for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StructuredItemsView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindFooterTemplate(this StructuredItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(StructuredItemsView.FooterTemplateProperty);

    /// <summary>
    /// Allows binding to the HeaderProperty as BindHeader for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StructuredItemsView.</returns>
    public static Bindings.BindableProperty<object> BindHeader(this StructuredItemsView _) => Bindings.BindableProperty<object>.Create(StructuredItemsView.HeaderProperty);

    /// <summary>
    /// Allows binding to the HeaderTemplateProperty as BindHeaderTemplate for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StructuredItemsView.</returns>
    public static Bindings.BindableProperty<DataTemplate> BindHeaderTemplate(this StructuredItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(StructuredItemsView.HeaderTemplateProperty);

    /// <summary>
    /// Allows binding to the ItemSizingStrategyProperty as BindItemSizingStrategy for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StructuredItemsView.</returns>
    public static Bindings.BindableProperty<ItemSizingStrategy> BindItemSizingStrategy(this StructuredItemsView _) => Bindings.BindableProperty<ItemSizingStrategy>.Create(StructuredItemsView.ItemSizingStrategyProperty);

    /// <summary>
    /// Allows binding to the ItemsLayoutProperty as BindItemsLayout for the StructuredItemsView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type StructuredItemsView.</returns>
    public static Bindings.BindableProperty<IItemsLayout> BindItemsLayout(this StructuredItemsView _) => Bindings.BindableProperty<IItemsLayout>.Create(StructuredItemsView.ItemsLayoutProperty);

    // ***** SwipeGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the SwipeGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this SwipeGestureRecognizer _) => Bindings.BindableProperty<object>.Create(SwipeGestureRecognizer.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the SwipeGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this SwipeGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(SwipeGestureRecognizer.CommandProperty);

    /// <summary>
    /// Allows binding to the DirectionProperty as BindDirection for the SwipeGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeGestureRecognizer.</returns>
    public static Bindings.BindableProperty<SwipeDirection> BindDirection(this SwipeGestureRecognizer _) => Bindings.BindableProperty<SwipeDirection>.Create(SwipeGestureRecognizer.DirectionProperty);

    /// <summary>
    /// Allows binding to the ThresholdProperty as BindThreshold for the SwipeGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeGestureRecognizer.</returns>
    public static Bindings.BindableProperty<UInt32> BindThreshold(this SwipeGestureRecognizer _) => Bindings.BindableProperty<UInt32>.Create(SwipeGestureRecognizer.ThresholdProperty);

    // ***** SwipeItem Bindings *****

    /// <summary>
    /// Allows binding to the BackgroundColorProperty as BindBackgroundColor for the SwipeItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeItem.</returns>
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this SwipeItem _) => Bindings.BindableProperty<Color>.Create(SwipeItem.BackgroundColorProperty);

    /// <summary>
    /// Allows binding to the IsVisibleProperty as BindIsVisible for the SwipeItem control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeItem.</returns>
    public static Bindings.BindableProperty<bool> BindIsVisible(this SwipeItem _) => Bindings.BindableProperty<bool>.Create(SwipeItem.IsVisibleProperty);

    // ***** SwipeItems Bindings *****

    /// <summary>
    /// Allows binding to the ModeProperty as BindMode for the SwipeItems control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeItems.</returns>
    public static Bindings.BindableProperty<SwipeMode> BindMode(this SwipeItems _) => Bindings.BindableProperty<SwipeMode>.Create(SwipeItems.ModeProperty);

    /// <summary>
    /// Allows binding to the SwipeBehaviorOnInvokedProperty as BindSwipeBehaviorOnInvoked for the SwipeItems control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeItems.</returns>
    public static Bindings.BindableProperty<SwipeBehaviorOnInvoked> BindSwipeBehaviorOnInvoked(this SwipeItems _) => Bindings.BindableProperty<SwipeBehaviorOnInvoked>.Create(SwipeItems.SwipeBehaviorOnInvokedProperty);

    // ***** SwipeItemView Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the SwipeItemView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeItemView.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this SwipeItemView _) => Bindings.BindableProperty<object>.Create(SwipeItemView.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the SwipeItemView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeItemView.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this SwipeItemView _) => Bindings.BindableProperty<ICommand>.Create(SwipeItemView.CommandProperty);

    // ***** SwipeView Bindings *****

    /// <summary>
    /// Allows binding to the BottomItemsProperty as BindBottomItems for the SwipeView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeView.</returns>
    public static Bindings.BindableProperty<SwipeItems> BindBottomItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.BottomItemsProperty);

    /// <summary>
    /// Allows binding to the LeftItemsProperty as BindLeftItems for the SwipeView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeView.</returns>
    public static Bindings.BindableProperty<SwipeItems> BindLeftItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.LeftItemsProperty);

    /// <summary>
    /// Allows binding to the RightItemsProperty as BindRightItems for the SwipeView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeView.</returns>
    public static Bindings.BindableProperty<SwipeItems> BindRightItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.RightItemsProperty);

    /// <summary>
    /// Allows binding to the ThresholdProperty as BindThreshold for the SwipeView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeView.</returns>
    public static Bindings.BindableProperty<double> BindThreshold(this SwipeView _) => Bindings.BindableProperty<double>.Create(SwipeView.ThresholdProperty);

    /// <summary>
    /// Allows binding to the TopItemsProperty as BindTopItems for the SwipeView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwipeView.</returns>
    public static Bindings.BindableProperty<SwipeItems> BindTopItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.TopItemsProperty);

    // ***** Switch Bindings *****

    /// <summary>
    /// Allows binding to the IsToggledProperty as BindIsToggled for the Switch control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Switch.</returns>
    public static Bindings.BindableProperty<bool> BindIsToggled(this Switch _) => Bindings.BindableProperty<bool>.Create(Switch.IsToggledProperty);

    /// <summary>
    /// Allows binding to the OnColorProperty as BindOnColor for the Switch control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Switch.</returns>
    public static Bindings.BindableProperty<Color> BindOnColor(this Switch _) => Bindings.BindableProperty<Color>.Create(Switch.OnColorProperty);

    /// <summary>
    /// Allows binding to the ThumbColorProperty as BindThumbColor for the Switch control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Switch.</returns>
    public static Bindings.BindableProperty<Color> BindThumbColor(this Switch _) => Bindings.BindableProperty<Color>.Create(Switch.ThumbColorProperty);

    // ***** SwitchCell Bindings *****

    /// <summary>
    /// Allows binding to the OnColorProperty as BindOnColor for the SwitchCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwitchCell.</returns>
    public static Bindings.BindableProperty<Color> BindOnColor(this SwitchCell _) => Bindings.BindableProperty<Color>.Create(SwitchCell.OnColorProperty);

    /// <summary>
    /// Allows binding to the OnProperty as BindOn for the SwitchCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwitchCell.</returns>
    public static Bindings.BindableProperty<bool> BindOn(this SwitchCell _) => Bindings.BindableProperty<bool>.Create(SwitchCell.OnProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the SwitchCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SwitchCell.</returns>
    public static Bindings.BindableProperty<string> BindText(this SwitchCell _) => Bindings.BindableProperty<string>.Create(SwitchCell.TextProperty);

    // ***** TabbedPage Bindings *****

    /// <summary>
    /// Allows binding to the BarBackgroundColorProperty as BindBarBackgroundColor for the TabbedPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TabbedPage.</returns>
    public static Bindings.BindableProperty<Color> BindBarBackgroundColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.BarBackgroundColorProperty);

    /// <summary>
    /// Allows binding to the BarBackgroundProperty as BindBarBackground for the TabbedPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TabbedPage.</returns>
    public static Bindings.BindableProperty<Brush> BindBarBackground(this TabbedPage _) => Bindings.BindableProperty<Brush>.Create(TabbedPage.BarBackgroundProperty);

    /// <summary>
    /// Allows binding to the BarTextColorProperty as BindBarTextColor for the TabbedPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TabbedPage.</returns>
    public static Bindings.BindableProperty<Color> BindBarTextColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.BarTextColorProperty);

    /// <summary>
    /// Allows binding to the SelectedTabColorProperty as BindSelectedTabColor for the TabbedPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TabbedPage.</returns>
    public static Bindings.BindableProperty<Color> BindSelectedTabColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.SelectedTabColorProperty);

    /// <summary>
    /// Allows binding to the UnselectedTabColorProperty as BindUnselectedTabColor for the TabbedPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TabbedPage.</returns>
    public static Bindings.BindableProperty<Color> BindUnselectedTabColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.UnselectedTabColorProperty);

    // ***** TableSectionBase Bindings *****

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the TableSectionBase control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TableSectionBase.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this TableSectionBase _) => Bindings.BindableProperty<Color>.Create(TableSectionBase.TextColorProperty);

    /// <summary>
    /// Allows binding to the TitleProperty as BindTitle for the TableSectionBase control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TableSectionBase.</returns>
    public static Bindings.BindableProperty<string> BindTitle(this TableSectionBase _) => Bindings.BindableProperty<string>.Create(TableSectionBase.TitleProperty);

    // ***** TableView Bindings *****

    /// <summary>
    /// Allows binding to the HasUnevenRowsProperty as BindHasUnevenRows for the TableView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TableView.</returns>
    public static Bindings.BindableProperty<bool> BindHasUnevenRows(this TableView _) => Bindings.BindableProperty<bool>.Create(TableView.HasUnevenRowsProperty);

    /// <summary>
    /// Allows binding to the RowHeightProperty as BindRowHeight for the TableView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TableView.</returns>
    public static Bindings.BindableProperty<int> BindRowHeight(this TableView _) => Bindings.BindableProperty<int>.Create(TableView.RowHeightProperty);

    // ***** TapGestureRecognizer Bindings *****

    /// <summary>
    /// Allows binding to the ButtonsProperty as BindButtons for the TapGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TapGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ButtonsMask> BindButtons(this TapGestureRecognizer _) => Bindings.BindableProperty<ButtonsMask>.Create(TapGestureRecognizer.ButtonsProperty);

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the TapGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TapGestureRecognizer.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this TapGestureRecognizer _) => Bindings.BindableProperty<object>.Create(TapGestureRecognizer.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the TapGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TapGestureRecognizer.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this TapGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(TapGestureRecognizer.CommandProperty);

    /// <summary>
    /// Allows binding to the NumberOfTapsRequiredProperty as BindNumberOfTapsRequired for the TapGestureRecognizer control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TapGestureRecognizer.</returns>
    public static Bindings.BindableProperty<int> BindNumberOfTapsRequired(this TapGestureRecognizer _) => Bindings.BindableProperty<int>.Create(TapGestureRecognizer.NumberOfTapsRequiredProperty);

    // ***** TemplatedPage Bindings *****

    /// <summary>
    /// Allows binding to the ControlTemplateProperty as BindControlTemplate for the TemplatedPage control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TemplatedPage.</returns>
    public static Bindings.BindableProperty<ControlTemplate> BindControlTemplate(this TemplatedPage _) => Bindings.BindableProperty<ControlTemplate>.Create(TemplatedPage.ControlTemplateProperty);

    // ***** TemplatedView Bindings *****

    /// <summary>
    /// Allows binding to the ControlTemplateProperty as BindControlTemplate for the TemplatedView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TemplatedView.</returns>
    public static Bindings.BindableProperty<ControlTemplate> BindControlTemplate(this TemplatedView _) => Bindings.BindableProperty<ControlTemplate>.Create(TemplatedView.ControlTemplateProperty);

    // ***** TextCell Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the TextCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextCell.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this TextCell _) => Bindings.BindableProperty<object>.Create(TextCell.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the TextCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextCell.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this TextCell _) => Bindings.BindableProperty<ICommand>.Create(TextCell.CommandProperty);

    /// <summary>
    /// Allows binding to the DetailColorProperty as BindDetailColor for the TextCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextCell.</returns>
    public static Bindings.BindableProperty<Color> BindDetailColor(this TextCell _) => Bindings.BindableProperty<Color>.Create(TextCell.DetailColorProperty);

    /// <summary>
    /// Allows binding to the DetailProperty as BindDetail for the TextCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextCell.</returns>
    public static Bindings.BindableProperty<string> BindDetail(this TextCell _) => Bindings.BindableProperty<string>.Create(TextCell.DetailProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the TextCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextCell.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this TextCell _) => Bindings.BindableProperty<Color>.Create(TextCell.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the TextCell control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextCell.</returns>
    public static Bindings.BindableProperty<string> BindText(this TextCell _) => Bindings.BindableProperty<string>.Create(TextCell.TextProperty);

    // ***** TimePicker Bindings *****

    /// <summary>
    /// Allows binding to the CharacterSpacingProperty as BindCharacterSpacing for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this TimePicker _) => Bindings.BindableProperty<double>.Create(TimePicker.CharacterSpacingProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this TimePicker _) => Bindings.BindableProperty<FontAttributes>.Create(TimePicker.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this TimePicker _) => Bindings.BindableProperty<bool>.Create(TimePicker.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this TimePicker _) => Bindings.BindableProperty<string>.Create(TimePicker.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this TimePicker _) => Bindings.BindableProperty<double>.Create(TimePicker.FontSizeProperty);

    /// <summary>
    /// Allows binding to the FormatProperty as BindFormat for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<string> BindFormat(this TimePicker _) => Bindings.BindableProperty<string>.Create(TimePicker.FormatProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this TimePicker _) => Bindings.BindableProperty<Color>.Create(TimePicker.TextColorProperty);

    /// <summary>
    /// Allows binding to the TimeProperty as BindTime for the TimePicker control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TimePicker.</returns>
    public static Bindings.BindableProperty<TimeSpan> BindTime(this TimePicker _) => Bindings.BindableProperty<TimeSpan>.Create(TimePicker.TimeProperty);

    // ***** Transform Bindings *****

    /// <summary>
    /// Allows binding to the ValueProperty as BindValue for the Transform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Transform.</returns>
    public static Bindings.BindableProperty<Matrix> BindValue(this Transform _) => Bindings.BindableProperty<Matrix>.Create(Transform.ValueProperty);

    // ***** TransformGroup Bindings *****

    /// <summary>
    /// Allows binding to the ChildrenProperty as BindChildren for the TransformGroup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TransformGroup.</returns>
    public static Bindings.BindableProperty<TransformCollection> BindChildren(this TransformGroup _) => Bindings.BindableProperty<TransformCollection>.Create(TransformGroup.ChildrenProperty);

    // ***** TranslateTransform Bindings *****

    /// <summary>
    /// Allows binding to the XProperty as BindX for the TranslateTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TranslateTransform.</returns>
    public static Bindings.BindableProperty<double> BindX(this TranslateTransform _) => Bindings.BindableProperty<double>.Create(TranslateTransform.XProperty);

    /// <summary>
    /// Allows binding to the YProperty as BindY for the TranslateTransform control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TranslateTransform.</returns>
    public static Bindings.BindableProperty<double> BindY(this TranslateTransform _) => Bindings.BindableProperty<double>.Create(TranslateTransform.YProperty);

    // ***** UriImageSource Bindings *****

    /// <summary>
    /// Allows binding to the CacheValidityProperty as BindCacheValidity for the UriImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UriImageSource.</returns>
    public static Bindings.BindableProperty<TimeSpan> BindCacheValidity(this UriImageSource _) => Bindings.BindableProperty<TimeSpan>.Create(UriImageSource.CacheValidityProperty);

    /// <summary>
    /// Allows binding to the CachingEnabledProperty as BindCachingEnabled for the UriImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UriImageSource.</returns>
    public static Bindings.BindableProperty<bool> BindCachingEnabled(this UriImageSource _) => Bindings.BindableProperty<bool>.Create(UriImageSource.CachingEnabledProperty);

    /// <summary>
    /// Allows binding to the UriProperty as BindUri for the UriImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UriImageSource.</returns>
    public static Bindings.BindableProperty<Uri> BindUri(this UriImageSource _) => Bindings.BindableProperty<Uri>.Create(UriImageSource.UriProperty);

    // ***** UrlWebViewSource Bindings *****

    /// <summary>
    /// Allows binding to the UrlProperty as BindUrl for the UrlWebViewSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UrlWebViewSource.</returns>
    public static Bindings.BindableProperty<string> BindUrl(this UrlWebViewSource _) => Bindings.BindableProperty<string>.Create(UrlWebViewSource.UrlProperty);

    // ***** View Bindings *****

    /// <summary>
    /// Allows binding to the HorizontalOptionsProperty as BindHorizontalOptions for the View control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type View.</returns>
    public static Bindings.BindableProperty<LayoutOptions> BindHorizontalOptions(this View _) => Bindings.BindableProperty<LayoutOptions>.Create(View.HorizontalOptionsProperty);

    /// <summary>
    /// Allows binding to the MarginProperty as BindMargin for the View control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type View.</returns>
    public static Bindings.BindableProperty<Thickness> BindMargin(this View _) => Bindings.BindableProperty<Thickness>.Create(View.MarginProperty);

    /// <summary>
    /// Allows binding to the VerticalOptionsProperty as BindVerticalOptions for the View control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type View.</returns>
    public static Bindings.BindableProperty<LayoutOptions> BindVerticalOptions(this View _) => Bindings.BindableProperty<LayoutOptions>.Create(View.VerticalOptionsProperty);

    // ***** VisualElement Bindings *****

    /// <summary>
    /// Allows binding to the AnchorXProperty as BindAnchorX for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindAnchorX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.AnchorXProperty);

    /// <summary>
    /// Allows binding to the AnchorYProperty as BindAnchorY for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindAnchorY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.AnchorYProperty);

    /// <summary>
    /// Allows binding to the BackgroundColorProperty as BindBackgroundColor for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this VisualElement _) => Bindings.BindableProperty<Color>.Create(VisualElement.BackgroundColorProperty);

    /// <summary>
    /// Allows binding to the BackgroundProperty as BindBackground for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<Brush> BindBackground(this VisualElement _) => Bindings.BindableProperty<Brush>.Create(VisualElement.BackgroundProperty);

    /// <summary>
    /// Allows binding to the BehaviorsProperty as BindBehaviors for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<IList<Behavior>> BindBehaviors(this VisualElement _) => Bindings.BindableProperty<IList<Behavior>>.Create(VisualElement.BehaviorsProperty);

    /// <summary>
    /// Allows binding to the ClipProperty as BindClip for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<Geometry> BindClip(this VisualElement _) => Bindings.BindableProperty<Geometry>.Create(VisualElement.ClipProperty);

    /// <summary>
    /// Allows binding to the FlowDirectionProperty as BindFlowDirection for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<FlowDirection> BindFlowDirection(this VisualElement _) => Bindings.BindableProperty<FlowDirection>.Create(VisualElement.FlowDirectionProperty);

    /// <summary>
    /// Allows binding to the HeightProperty as BindHeight for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindHeight(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.HeightProperty);

    /// <summary>
    /// Allows binding to the HeightRequestProperty as BindHeightRequest for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindHeightRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.HeightRequestProperty);

    /// <summary>
    /// Allows binding to the InputTransparentProperty as BindInputTransparent for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<bool> BindInputTransparent(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.InputTransparentProperty);

    /// <summary>
    /// Allows binding to the IsEnabledProperty as BindIsEnabled for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<bool> BindIsEnabled(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.IsEnabledProperty);

    /// <summary>
    /// Allows binding to the IsFocusedProperty as BindIsFocused for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<bool> BindIsFocused(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.IsFocusedProperty);

    /// <summary>
    /// Allows binding to the IsVisibleProperty as BindIsVisible for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<bool> BindIsVisible(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.IsVisibleProperty);

    /// <summary>
    /// Allows binding to the MaximumHeightRequestProperty as BindMaximumHeightRequest for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindMaximumHeightRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MaximumHeightRequestProperty);

    /// <summary>
    /// Allows binding to the MaximumWidthRequestProperty as BindMaximumWidthRequest for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindMaximumWidthRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MaximumWidthRequestProperty);

    /// <summary>
    /// Allows binding to the MinimumHeightRequestProperty as BindMinimumHeightRequest for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindMinimumHeightRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MinimumHeightRequestProperty);

    /// <summary>
    /// Allows binding to the MinimumWidthRequestProperty as BindMinimumWidthRequest for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindMinimumWidthRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MinimumWidthRequestProperty);

    /// <summary>
    /// Allows binding to the NavigationProperty as BindNavigation for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<INavigation> BindNavigation(this VisualElement _) => Bindings.BindableProperty<INavigation>.Create(VisualElement.NavigationProperty);

    /// <summary>
    /// Allows binding to the OpacityProperty as BindOpacity for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindOpacity(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.OpacityProperty);

    /// <summary>
    /// Allows binding to the RotationProperty as BindRotation for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindRotation(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.RotationProperty);

    /// <summary>
    /// Allows binding to the RotationXProperty as BindRotationX for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindRotationX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.RotationXProperty);

    /// <summary>
    /// Allows binding to the RotationYProperty as BindRotationY for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindRotationY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.RotationYProperty);

    /// <summary>
    /// Allows binding to the ScaleProperty as BindScale for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindScale(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.ScaleProperty);

    /// <summary>
    /// Allows binding to the ScaleXProperty as BindScaleX for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindScaleX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.ScaleXProperty);

    /// <summary>
    /// Allows binding to the ScaleYProperty as BindScaleY for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindScaleY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.ScaleYProperty);

    /// <summary>
    /// Allows binding to the ShadowProperty as BindShadow for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<Shadow> BindShadow(this VisualElement _) => Bindings.BindableProperty<Shadow>.Create(VisualElement.ShadowProperty);

    /// <summary>
    /// Allows binding to the StyleProperty as BindStyle for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<Style> BindStyle(this VisualElement _) => Bindings.BindableProperty<Style>.Create(VisualElement.StyleProperty);

    /// <summary>
    /// Allows binding to the TranslationXProperty as BindTranslationX for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindTranslationX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.TranslationXProperty);

    /// <summary>
    /// Allows binding to the TranslationYProperty as BindTranslationY for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindTranslationY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.TranslationYProperty);

    /// <summary>
    /// Allows binding to the TriggersProperty as BindTriggers for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<IList<TriggerBase>> BindTriggers(this VisualElement _) => Bindings.BindableProperty<IList<TriggerBase>>.Create(VisualElement.TriggersProperty);

    /// <summary>
    /// Allows binding to the VisualProperty as BindVisual for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<IVisual> BindVisual(this VisualElement _) => Bindings.BindableProperty<IVisual>.Create(VisualElement.VisualProperty);

    /// <summary>
    /// Allows binding to the WidthProperty as BindWidth for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindWidth(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.WidthProperty);

    /// <summary>
    /// Allows binding to the WidthRequestProperty as BindWidthRequest for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindWidthRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.WidthRequestProperty);

    /// <summary>
    /// Allows binding to the WindowProperty as BindWindow for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<Window> BindWindow(this VisualElement _) => Bindings.BindableProperty<Window>.Create(VisualElement.WindowProperty);

    /// <summary>
    /// Allows binding to the XProperty as BindX for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.XProperty);

    /// <summary>
    /// Allows binding to the YProperty as BindY for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<double> BindY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.YProperty);

    /// <summary>
    /// Allows binding to the ZIndexProperty as BindZIndex for the VisualElement control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type VisualElement.</returns>
    public static Bindings.BindableProperty<int> BindZIndex(this VisualElement _) => Bindings.BindableProperty<int>.Create(VisualElement.ZIndexProperty);

    // ***** WebView Bindings *****

    /// <summary>
    /// Allows binding to the CanGoBackProperty as BindCanGoBack for the WebView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type WebView.</returns>
    public static Bindings.BindableProperty<bool> BindCanGoBack(this WebView _) => Bindings.BindableProperty<bool>.Create(WebView.CanGoBackProperty);

    /// <summary>
    /// Allows binding to the CanGoForwardProperty as BindCanGoForward for the WebView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type WebView.</returns>
    public static Bindings.BindableProperty<bool> BindCanGoForward(this WebView _) => Bindings.BindableProperty<bool>.Create(WebView.CanGoForwardProperty);

    /// <summary>
    /// Allows binding to the CookiesProperty as BindCookies for the WebView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type WebView.</returns>
    public static Bindings.BindableProperty<CookieContainer> BindCookies(this WebView _) => Bindings.BindableProperty<CookieContainer>.Create(WebView.CookiesProperty);

    /// <summary>
    /// Allows binding to the SourceProperty as BindSource for the WebView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type WebView.</returns>
    public static Bindings.BindableProperty<WebViewSource> BindSource(this WebView _) => Bindings.BindableProperty<WebViewSource>.Create(WebView.SourceProperty);

    // ***** Window Bindings *****

    /// <summary>
    /// Allows binding to the FlowDirectionProperty as BindFlowDirection for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<FlowDirection> BindFlowDirection(this Window _) => Bindings.BindableProperty<FlowDirection>.Create(Window.FlowDirectionProperty);

    /// <summary>
    /// Allows binding to the HeightProperty as BindHeight for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindHeight(this Window _) => Bindings.BindableProperty<double>.Create(Window.HeightProperty);

    /// <summary>
    /// Allows binding to the MaximumHeightProperty as BindMaximumHeight for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindMaximumHeight(this Window _) => Bindings.BindableProperty<double>.Create(Window.MaximumHeightProperty);

    /// <summary>
    /// Allows binding to the MaximumWidthProperty as BindMaximumWidth for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindMaximumWidth(this Window _) => Bindings.BindableProperty<double>.Create(Window.MaximumWidthProperty);

    /// <summary>
    /// Allows binding to the MinimumHeightProperty as BindMinimumHeight for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindMinimumHeight(this Window _) => Bindings.BindableProperty<double>.Create(Window.MinimumHeightProperty);

    /// <summary>
    /// Allows binding to the MinimumWidthProperty as BindMinimumWidth for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindMinimumWidth(this Window _) => Bindings.BindableProperty<double>.Create(Window.MinimumWidthProperty);

    /// <summary>
    /// Allows binding to the PageProperty as BindPage for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<Page> BindPage(this Window _) => Bindings.BindableProperty<Page>.Create(Window.PageProperty);

    /// <summary>
    /// Allows binding to the TitleProperty as BindTitle for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<string> BindTitle(this Window _) => Bindings.BindableProperty<string>.Create(Window.TitleProperty);

    /// <summary>
    /// Allows binding to the WidthProperty as BindWidth for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindWidth(this Window _) => Bindings.BindableProperty<double>.Create(Window.WidthProperty);

    /// <summary>
    /// Allows binding to the XProperty as BindX for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindX(this Window _) => Bindings.BindableProperty<double>.Create(Window.XProperty);

    /// <summary>
    /// Allows binding to the YProperty as BindY for the Window control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Window.</returns>
    public static Bindings.BindableProperty<double> BindY(this Window _) => Bindings.BindableProperty<double>.Create(Window.YProperty);
}