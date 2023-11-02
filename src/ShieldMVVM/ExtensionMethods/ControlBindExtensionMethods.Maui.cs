using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Layouts;
using System.Collections;
using System.Collections.ObjectModel;
using System.Net;
using System.Windows.Input;
using static Microsoft.Maui.Controls.Button;
using Path = Microsoft.Maui.Controls.Shapes.Path;

namespace CoreBTS.Maui.ShieldMVVM;

public static partial class ControlBindExtensionMethods
{
    // ClickableControl Bindings
    public static Bindings.BindableProperty<ICommand> BindClick(this AbsoluteLayout _) => new(Controls.ClickableControl<AbsoluteLayout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ActivityIndicator _) => new(Controls.ClickableControl<ActivityIndicator>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Border _) => new(Controls.ClickableControl<Border>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this BoxView _) => new(Controls.ClickableControl<BoxView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this CarouselView _) => new(Controls.ClickableControl<CarouselView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this CheckBox _) => new(Controls.ClickableControl<CheckBox>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this CollectionView _) => new(Controls.ClickableControl<CollectionView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ContentPresenter _) => new(Controls.ClickableControl<ContentPresenter>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ContentView _) => new(Controls.ClickableControl<ContentView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this DatePicker _) => new(Controls.ClickableControl<DatePicker>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Editor _) => new(Controls.ClickableControl<Editor>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Ellipse _) => new(Controls.ClickableControl<Ellipse>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Entry _) => new(Controls.ClickableControl<Entry>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this FlexLayout _) => new(Controls.ClickableControl<FlexLayout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Frame _) => new(Controls.ClickableControl<Frame>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this GestureElement _) => new(Controls.ClickableControl<GestureElement>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this GraphicsView _) => new(Controls.ClickableControl<GraphicsView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Grid _) => new(Controls.ClickableControl<Grid>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this GroupableItemsView _) => new(Controls.ClickableControl<GroupableItemsView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this HorizontalStackLayout _) => new(Controls.ClickableControl<HorizontalStackLayout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Image _) => new(Controls.ClickableControl<Image>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this IndicatorView _) => new(Controls.ClickableControl<IndicatorView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this InputView _) => new(Controls.ClickableControl<InputView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ItemsView _) => new(Controls.ClickableControl<ItemsView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Label _) => new(Controls.ClickableControl<Label>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Layout _) => new(Controls.ClickableControl<Layout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Line _) => new(Controls.ClickableControl<Line>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ListView _) => new(Controls.ClickableControl<ListView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Path _) => new(Controls.ClickableControl<Path>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Picker _) => new(Controls.ClickableControl<Picker>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Polygon _) => new(Controls.ClickableControl<Polygon>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Polyline _) => new(Controls.ClickableControl<Polyline>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ProgressBar _) => new(Controls.ClickableControl<ProgressBar>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this RadioButton _) => new(Controls.ClickableControl<RadioButton>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Rectangle _) => new(Controls.ClickableControl<Rectangle>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => new(Controls.ClickableControl<Microsoft.Maui.Controls.Compatibility.RelativeLayout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ReorderableItemsView _) => new(Controls.ClickableControl<ReorderableItemsView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this RoundRectangle _) => new(Controls.ClickableControl<RoundRectangle>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this ScrollView _) => new(Controls.ClickableControl<ScrollView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this SearchBar _) => new(Controls.ClickableControl<SearchBar>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this SelectableItemsView _) => new(Controls.ClickableControl<SelectableItemsView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Shape _) => new(Controls.ClickableControl<Shape>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Slider _) => new(Controls.ClickableControl<Slider>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Span _) => new(Controls.ClickableControl<Span>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this StackBase _) => new(Controls.ClickableControl<StackBase>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this StackLayout _) => new(Controls.ClickableControl<StackLayout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Stepper _) => new(Controls.ClickableControl<Stepper>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this StructuredItemsView _) => new(Controls.ClickableControl<StructuredItemsView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this SwipeView _) => new(Controls.ClickableControl<SwipeView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this Switch _) => new(Controls.ClickableControl<Switch>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this TableView _) => new(Controls.ClickableControl<TableView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this TemplatedView _) => new(Controls.ClickableControl<TemplatedView>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this TimePicker _) => new(Controls.ClickableControl<TimePicker>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this VerticalStackLayout _) => new(Controls.ClickableControl<VerticalStackLayout>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this View _) => new(Controls.ClickableControl<View>.CommandProperty);
    public static Bindings.BindableProperty<ICommand> BindClick(this WebView _) => new(Controls.ClickableControl<WebView>.CommandProperty);

    public static Bindings.BindableProperty<ICommand> BindClick(this Button _) => new(Button.CommandProperty);

    // AbsoluteLayout Bindings

    public static Bindings.BindableProperty<Rect> BindLayoutBounds(this AbsoluteLayout _) => Bindings.BindableProperty<Rect>.Create(AbsoluteLayout.LayoutBoundsProperty);
    public static Bindings.BindableProperty<AbsoluteLayoutFlags> BindLayoutFlags(this AbsoluteLayout _) => Bindings.BindableProperty<AbsoluteLayoutFlags>.Create(AbsoluteLayout.LayoutFlagsProperty);

    // ActivityIndicator Bindings

    public static Bindings.BindableProperty<Color> BindColor(this ActivityIndicator _) => Bindings.BindableProperty<Color>.Create(ActivityIndicator.ColorProperty);
    public static Bindings.BindableProperty<bool> BindIsRunning(this ActivityIndicator _) => Bindings.BindableProperty<bool>.Create(ActivityIndicator.IsRunningProperty);

    // AdaptiveTrigger Bindings

    public static Bindings.BindableProperty<double> BindMinWindowHeight(this AdaptiveTrigger _) => Bindings.BindableProperty<double>.Create(AdaptiveTrigger.MinWindowHeightProperty);
    public static Bindings.BindableProperty<double> BindMinWindowWidth(this AdaptiveTrigger _) => Bindings.BindableProperty<double>.Create(AdaptiveTrigger.MinWindowWidthProperty);

    // Application Bindings


    // AppLinkEntry Bindings

    public static Bindings.BindableProperty<Uri> BindAppLinkUri(this AppLinkEntry _) => Bindings.BindableProperty<Uri>.Create(AppLinkEntry.AppLinkUriProperty);
    public static Bindings.BindableProperty<string> BindDescription(this AppLinkEntry _) => Bindings.BindableProperty<string>.Create(AppLinkEntry.DescriptionProperty);
    public static Bindings.BindableProperty<bool> BindIsLinkActive(this AppLinkEntry _) => Bindings.BindableProperty<bool>.Create(AppLinkEntry.IsLinkActiveProperty);
    public static Bindings.BindableProperty<ImageSource> BindThumbnail(this AppLinkEntry _) => Bindings.BindableProperty<ImageSource>.Create(AppLinkEntry.ThumbnailProperty);
    public static Bindings.BindableProperty<string> BindTitle(this AppLinkEntry _) => Bindings.BindableProperty<string>.Create(AppLinkEntry.TitleProperty);

    // ArcSegment Bindings

    public static Bindings.BindableProperty<bool> BindIsLargeArc(this ArcSegment _) => Bindings.BindableProperty<bool>.Create(ArcSegment.IsLargeArcProperty);
    public static Bindings.BindableProperty<Point> BindPoint(this ArcSegment _) => Bindings.BindableProperty<Point>.Create(ArcSegment.PointProperty);
    public static Bindings.BindableProperty<double> BindRotationAngle(this ArcSegment _) => Bindings.BindableProperty<double>.Create(ArcSegment.RotationAngleProperty);
    public static Bindings.BindableProperty<Size> BindSize(this ArcSegment _) => Bindings.BindableProperty<Size>.Create(ArcSegment.SizeProperty);
    public static Bindings.BindableProperty<SweepDirection> BindSweepDirection(this ArcSegment _) => Bindings.BindableProperty<SweepDirection>.Create(ArcSegment.SweepDirectionProperty);

    // BackButtonBehavior Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this BackButtonBehavior _) => Bindings.BindableProperty<object>.Create(BackButtonBehavior.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this BackButtonBehavior _) => Bindings.BindableProperty<ICommand>.Create(BackButtonBehavior.CommandProperty);
    public static Bindings.BindableProperty<ImageSource> BindIconOverride(this BackButtonBehavior _) => Bindings.BindableProperty<ImageSource>.Create(BackButtonBehavior.IconOverrideProperty);
    public static Bindings.BindableProperty<bool> BindIsEnabled(this BackButtonBehavior _) => Bindings.BindableProperty<bool>.Create(BackButtonBehavior.IsEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsVisible(this BackButtonBehavior _) => Bindings.BindableProperty<bool>.Create(BackButtonBehavior.IsVisibleProperty);
    public static Bindings.BindableProperty<string> BindTextOverride(this BackButtonBehavior _) => Bindings.BindableProperty<string>.Create(BackButtonBehavior.TextOverrideProperty);

    // BaseShellItem Bindings

    public static Bindings.BindableProperty<ImageSource> BindFlyoutIcon(this BaseShellItem _) => Bindings.BindableProperty<ImageSource>.Create(BaseShellItem.FlyoutIconProperty);
    public static Bindings.BindableProperty<ImageSource> BindIcon(this BaseShellItem _) => Bindings.BindableProperty<ImageSource>.Create(BaseShellItem.IconProperty);
    public static Bindings.BindableProperty<bool> BindIsChecked(this BaseShellItem _) => Bindings.BindableProperty<bool>.Create(BaseShellItem.IsCheckedProperty);
    public static Bindings.BindableProperty<bool> BindIsEnabled(this BaseShellItem _) => Bindings.BindableProperty<bool>.Create(BaseShellItem.IsEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsVisible(this BaseShellItem _) => Bindings.BindableProperty<bool>.Create(BaseShellItem.IsVisibleProperty);
    public static Bindings.BindableProperty<string> BindTitle(this BaseShellItem _) => Bindings.BindableProperty<string>.Create(BaseShellItem.TitleProperty);
    public static Bindings.BindableProperty<Window> BindWindow(this BaseShellItem _) => Bindings.BindableProperty<Window>.Create(BaseShellItem.WindowProperty);

    // BezierSegment Bindings

    public static Bindings.BindableProperty<Point> BindPoint1(this BezierSegment _) => Bindings.BindableProperty<Point>.Create(BezierSegment.Point1Property);
    public static Bindings.BindableProperty<Point> BindPoint2(this BezierSegment _) => Bindings.BindableProperty<Point>.Create(BezierSegment.Point2Property);
    public static Bindings.BindableProperty<Point> BindPoint3(this BezierSegment _) => Bindings.BindableProperty<Point>.Create(BezierSegment.Point3Property);

    // BindableObject Bindings

    public static Bindings.BindableProperty<object> BindBindingContext(this BindableObject _) => Bindings.BindableProperty<object>.Create(BindableObject.BindingContextProperty);

    // Border Bindings

    public static Bindings.BindableProperty<View> BindContent(this Border _) => Bindings.BindableProperty<View>.Create(Border.ContentProperty);
    public static Bindings.BindableProperty<Thickness> BindPadding(this Border _) => Bindings.BindableProperty<Thickness>.Create(Border.PaddingProperty);
    public static Bindings.BindableProperty<DoubleCollection> BindStrokeDashArray(this Border _) => Bindings.BindableProperty<DoubleCollection>.Create(Border.StrokeDashArrayProperty);
    public static Bindings.BindableProperty<double> BindStrokeDashOffset(this Border _) => Bindings.BindableProperty<double>.Create(Border.StrokeDashOffsetProperty);
    public static Bindings.BindableProperty<PenLineCap> BindStrokeLineCap(this Border _) => Bindings.BindableProperty<PenLineCap>.Create(Border.StrokeLineCapProperty);
    public static Bindings.BindableProperty<PenLineJoin> BindStrokeLineJoin(this Border _) => Bindings.BindableProperty<PenLineJoin>.Create(Border.StrokeLineJoinProperty);
    public static Bindings.BindableProperty<double> BindStrokeMiterLimit(this Border _) => Bindings.BindableProperty<double>.Create(Border.StrokeMiterLimitProperty);
    public static Bindings.BindableProperty<Brush> BindStroke(this Border _) => Bindings.BindableProperty<Brush>.Create(Border.StrokeProperty);
    public static Bindings.BindableProperty<IShape> BindStrokeShape(this Border _) => Bindings.BindableProperty<IShape>.Create(Border.StrokeShapeProperty);
    public static Bindings.BindableProperty<double> BindStrokeThickness(this Border _) => Bindings.BindableProperty<double>.Create(Border.StrokeThicknessProperty);

    // BoxView Bindings

    public static Bindings.BindableProperty<Color> BindColor(this BoxView _) => Bindings.BindableProperty<Color>.Create(BoxView.ColorProperty);
    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this BoxView _) => Bindings.BindableProperty<CornerRadius>.Create(BoxView.CornerRadiusProperty);

    // Button Bindings

    public static Bindings.BindableProperty<Color> BindBorderColor(this Button _) => Bindings.BindableProperty<Color>.Create(Button.BorderColorProperty);
    public static Bindings.BindableProperty<double> BindBorderWidth(this Button _) => Bindings.BindableProperty<double>.Create(Button.BorderWidthProperty);
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Button _) => Bindings.BindableProperty<double>.Create(Button.CharacterSpacingProperty);
    public static Bindings.BindableProperty<object> BindCommandParameter(this Button _) => Bindings.BindableProperty<object>.Create(Button.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this Button _) => Bindings.BindableProperty<ICommand>.Create(Button.CommandProperty);
    public static Bindings.BindableProperty<ButtonContentLayout> BindContentLayout(this Button _) => Bindings.BindableProperty<ButtonContentLayout>.Create(Button.ContentLayoutProperty);
    public static Bindings.BindableProperty<int> BindCornerRadius(this Button _) => Bindings.BindableProperty<int>.Create(Button.CornerRadiusProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Button _) => Bindings.BindableProperty<FontAttributes>.Create(Button.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Button _) => Bindings.BindableProperty<bool>.Create(Button.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this Button _) => Bindings.BindableProperty<string>.Create(Button.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this Button _) => Bindings.BindableProperty<double>.Create(Button.FontSizeProperty);
    public static Bindings.BindableProperty<ImageSource> BindImageSource(this Button _) => Bindings.BindableProperty<ImageSource>.Create(Button.ImageSourceProperty);
    public static Bindings.BindableProperty<bool> BindIsPressed(this Button _) => Bindings.BindableProperty<bool>.Create(Button.IsPressedProperty);
    public static Bindings.BindableProperty<LineBreakMode> BindLineBreakMode(this Button _) => Bindings.BindableProperty<LineBreakMode>.Create(Button.LineBreakModeProperty);
    public static Bindings.BindableProperty<Thickness> BindPadding(this Button _) => Bindings.BindableProperty<Thickness>.Create(Button.PaddingProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this Button _) => Bindings.BindableProperty<Color>.Create(Button.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this Button _) => Bindings.BindableProperty<string>.Create(Button.TextProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this Button _) => Bindings.BindableProperty<TextTransform>.Create(Button.TextTransformProperty);

    // CarouselView Bindings

    public static Bindings.BindableProperty<object> BindCurrentItemChangedCommandParameter(this CarouselView _) => Bindings.BindableProperty<object>.Create(CarouselView.CurrentItemChangedCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCurrentItemChangedCommand(this CarouselView _) => Bindings.BindableProperty<ICommand>.Create(CarouselView.CurrentItemChangedCommandProperty);
    public static Bindings.BindableProperty<object> BindCurrentItem(this CarouselView _) => Bindings.BindableProperty<object>.Create(CarouselView.CurrentItemProperty);
    public static Bindings.BindableProperty<bool> BindIsBounceEnabled(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsBounceEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsDragging(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsDraggingProperty);
    public static Bindings.BindableProperty<bool> BindIsScrollAnimated(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsScrollAnimatedProperty);
    public static Bindings.BindableProperty<bool> BindIsSwipeEnabled(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.IsSwipeEnabledProperty);
    public static Bindings.BindableProperty<LinearItemsLayout> BindItemsLayout(this CarouselView _) => Bindings.BindableProperty<LinearItemsLayout>.Create(CarouselView.ItemsLayoutProperty);
    public static Bindings.BindableProperty<bool> BindLoop(this CarouselView _) => Bindings.BindableProperty<bool>.Create(CarouselView.LoopProperty);
    public static Bindings.BindableProperty<Thickness> BindPeekAreaInsets(this CarouselView _) => Bindings.BindableProperty<Thickness>.Create(CarouselView.PeekAreaInsetsProperty);
    public static Bindings.BindableProperty<object> BindPositionChangedCommandParameter(this CarouselView _) => Bindings.BindableProperty<object>.Create(CarouselView.PositionChangedCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindPositionChangedCommand(this CarouselView _) => Bindings.BindableProperty<ICommand>.Create(CarouselView.PositionChangedCommandProperty);
    public static Bindings.BindableProperty<int> BindPosition(this CarouselView _) => Bindings.BindableProperty<int>.Create(CarouselView.PositionProperty);
    public static Bindings.BindableProperty<ObservableCollection<View>> BindVisibleViews(this CarouselView _) => Bindings.BindableProperty<ObservableCollection<View>>.Create(CarouselView.VisibleViewsProperty);

    // Cell Bindings

    public static Bindings.BindableProperty<bool> BindIsEnabled(this Cell _) => Bindings.BindableProperty<bool>.Create(Cell.IsEnabledProperty);

    // CheckBox Bindings

    public static Bindings.BindableProperty<Color> BindColor(this CheckBox _) => Bindings.BindableProperty<Color>.Create(CheckBox.ColorProperty);
    public static Bindings.BindableProperty<bool> BindIsChecked(this CheckBox _) => Bindings.BindableProperty<bool>.Create(CheckBox.IsCheckedProperty);

    // ClickGestureRecognizer Bindings

    public static Bindings.BindableProperty<ButtonsMask> BindButtons(this ClickGestureRecognizer _) => Bindings.BindableProperty<ButtonsMask>.Create(ClickGestureRecognizer.ButtonsProperty);
    public static Bindings.BindableProperty<object> BindCommandParameter(this ClickGestureRecognizer _) => Bindings.BindableProperty<object>.Create(ClickGestureRecognizer.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this ClickGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(ClickGestureRecognizer.CommandProperty);
    public static Bindings.BindableProperty<int> BindNumberOfClicksRequired(this ClickGestureRecognizer _) => Bindings.BindableProperty<int>.Create(ClickGestureRecognizer.NumberOfClicksRequiredProperty);

    // ColumnDefinition Bindings

    public static Bindings.BindableProperty<GridLength> BindWidth(this ColumnDefinition _) => Bindings.BindableProperty<GridLength>.Create(ColumnDefinition.WidthProperty);

    // CompareStateTrigger Bindings

    public static Bindings.BindableProperty<object> Bind(this CompareStateTrigger _) => Bindings.BindableProperty<object>.Create(CompareStateTrigger.PropertyProperty);
    public static Bindings.BindableProperty<object> BindValue(this CompareStateTrigger _) => Bindings.BindableProperty<object>.Create(CompareStateTrigger.ValueProperty);

    // CompositeTransform Bindings

    public static Bindings.BindableProperty<double> BindCenterX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.CenterXProperty);
    public static Bindings.BindableProperty<double> BindCenterY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.CenterYProperty);
    public static Bindings.BindableProperty<double> BindRotation(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.RotationProperty);
    public static Bindings.BindableProperty<double> BindScaleX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.ScaleXProperty);
    public static Bindings.BindableProperty<double> BindScaleY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.ScaleYProperty);
    public static Bindings.BindableProperty<double> BindSkewX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.SkewXProperty);
    public static Bindings.BindableProperty<double> BindSkewY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.SkewYProperty);
    public static Bindings.BindableProperty<double> BindTranslateX(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.TranslateXProperty);
    public static Bindings.BindableProperty<double> BindTranslateY(this CompositeTransform _) => Bindings.BindableProperty<double>.Create(CompositeTransform.TranslateYProperty);

    // ContentPage Bindings

    public static Bindings.BindableProperty<View> BindContent(this ContentPage _) => Bindings.BindableProperty<View>.Create(ContentPage.ContentProperty);

    // ContentPresenter Bindings

    public static Bindings.BindableProperty<View> BindContent(this ContentPresenter _) => Bindings.BindableProperty<View>.Create(ContentPresenter.ContentProperty);

    // ContentView Bindings

    public static Bindings.BindableProperty<View> BindContent(this ContentView _) => Bindings.BindableProperty<View>.Create(ContentView.ContentProperty);

    // DatePicker Bindings

    public static Bindings.BindableProperty<double> BindCharacterSpacing(this DatePicker _) => Bindings.BindableProperty<double>.Create(DatePicker.CharacterSpacingProperty);
    public static Bindings.BindableProperty<DateTime> BindDate(this DatePicker _) => Bindings.BindableProperty<DateTime>.Create(DatePicker.DateProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this DatePicker _) => Bindings.BindableProperty<FontAttributes>.Create(DatePicker.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this DatePicker _) => Bindings.BindableProperty<bool>.Create(DatePicker.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this DatePicker _) => Bindings.BindableProperty<string>.Create(DatePicker.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this DatePicker _) => Bindings.BindableProperty<double>.Create(DatePicker.FontSizeProperty);
    public static Bindings.BindableProperty<string> BindFormat(this DatePicker _) => Bindings.BindableProperty<string>.Create(DatePicker.FormatProperty);
    public static Bindings.BindableProperty<DateTime> BindMaximumDate(this DatePicker _) => Bindings.BindableProperty<DateTime>.Create(DatePicker.MaximumDateProperty);
    public static Bindings.BindableProperty<DateTime> BindMinimumDate(this DatePicker _) => Bindings.BindableProperty<DateTime>.Create(DatePicker.MinimumDateProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this DatePicker _) => Bindings.BindableProperty<Color>.Create(DatePicker.TextColorProperty);

    // DeviceStateTrigger Bindings

    public static Bindings.BindableProperty<string> BindDevice(this DeviceStateTrigger _) => Bindings.BindableProperty<string>.Create(DeviceStateTrigger.DeviceProperty);

    // DragGestureRecognizer Bindings

    public static Bindings.BindableProperty<bool> BindCanDrag(this DragGestureRecognizer _) => Bindings.BindableProperty<bool>.Create(DragGestureRecognizer.CanDragProperty);
    public static Bindings.BindableProperty<object> BindDragStartingCommandParameter(this DragGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DragGestureRecognizer.DragStartingCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindDragStartingCommand(this DragGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DragGestureRecognizer.DragStartingCommandProperty);
    public static Bindings.BindableProperty<object> BindDropCompletedCommandParameter(this DragGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DragGestureRecognizer.DropCompletedCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindDropCompletedCommand(this DragGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DragGestureRecognizer.DropCompletedCommandProperty);

    // DropGestureRecognizer Bindings

    public static Bindings.BindableProperty<bool> BindAllowDrop(this DropGestureRecognizer _) => Bindings.BindableProperty<bool>.Create(DropGestureRecognizer.AllowDropProperty);
    public static Bindings.BindableProperty<object> BindDragLeaveCommandParameter(this DropGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DropGestureRecognizer.DragLeaveCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindDragLeaveCommand(this DropGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DropGestureRecognizer.DragLeaveCommandProperty);
    public static Bindings.BindableProperty<object> BindDragOverCommandParameter(this DropGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DropGestureRecognizer.DragOverCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindDragOverCommand(this DropGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DropGestureRecognizer.DragOverCommandProperty);
    public static Bindings.BindableProperty<object> BindDropCommandParameter(this DropGestureRecognizer _) => Bindings.BindableProperty<object>.Create(DropGestureRecognizer.DropCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindDropCommand(this DropGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(DropGestureRecognizer.DropCommandProperty);

    // Editor Bindings

    public static Bindings.BindableProperty<EditorAutoSizeOption> BindAutoSize(this Editor _) => Bindings.BindableProperty<EditorAutoSizeOption>.Create(Editor.AutoSizeProperty);
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Editor _) => Bindings.BindableProperty<double>.Create(Editor.CharacterSpacingProperty);
    public static Bindings.BindableProperty<int> BindCursorPosition(this Editor _) => Bindings.BindableProperty<int>.Create(Editor.CursorPositionProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Editor _) => Bindings.BindableProperty<FontAttributes>.Create(Editor.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Editor _) => Bindings.BindableProperty<bool>.Create(Editor.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this Editor _) => Bindings.BindableProperty<string>.Create(Editor.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this Editor _) => Bindings.BindableProperty<double>.Create(Editor.FontSizeProperty);
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Editor _) => Bindings.BindableProperty<TextAlignment>.Create(Editor.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<bool> BindIsTextPredictionEnabled(this Editor _) => Bindings.BindableProperty<bool>.Create(Editor.IsTextPredictionEnabledProperty);
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this Editor _) => Bindings.BindableProperty<Color>.Create(Editor.PlaceholderColorProperty);
    public static Bindings.BindableProperty<string> BindPlaceholder(this Editor _) => Bindings.BindableProperty<string>.Create(Editor.PlaceholderProperty);
    public static Bindings.BindableProperty<int> BindSelectionLength(this Editor _) => Bindings.BindableProperty<int>.Create(Editor.SelectionLengthProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this Editor _) => Bindings.BindableProperty<Color>.Create(Editor.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this Editor _) => Bindings.BindableProperty<string>.Create(Editor.TextProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Editor _) => Bindings.BindableProperty<TextAlignment>.Create(Editor.VerticalTextAlignmentProperty);

    // Element Bindings

    public static Bindings.BindableProperty<string> BindAutomationId(this Element _) => Bindings.BindableProperty<string>.Create(Element.AutomationIdProperty);
    public static Bindings.BindableProperty<string> BindClassId(this Element _) => Bindings.BindableProperty<string>.Create(Element.ClassIdProperty);

    // EllipseGeometry Bindings

    public static Bindings.BindableProperty<Point> BindCenter(this EllipseGeometry _) => Bindings.BindableProperty<Point>.Create(EllipseGeometry.CenterProperty);
    public static Bindings.BindableProperty<double> BindRadiusX(this EllipseGeometry _) => Bindings.BindableProperty<double>.Create(EllipseGeometry.RadiusXProperty);
    public static Bindings.BindableProperty<double> BindRadiusY(this EllipseGeometry _) => Bindings.BindableProperty<double>.Create(EllipseGeometry.RadiusYProperty);

    // Entry Bindings

    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Entry _) => Bindings.BindableProperty<double>.Create(Entry.CharacterSpacingProperty);
    public static Bindings.BindableProperty<ClearButtonVisibility> BindClearButtonVisibility(this Entry _) => Bindings.BindableProperty<ClearButtonVisibility>.Create(Entry.ClearButtonVisibilityProperty);
    public static Bindings.BindableProperty<int> BindCursorPosition(this Entry _) => Bindings.BindableProperty<int>.Create(Entry.CursorPositionProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Entry _) => Bindings.BindableProperty<FontAttributes>.Create(Entry.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Entry _) => Bindings.BindableProperty<bool>.Create(Entry.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this Entry _) => Bindings.BindableProperty<string>.Create(Entry.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this Entry _) => Bindings.BindableProperty<double>.Create(Entry.FontSizeProperty);
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Entry _) => Bindings.BindableProperty<TextAlignment>.Create(Entry.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<bool> BindIsPassword(this Entry _) => Bindings.BindableProperty<bool>.Create(Entry.IsPasswordProperty);
    public static Bindings.BindableProperty<bool> BindIsTextPredictionEnabled(this Entry _) => Bindings.BindableProperty<bool>.Create(Entry.IsTextPredictionEnabledProperty);
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this Entry _) => Bindings.BindableProperty<Keyboard>.Create(Entry.KeyboardProperty);
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this Entry _) => Bindings.BindableProperty<Color>.Create(Entry.PlaceholderColorProperty);
    public static Bindings.BindableProperty<string> BindPlaceholder(this Entry _) => Bindings.BindableProperty<string>.Create(Entry.PlaceholderProperty);
    public static Bindings.BindableProperty<object> BindReturnCommandParameter(this Entry _) => Bindings.BindableProperty<object>.Create(Entry.ReturnCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindReturnCommand(this Entry _) => Bindings.BindableProperty<ICommand>.Create(Entry.ReturnCommandProperty);
    public static Bindings.BindableProperty<ReturnType> BindReturnType(this Entry _) => Bindings.BindableProperty<ReturnType>.Create(Entry.ReturnTypeProperty);
    public static Bindings.BindableProperty<int> BindSelectionLength(this Entry _) => Bindings.BindableProperty<int>.Create(Entry.SelectionLengthProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this Entry _) => Bindings.BindableProperty<Color>.Create(Entry.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this Entry _) => Bindings.BindableProperty<string>.Create(Entry.TextProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Entry _) => Bindings.BindableProperty<TextAlignment>.Create(Entry.VerticalTextAlignmentProperty);

    // EntryCell Bindings

    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this EntryCell _) => Bindings.BindableProperty<TextAlignment>.Create(EntryCell.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this EntryCell _) => Bindings.BindableProperty<Keyboard>.Create(EntryCell.KeyboardProperty);
    public static Bindings.BindableProperty<Color> BindLabelColor(this EntryCell _) => Bindings.BindableProperty<Color>.Create(EntryCell.LabelColorProperty);
    public static Bindings.BindableProperty<string> BindLabel(this EntryCell _) => Bindings.BindableProperty<string>.Create(EntryCell.LabelProperty);
    public static Bindings.BindableProperty<string> BindPlaceholder(this EntryCell _) => Bindings.BindableProperty<string>.Create(EntryCell.PlaceholderProperty);
    public static Bindings.BindableProperty<string> BindText(this EntryCell _) => Bindings.BindableProperty<string>.Create(EntryCell.TextProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this EntryCell _) => Bindings.BindableProperty<TextAlignment>.Create(EntryCell.VerticalTextAlignmentProperty);

    // FileImageSource Bindings

    public static Bindings.BindableProperty<string> BindFile(this FileImageSource _) => Bindings.BindableProperty<string>.Create(FileImageSource.FileProperty);

    // FlexLayout Bindings

    public static Bindings.BindableProperty<FlexAlignContent> BindAlignContent(this FlexLayout _) => Bindings.BindableProperty<FlexAlignContent>.Create(FlexLayout.AlignContentProperty);
    public static Bindings.BindableProperty<FlexAlignItems> BindAlignItems(this FlexLayout _) => Bindings.BindableProperty<FlexAlignItems>.Create(FlexLayout.AlignItemsProperty);
    public static Bindings.BindableProperty<FlexAlignSelf> BindAlignSelf(this FlexLayout _) => Bindings.BindableProperty<FlexAlignSelf>.Create(FlexLayout.AlignSelfProperty);
    public static Bindings.BindableProperty<FlexBasis> BindBasis(this FlexLayout _) => Bindings.BindableProperty<FlexBasis>.Create(FlexLayout.BasisProperty);
    public static Bindings.BindableProperty<FlexDirection> BindDirection(this FlexLayout _) => Bindings.BindableProperty<FlexDirection>.Create(FlexLayout.DirectionProperty);
    public static Bindings.BindableProperty<float> BindGrow(this FlexLayout _) => Bindings.BindableProperty<float>.Create(FlexLayout.GrowProperty);
    public static Bindings.BindableProperty<FlexJustify> BindJustifyContent(this FlexLayout _) => Bindings.BindableProperty<FlexJustify>.Create(FlexLayout.JustifyContentProperty);
    public static Bindings.BindableProperty<int> BindOrder(this FlexLayout _) => Bindings.BindableProperty<int>.Create(FlexLayout.OrderProperty);
    public static Bindings.BindableProperty<FlexPosition> BindPosition(this FlexLayout _) => Bindings.BindableProperty<FlexPosition>.Create(FlexLayout.PositionProperty);
    public static Bindings.BindableProperty<float> BindShrink(this FlexLayout _) => Bindings.BindableProperty<float>.Create(FlexLayout.ShrinkProperty);
    public static Bindings.BindableProperty<FlexWrap> BindWrap(this FlexLayout _) => Bindings.BindableProperty<FlexWrap>.Create(FlexLayout.WrapProperty);

    // FlyoutItem Bindings

    public static Bindings.BindableProperty<bool> BindIsVisible(this FlyoutItem _) => Bindings.BindableProperty<bool>.Create(FlyoutItem.IsVisibleProperty);

    // FlyoutPage Bindings

    public static Bindings.BindableProperty<FlyoutLayoutBehavior> BindFlyoutLayoutBehavior(this FlyoutPage _) => Bindings.BindableProperty<FlyoutLayoutBehavior>.Create(FlyoutPage.FlyoutLayoutBehaviorProperty);
    public static Bindings.BindableProperty<bool> BindIsGestureEnabled(this FlyoutPage _) => Bindings.BindableProperty<bool>.Create(FlyoutPage.IsGestureEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsPresented(this FlyoutPage _) => Bindings.BindableProperty<bool>.Create(FlyoutPage.IsPresentedProperty);

    // FontImageSource Bindings

    public static Bindings.BindableProperty<Color> BindColor(this FontImageSource _) => Bindings.BindableProperty<Color>.Create(FontImageSource.ColorProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this FontImageSource _) => Bindings.BindableProperty<bool>.Create(FontImageSource.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this FontImageSource _) => Bindings.BindableProperty<string>.Create(FontImageSource.FontFamilyProperty);
    public static Bindings.BindableProperty<string> BindGlyph(this FontImageSource _) => Bindings.BindableProperty<string>.Create(FontImageSource.GlyphProperty);
    public static Bindings.BindableProperty<double> BindSize(this FontImageSource _) => Bindings.BindableProperty<double>.Create(FontImageSource.SizeProperty);

    // Frame Bindings

    public static Bindings.BindableProperty<Color> BindBorderColor(this Frame _) => Bindings.BindableProperty<Color>.Create(Frame.BorderColorProperty);
    public static Bindings.BindableProperty<float> BindCornerRadius(this Frame _) => Bindings.BindableProperty<float>.Create(Frame.CornerRadiusProperty);
    public static Bindings.BindableProperty<bool> BindHasShadow(this Frame _) => Bindings.BindableProperty<bool>.Create(Frame.HasShadowProperty);

    // GeometryGroup Bindings

    public static Bindings.BindableProperty<GeometryCollection> BindChildren(this GeometryGroup _) => Bindings.BindableProperty<GeometryCollection>.Create(GeometryGroup.ChildrenProperty);
    public static Bindings.BindableProperty<FillRule> BindFillRule(this GeometryGroup _) => Bindings.BindableProperty<FillRule>.Create(GeometryGroup.FillRuleProperty);

    // GradientBrush Bindings

    public static Bindings.BindableProperty<GradientStopCollection> BindGradientStops(this GradientBrush _) => Bindings.BindableProperty<GradientStopCollection>.Create(GradientBrush.GradientStopsProperty);

    // GradientStop Bindings

    public static Bindings.BindableProperty<Color> BindColor(this GradientStop _) => Bindings.BindableProperty<Color>.Create(GradientStop.ColorProperty);
    public static Bindings.BindableProperty<float> BindOffset(this GradientStop _) => Bindings.BindableProperty<float>.Create(GradientStop.OffsetProperty);

    // GraphicsView Bindings

    public static Bindings.BindableProperty<IDrawable> BindDrawable(this GraphicsView _) => Bindings.BindableProperty<IDrawable>.Create(GraphicsView.DrawableProperty);

    // Grid Bindings

    public static Bindings.BindableProperty<ColumnDefinitionCollection> BindColumnDefinitions(this Grid _) => Bindings.BindableProperty<ColumnDefinitionCollection>.Create(Grid.ColumnDefinitionsProperty);
    public static Bindings.BindableProperty<int> BindColumn(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.ColumnProperty);
    public static Bindings.BindableProperty<double> BindColumnSpacing(this Grid _) => Bindings.BindableProperty<double>.Create(Grid.ColumnSpacingProperty);
    public static Bindings.BindableProperty<int> BindColumnSpan(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.ColumnSpanProperty);
    public static Bindings.BindableProperty<RowDefinitionCollection> BindRowDefinitions(this Grid _) => Bindings.BindableProperty<RowDefinitionCollection>.Create(Grid.RowDefinitionsProperty);
    public static Bindings.BindableProperty<int> BindRow(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.RowProperty);
    public static Bindings.BindableProperty<double> BindRowSpacing(this Grid _) => Bindings.BindableProperty<double>.Create(Grid.RowSpacingProperty);
    public static Bindings.BindableProperty<int> BindRowSpan(this Grid _) => Bindings.BindableProperty<int>.Create(Grid.RowSpanProperty);

    // GridItemsLayout Bindings

    public static Bindings.BindableProperty<double> BindHorizontalItemSpacing(this GridItemsLayout _) => Bindings.BindableProperty<double>.Create(GridItemsLayout.HorizontalItemSpacingProperty);
    public static Bindings.BindableProperty<int> BindSpan(this GridItemsLayout _) => Bindings.BindableProperty<int>.Create(GridItemsLayout.SpanProperty);
    public static Bindings.BindableProperty<double> BindVerticalItemSpacing(this GridItemsLayout _) => Bindings.BindableProperty<double>.Create(GridItemsLayout.VerticalItemSpacingProperty);

    // GroupableItemsView Bindings

    public static Bindings.BindableProperty<DataTemplate> BindGroupFooterTemplate(this GroupableItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(GroupableItemsView.GroupFooterTemplateProperty);
    public static Bindings.BindableProperty<DataTemplate> BindGroupHeaderTemplate(this GroupableItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(GroupableItemsView.GroupHeaderTemplateProperty);
    public static Bindings.BindableProperty<bool> BindIsGrouped(this GroupableItemsView _) => Bindings.BindableProperty<bool>.Create(GroupableItemsView.IsGroupedProperty);

    // HtmlWebViewSource Bindings

    public static Bindings.BindableProperty<string> BindBaseUrl(this HtmlWebViewSource _) => Bindings.BindableProperty<string>.Create(HtmlWebViewSource.BaseUrlProperty);
    public static Bindings.BindableProperty<string> BindHtml(this HtmlWebViewSource _) => Bindings.BindableProperty<string>.Create(HtmlWebViewSource.HtmlProperty);

    // Image Bindings

    public static Bindings.BindableProperty<Aspect> BindAspect(this Image _) => Bindings.BindableProperty<Aspect>.Create(Image.AspectProperty);
    public static Bindings.BindableProperty<bool> BindIsAnimationPlaying(this Image _) => Bindings.BindableProperty<bool>.Create(Image.IsAnimationPlayingProperty);
    public static Bindings.BindableProperty<bool> BindIsLoading(this Image _) => Bindings.BindableProperty<bool>.Create(Image.IsLoadingProperty);
    public static Bindings.BindableProperty<bool> BindIsOpaque(this Image _) => Bindings.BindableProperty<bool>.Create(Image.IsOpaqueProperty);
    public static Bindings.BindableProperty<ImageSource> BindSource(this Image _) => Bindings.BindableProperty<ImageSource>.Create(Image.SourceProperty);

    // ImageButton Bindings

    public static Bindings.BindableProperty<Aspect> BindAspect(this ImageButton _) => Bindings.BindableProperty<Aspect>.Create(ImageButton.AspectProperty);
    public static Bindings.BindableProperty<Color> BindBorderColor(this ImageButton _) => Bindings.BindableProperty<Color>.Create(ImageButton.BorderColorProperty);
    public static Bindings.BindableProperty<double> BindBorderWidth(this ImageButton _) => Bindings.BindableProperty<double>.Create(ImageButton.BorderWidthProperty);
    public static Bindings.BindableProperty<object> BindCommandParameter(this ImageButton _) => Bindings.BindableProperty<object>.Create(ImageButton.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this ImageButton _) => Bindings.BindableProperty<ICommand>.Create(ImageButton.CommandProperty);
    public static Bindings.BindableProperty<int> BindCornerRadius(this ImageButton _) => Bindings.BindableProperty<int>.Create(ImageButton.CornerRadiusProperty);
    public static Bindings.BindableProperty<bool> BindIsLoading(this ImageButton _) => Bindings.BindableProperty<bool>.Create(ImageButton.IsLoadingProperty);
    public static Bindings.BindableProperty<bool> BindIsOpaque(this ImageButton _) => Bindings.BindableProperty<bool>.Create(ImageButton.IsOpaqueProperty);
    public static Bindings.BindableProperty<bool> BindIsPressed(this ImageButton _) => Bindings.BindableProperty<bool>.Create(ImageButton.IsPressedProperty);
    public static Bindings.BindableProperty<Thickness> BindPadding(this ImageButton _) => Bindings.BindableProperty<Thickness>.Create(ImageButton.PaddingProperty);
    public static Bindings.BindableProperty<ImageSource> BindSource(this ImageButton _) => Bindings.BindableProperty<ImageSource>.Create(ImageButton.SourceProperty);

    // ImageCell Bindings

    public static Bindings.BindableProperty<ImageSource> BindImageSource(this ImageCell _) => Bindings.BindableProperty<ImageSource>.Create(ImageCell.ImageSourceProperty);

    // IndicatorView Bindings

    public static Bindings.BindableProperty<int> BindCount(this IndicatorView _) => Bindings.BindableProperty<int>.Create(IndicatorView.CountProperty);
    public static Bindings.BindableProperty<bool> BindHideSingle(this IndicatorView _) => Bindings.BindableProperty<bool>.Create(IndicatorView.HideSingleProperty);
    public static Bindings.BindableProperty<Color> BindIndicatorColor(this IndicatorView _) => Bindings.BindableProperty<Color>.Create(IndicatorView.IndicatorColorProperty);
    public static Bindings.BindableProperty<double> BindIndicatorSize(this IndicatorView _) => Bindings.BindableProperty<double>.Create(IndicatorView.IndicatorSizeProperty);
    public static Bindings.BindableProperty<IndicatorShape> BindIndicatorsShape(this IndicatorView _) => Bindings.BindableProperty<IndicatorShape>.Create(IndicatorView.IndicatorsShapeProperty);
    public static Bindings.BindableProperty<DataTemplate> BindIndicatorTemplate(this IndicatorView _) => Bindings.BindableProperty<DataTemplate>.Create(IndicatorView.IndicatorTemplateProperty);
    public static Bindings.BindableProperty<IEnumerable> BindItemsSource(this IndicatorView _) => Bindings.BindableProperty<IEnumerable>.Create(IndicatorView.ItemsSourceProperty);
    public static Bindings.BindableProperty<int> BindMaximumVisible(this IndicatorView _) => Bindings.BindableProperty<int>.Create(IndicatorView.MaximumVisibleProperty);
    public static Bindings.BindableProperty<int> BindPosition(this IndicatorView _) => Bindings.BindableProperty<int>.Create(IndicatorView.PositionProperty);
    public static Bindings.BindableProperty<Color> BindSelectedIndicatorColor(this IndicatorView _) => Bindings.BindableProperty<Color>.Create(IndicatorView.SelectedIndicatorColorProperty);

    // InputView Bindings

    public static Bindings.BindableProperty<double> BindCharacterSpacing(this InputView _) => Bindings.BindableProperty<double>.Create(InputView.CharacterSpacingProperty);
    public static Bindings.BindableProperty<bool> BindIsReadOnly(this InputView _) => Bindings.BindableProperty<bool>.Create(InputView.IsReadOnlyProperty);
    public static Bindings.BindableProperty<bool> BindIsSpellCheckEnabled(this InputView _) => Bindings.BindableProperty<bool>.Create(InputView.IsSpellCheckEnabledProperty);
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this InputView _) => Bindings.BindableProperty<Keyboard>.Create(InputView.KeyboardProperty);
    public static Bindings.BindableProperty<int> BindMaxLength(this InputView _) => Bindings.BindableProperty<int>.Create(InputView.MaxLengthProperty);
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this InputView _) => Bindings.BindableProperty<Color>.Create(InputView.PlaceholderColorProperty);
    public static Bindings.BindableProperty<string> BindPlaceholder(this InputView _) => Bindings.BindableProperty<string>.Create(InputView.PlaceholderProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this InputView _) => Bindings.BindableProperty<Color>.Create(InputView.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this InputView _) => Bindings.BindableProperty<string>.Create(InputView.TextProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this InputView _) => Bindings.BindableProperty<TextTransform>.Create(InputView.TextTransformProperty);

    // ItemsLayout Bindings

    public static Bindings.BindableProperty<SnapPointsAlignment> BindSnapPointsAlignment(this ItemsLayout _) => Bindings.BindableProperty<SnapPointsAlignment>.Create(ItemsLayout.SnapPointsAlignmentProperty);
    public static Bindings.BindableProperty<SnapPointsType> BindSnapPointsType(this ItemsLayout _) => Bindings.BindableProperty<SnapPointsType>.Create(ItemsLayout.SnapPointsTypeProperty);

    // ItemsView Bindings

    public static Bindings.BindableProperty<object> BindEmptyView(this ItemsView _) => Bindings.BindableProperty<object>.Create(ItemsView.EmptyViewProperty);
    public static Bindings.BindableProperty<DataTemplate> BindEmptyViewTemplate(this ItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(ItemsView.EmptyViewTemplateProperty);
    public static Bindings.BindableProperty<ScrollBarVisibility> BindHorizontalScrollBarVisibility(this ItemsView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ItemsView.HorizontalScrollBarVisibilityProperty);
    public static Bindings.BindableProperty<IEnumerable> BindItemsSource(this ItemsView _) => Bindings.BindableProperty<IEnumerable>.Create(ItemsView.ItemsSourceProperty);
    public static Bindings.BindableProperty<ItemsUpdatingScrollMode> BindItemsUpdatingScrollMode(this ItemsView _) => Bindings.BindableProperty<ItemsUpdatingScrollMode>.Create(ItemsView.ItemsUpdatingScrollModeProperty);
    public static Bindings.BindableProperty<DataTemplate> BindItemTemplate(this ItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(ItemsView.ItemTemplateProperty);
    public static Bindings.BindableProperty<int> BindRemainingItemsThreshold(this ItemsView _) => Bindings.BindableProperty<int>.Create(ItemsView.RemainingItemsThresholdProperty);
    public static Bindings.BindableProperty<object> BindRemainingItemsThresholdReachedCommandParameter(this ItemsView _) => Bindings.BindableProperty<object>.Create(ItemsView.RemainingItemsThresholdReachedCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindRemainingItemsThresholdReachedCommand(this ItemsView _) => Bindings.BindableProperty<ICommand>.Create(ItemsView.RemainingItemsThresholdReachedCommandProperty);
    public static Bindings.BindableProperty<ScrollBarVisibility> BindVerticalScrollBarVisibility(this ItemsView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ItemsView.VerticalScrollBarVisibilityProperty);

    // Label Bindings

    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Label _) => Bindings.BindableProperty<double>.Create(Label.CharacterSpacingProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Label _) => Bindings.BindableProperty<FontAttributes>.Create(Label.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Label _) => Bindings.BindableProperty<bool>.Create(Label.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this Label _) => Bindings.BindableProperty<string>.Create(Label.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this Label _) => Bindings.BindableProperty<double>.Create(Label.FontSizeProperty);
    public static Bindings.BindableProperty<FormattedString> BindFormattedText(this Label _) => Bindings.BindableProperty<FormattedString>.Create(Label.FormattedTextProperty);
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Label _) => Bindings.BindableProperty<TextAlignment>.Create(Label.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<LineBreakMode> BindLineBreakMode(this Label _) => Bindings.BindableProperty<LineBreakMode>.Create(Label.LineBreakModeProperty);
    public static Bindings.BindableProperty<double> BindLineHeight(this Label _) => Bindings.BindableProperty<double>.Create(Label.LineHeightProperty);
    public static Bindings.BindableProperty<int> BindMaxLines(this Label _) => Bindings.BindableProperty<int>.Create(Label.MaxLinesProperty);
    public static Bindings.BindableProperty<Thickness> BindPadding(this Label _) => Bindings.BindableProperty<Thickness>.Create(Label.PaddingProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this Label _) => Bindings.BindableProperty<Color>.Create(Label.TextColorProperty);
    public static Bindings.BindableProperty<TextDecorations> BindTextDecorations(this Label _) => Bindings.BindableProperty<TextDecorations>.Create(Label.TextDecorationsProperty);
    public static Bindings.BindableProperty<string> BindText(this Label _) => Bindings.BindableProperty<string>.Create(Label.TextProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this Label _) => Bindings.BindableProperty<TextTransform>.Create(Label.TextTransformProperty);
    public static Bindings.BindableProperty<TextType> BindTextType(this Label _) => Bindings.BindableProperty<TextType>.Create(Label.TextTypeProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Label _) => Bindings.BindableProperty<TextAlignment>.Create(Label.VerticalTextAlignmentProperty);

    // Layout Bindings

    public static Bindings.BindableProperty<bool> BindCascadeInputTransparent(this Layout _) => Bindings.BindableProperty<bool>.Create(Layout.CascadeInputTransparentProperty);
    public static Bindings.BindableProperty<bool> BindIsClippedToBounds(this Layout _) => Bindings.BindableProperty<bool>.Create(Layout.IsClippedToBoundsProperty);
    public static Bindings.BindableProperty<Thickness> BindPadding(this Layout _) => Bindings.BindableProperty<Thickness>.Create(Layout.PaddingProperty);

    // Line Bindings

    public static Bindings.BindableProperty<double> BindX1(this Line _) => Bindings.BindableProperty<double>.Create(Line.X1Property);
    public static Bindings.BindableProperty<double> BindX2(this Line _) => Bindings.BindableProperty<double>.Create(Line.X2Property);
    public static Bindings.BindableProperty<double> BindY1(this Line _) => Bindings.BindableProperty<double>.Create(Line.Y1Property);
    public static Bindings.BindableProperty<double> BindY2(this Line _) => Bindings.BindableProperty<double>.Create(Line.Y2Property);

    // LinearGradientBrush Bindings

    public static Bindings.BindableProperty<Point> BindEndPoint(this LinearGradientBrush _) => Bindings.BindableProperty<Point>.Create(LinearGradientBrush.EndPointProperty);
    public static Bindings.BindableProperty<Point> BindStartPoint(this LinearGradientBrush _) => Bindings.BindableProperty<Point>.Create(LinearGradientBrush.StartPointProperty);

    // LinearItemsLayout Bindings

    public static Bindings.BindableProperty<double> BindItemSpacing(this LinearItemsLayout _) => Bindings.BindableProperty<double>.Create(LinearItemsLayout.ItemSpacingProperty);

    // LineGeometry Bindings

    public static Bindings.BindableProperty<Point> BindEndPoint(this LineGeometry _) => Bindings.BindableProperty<Point>.Create(LineGeometry.EndPointProperty);
    public static Bindings.BindableProperty<Point> BindStartPoint(this LineGeometry _) => Bindings.BindableProperty<Point>.Create(LineGeometry.StartPointProperty);

    // LineSegment Bindings

    public static Bindings.BindableProperty<Point> BindPoint(this LineSegment _) => Bindings.BindableProperty<Point>.Create(LineSegment.PointProperty);

    // ListView Bindings

    public static Bindings.BindableProperty<object> BindFooter(this ListView _) => Bindings.BindableProperty<object>.Create(ListView.FooterProperty);
    public static Bindings.BindableProperty<DataTemplate> BindFooterTemplate(this ListView _) => Bindings.BindableProperty<DataTemplate>.Create(ListView.FooterTemplateProperty);
    public static Bindings.BindableProperty<DataTemplate> BindGroupHeaderTemplate(this ListView _) => Bindings.BindableProperty<DataTemplate>.Create(ListView.GroupHeaderTemplateProperty);
    public static Bindings.BindableProperty<bool> BindHasUnevenRows(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.HasUnevenRowsProperty);
    public static Bindings.BindableProperty<object> BindHeader(this ListView _) => Bindings.BindableProperty<object>.Create(ListView.HeaderProperty);
    public static Bindings.BindableProperty<DataTemplate> BindHeaderTemplate(this ListView _) => Bindings.BindableProperty<DataTemplate>.Create(ListView.HeaderTemplateProperty);
    public static Bindings.BindableProperty<ScrollBarVisibility> BindHorizontalScrollBarVisibility(this ListView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ListView.HorizontalScrollBarVisibilityProperty);
    public static Bindings.BindableProperty<bool> BindIsGroupingEnabled(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.IsGroupingEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsPullToRefreshEnabled(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.IsPullToRefreshEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsRefreshing(this ListView _) => Bindings.BindableProperty<bool>.Create(ListView.IsRefreshingProperty);
    public static Bindings.BindableProperty<ICommand> BindRefreshCommand(this ListView _) => Bindings.BindableProperty<ICommand>.Create(ListView.RefreshCommandProperty);
    public static Bindings.BindableProperty<Color> BindRefreshControlColor(this ListView _) => Bindings.BindableProperty<Color>.Create(ListView.RefreshControlColorProperty);
    public static Bindings.BindableProperty<int> BindRowHeight(this ListView _) => Bindings.BindableProperty<int>.Create(ListView.RowHeightProperty);
    public static Bindings.BindableProperty<object> BindSelectedItem(this ListView _) => Bindings.BindableProperty<object>.Create(ListView.SelectedItemProperty);
    public static Bindings.BindableProperty<ListViewSelectionMode> BindSelectionMode(this ListView _) => Bindings.BindableProperty<ListViewSelectionMode>.Create(ListView.SelectionModeProperty);
    public static Bindings.BindableProperty<Color> BindSeparatorColor(this ListView _) => Bindings.BindableProperty<Color>.Create(ListView.SeparatorColorProperty);
    public static Bindings.BindableProperty<SeparatorVisibility> BindSeparatorVisibility(this ListView _) => Bindings.BindableProperty<SeparatorVisibility>.Create(ListView.SeparatorVisibilityProperty);
    public static Bindings.BindableProperty<ScrollBarVisibility> BindVerticalScrollBarVisibility(this ListView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ListView.VerticalScrollBarVisibilityProperty);

    // MatrixTransform Bindings

    public static Bindings.BindableProperty<Matrix> BindMatrix(this MatrixTransform _) => Bindings.BindableProperty<Matrix>.Create(MatrixTransform.MatrixProperty);

    // MenuBar Bindings

    public static Bindings.BindableProperty<bool> BindIsEnabled(this MenuBar _) => Bindings.BindableProperty<bool>.Create(MenuBar.IsEnabledProperty);

    // MenuBarItem Bindings

    public static Bindings.BindableProperty<bool> BindIsEnabled(this MenuBarItem _) => Bindings.BindableProperty<bool>.Create(MenuBarItem.IsEnabledProperty);
    public static Bindings.BindableProperty<string> BindText(this MenuBarItem _) => Bindings.BindableProperty<string>.Create(MenuBarItem.TextProperty);

    // MenuItem Bindings

    public static Bindings.BindableProperty<Accelerator> BindAccelerator(this MenuItem _) => Bindings.BindableProperty<Accelerator>.Create(MenuItem.AcceleratorProperty);
    public static Bindings.BindableProperty<object> BindCommandParameter(this MenuItem _) => Bindings.BindableProperty<object>.Create(MenuItem.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this MenuItem _) => Bindings.BindableProperty<ICommand>.Create(MenuItem.CommandProperty);
    public static Bindings.BindableProperty<ImageSource> BindIconImageSource(this MenuItem _) => Bindings.BindableProperty<ImageSource>.Create(MenuItem.IconImageSourceProperty);
    public static Bindings.BindableProperty<bool> BindIsDestructive(this MenuItem _) => Bindings.BindableProperty<bool>.Create(MenuItem.IsDestructiveProperty);
    public static Bindings.BindableProperty<bool> BindIsEnabled(this MenuItem _) => Bindings.BindableProperty<bool>.Create(MenuItem.IsEnabledProperty);
    public static Bindings.BindableProperty<string> BindText(this MenuItem _) => Bindings.BindableProperty<string>.Create(MenuItem.TextProperty);

    // NavigableElement Bindings

    public static Bindings.BindableProperty<INavigation> BindNavigation(this NavigableElement _) => Bindings.BindableProperty<INavigation>.Create(NavigableElement.NavigationProperty);
    public static Bindings.BindableProperty<Style> BindStyle(this NavigableElement _) => Bindings.BindableProperty<Style>.Create(NavigableElement.StyleProperty);

    // NavigationPage Bindings

    public static Bindings.BindableProperty<string> BindBackButtonTitle(this NavigationPage _) => Bindings.BindableProperty<string>.Create(NavigationPage.BackButtonTitleProperty);
    public static Bindings.BindableProperty<Color> BindBarBackgroundColor(this NavigationPage _) => Bindings.BindableProperty<Color>.Create(NavigationPage.BarBackgroundColorProperty);
    public static Bindings.BindableProperty<Brush> BindBarBackground(this NavigationPage _) => Bindings.BindableProperty<Brush>.Create(NavigationPage.BarBackgroundProperty);
    public static Bindings.BindableProperty<Color> BindBarTextColor(this NavigationPage _) => Bindings.BindableProperty<Color>.Create(NavigationPage.BarTextColorProperty);
    public static Bindings.BindableProperty<Page> BindCurrentPage(this NavigationPage _) => Bindings.BindableProperty<Page>.Create(NavigationPage.CurrentPageProperty);
    public static Bindings.BindableProperty<bool> BindHasBackButton(this NavigationPage _) => Bindings.BindableProperty<bool>.Create(NavigationPage.HasBackButtonProperty);
    public static Bindings.BindableProperty<bool> BindHasNavigationBar(this NavigationPage _) => Bindings.BindableProperty<bool>.Create(NavigationPage.HasNavigationBarProperty);
    public static Bindings.BindableProperty<Color> BindIconColor(this NavigationPage _) => Bindings.BindableProperty<Color>.Create(NavigationPage.IconColorProperty);
    public static Bindings.BindableProperty<Page> BindRootPage(this NavigationPage _) => Bindings.BindableProperty<Page>.Create(NavigationPage.RootPageProperty);
    public static Bindings.BindableProperty<ImageSource> BindTitleIconImageSource(this NavigationPage _) => Bindings.BindableProperty<ImageSource>.Create(NavigationPage.TitleIconImageSourceProperty);
    public static Bindings.BindableProperty<View> BindTitleView(this NavigationPage _) => Bindings.BindableProperty<View>.Create(NavigationPage.TitleViewProperty);

    // OrientationStateTrigger Bindings

    public static Bindings.BindableProperty<DisplayOrientation> BindOrientation(this OrientationStateTrigger _) => Bindings.BindableProperty<DisplayOrientation>.Create(OrientationStateTrigger.OrientationProperty);

    // Page Bindings

    public static Bindings.BindableProperty<ImageSource> BindBackgroundImageSource(this Page _) => Bindings.BindableProperty<ImageSource>.Create(Page.BackgroundImageSourceProperty);
    public static Bindings.BindableProperty<ImageSource> BindIconImageSource(this Page _) => Bindings.BindableProperty<ImageSource>.Create(Page.IconImageSourceProperty);
    public static Bindings.BindableProperty<bool> BindIsBusy(this Page _) => Bindings.BindableProperty<bool>.Create(Page.IsBusyProperty);
    public static Bindings.BindableProperty<Thickness> BindPadding(this Page _) => Bindings.BindableProperty<Thickness>.Create(Page.PaddingProperty);
    public static Bindings.BindableProperty<string> BindTitle(this Page _) => Bindings.BindableProperty<string>.Create(Page.TitleProperty);

    // PanGestureRecognizer Bindings

    public static Bindings.BindableProperty<int> BindTouchPoints(this PanGestureRecognizer _) => Bindings.BindableProperty<int>.Create(PanGestureRecognizer.TouchPointsProperty);

    // Path Bindings

    public static Bindings.BindableProperty<Geometry> BindData(this Path _) => Bindings.BindableProperty<Geometry>.Create(Path.DataProperty);
    public static Bindings.BindableProperty<Transform> BindRenderTransform(this Path _) => Bindings.BindableProperty<Transform>.Create(Path.RenderTransformProperty);

    // PathFigure Bindings

    public static Bindings.BindableProperty<bool> BindIsClosed(this PathFigure _) => Bindings.BindableProperty<bool>.Create(PathFigure.IsClosedProperty);
    public static Bindings.BindableProperty<bool> BindIsFilled(this PathFigure _) => Bindings.BindableProperty<bool>.Create(PathFigure.IsFilledProperty);
    public static Bindings.BindableProperty<PathSegmentCollection> BindSegments(this PathFigure _) => Bindings.BindableProperty<PathSegmentCollection>.Create(PathFigure.SegmentsProperty);
    public static Bindings.BindableProperty<Point> BindStartPoint(this PathFigure _) => Bindings.BindableProperty<Point>.Create(PathFigure.StartPointProperty);

    // PathGeometry Bindings

    public static Bindings.BindableProperty<PathFigureCollection> BindFigures(this PathGeometry _) => Bindings.BindableProperty<PathFigureCollection>.Create(PathGeometry.FiguresProperty);
    public static Bindings.BindableProperty<FillRule> BindFillRule(this PathGeometry _) => Bindings.BindableProperty<FillRule>.Create(PathGeometry.FillRuleProperty);

    // Picker Bindings

    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Picker _) => Bindings.BindableProperty<double>.Create(Picker.CharacterSpacingProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Picker _) => Bindings.BindableProperty<FontAttributes>.Create(Picker.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Picker _) => Bindings.BindableProperty<bool>.Create(Picker.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this Picker _) => Bindings.BindableProperty<string>.Create(Picker.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this Picker _) => Bindings.BindableProperty<double>.Create(Picker.FontSizeProperty);
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this Picker _) => Bindings.BindableProperty<TextAlignment>.Create(Picker.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<IList> BindItemsSource(this Picker _) => Bindings.BindableProperty<IList>.Create(Picker.ItemsSourceProperty);
    public static Bindings.BindableProperty<int> BindSelectedIndex(this Picker _) => Bindings.BindableProperty<int>.Create(Picker.SelectedIndexProperty);
    public static Bindings.BindableProperty<object> BindSelectedItem(this Picker _) => Bindings.BindableProperty<object>.Create(Picker.SelectedItemProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this Picker _) => Bindings.BindableProperty<Color>.Create(Picker.TextColorProperty);
    public static Bindings.BindableProperty<Color> BindTitleColor(this Picker _) => Bindings.BindableProperty<Color>.Create(Picker.TitleColorProperty);
    public static Bindings.BindableProperty<string> BindTitle(this Picker _) => Bindings.BindableProperty<string>.Create(Picker.TitleProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this Picker _) => Bindings.BindableProperty<TextAlignment>.Create(Picker.VerticalTextAlignmentProperty);

    // PolyBezierSegment Bindings

    public static Bindings.BindableProperty<PointCollection> BindPoints(this PolyBezierSegment _) => Bindings.BindableProperty<PointCollection>.Create(PolyBezierSegment.PointsProperty);

    // Polygon Bindings

    public static Bindings.BindableProperty<FillRule> BindFillRule(this Polygon _) => Bindings.BindableProperty<FillRule>.Create(Polygon.FillRuleProperty);
    public static Bindings.BindableProperty<PointCollection> BindPoints(this Polygon _) => Bindings.BindableProperty<PointCollection>.Create(Polygon.PointsProperty);

    // Polyline Bindings

    public static Bindings.BindableProperty<FillRule> BindFillRule(this Polyline _) => Bindings.BindableProperty<FillRule>.Create(Polyline.FillRuleProperty);
    public static Bindings.BindableProperty<PointCollection> BindPoints(this Polyline _) => Bindings.BindableProperty<PointCollection>.Create(Polyline.PointsProperty);

    // PolyLineSegment Bindings

    public static Bindings.BindableProperty<PointCollection> BindPoints(this PolyLineSegment _) => Bindings.BindableProperty<PointCollection>.Create(PolyLineSegment.PointsProperty);

    // PolyQuadraticBezierSegment Bindings

    public static Bindings.BindableProperty<PointCollection> BindPoints(this PolyQuadraticBezierSegment _) => Bindings.BindableProperty<PointCollection>.Create(PolyQuadraticBezierSegment.PointsProperty);

    // ProgressBar Bindings

    public static Bindings.BindableProperty<Color> BindProgressColor(this ProgressBar _) => Bindings.BindableProperty<Color>.Create(ProgressBar.ProgressColorProperty);
    public static Bindings.BindableProperty<double> BindProgress(this ProgressBar _) => Bindings.BindableProperty<double>.Create(ProgressBar.ProgressProperty);

    // QuadraticBezierSegment Bindings

    public static Bindings.BindableProperty<Point> BindPoint1(this QuadraticBezierSegment _) => Bindings.BindableProperty<Point>.Create(QuadraticBezierSegment.Point1Property);
    public static Bindings.BindableProperty<Point> BindPoint2(this QuadraticBezierSegment _) => Bindings.BindableProperty<Point>.Create(QuadraticBezierSegment.Point2Property);

    // RadialGradientBrush Bindings

    public static Bindings.BindableProperty<Point> BindCenter(this RadialGradientBrush _) => Bindings.BindableProperty<Point>.Create(RadialGradientBrush.CenterProperty);
    public static Bindings.BindableProperty<double> BindRadius(this RadialGradientBrush _) => Bindings.BindableProperty<double>.Create(RadialGradientBrush.RadiusProperty);

    // RadioButton Bindings

    public static Bindings.BindableProperty<Color> BindBorderColor(this RadioButton _) => Bindings.BindableProperty<Color>.Create(RadioButton.BorderColorProperty);
    public static Bindings.BindableProperty<double> BindBorderWidth(this RadioButton _) => Bindings.BindableProperty<double>.Create(RadioButton.BorderWidthProperty);
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this RadioButton _) => Bindings.BindableProperty<double>.Create(RadioButton.CharacterSpacingProperty);
    public static Bindings.BindableProperty<object> BindContent(this RadioButton _) => Bindings.BindableProperty<object>.Create(RadioButton.ContentProperty);
    public static Bindings.BindableProperty<int> BindCornerRadius(this RadioButton _) => Bindings.BindableProperty<int>.Create(RadioButton.CornerRadiusProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this RadioButton _) => Bindings.BindableProperty<FontAttributes>.Create(RadioButton.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this RadioButton _) => Bindings.BindableProperty<bool>.Create(RadioButton.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this RadioButton _) => Bindings.BindableProperty<string>.Create(RadioButton.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this RadioButton _) => Bindings.BindableProperty<double>.Create(RadioButton.FontSizeProperty);
    public static Bindings.BindableProperty<string> BindGroupName(this RadioButton _) => Bindings.BindableProperty<string>.Create(RadioButton.GroupNameProperty);
    public static Bindings.BindableProperty<bool> BindIsChecked(this RadioButton _) => Bindings.BindableProperty<bool>.Create(RadioButton.IsCheckedProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this RadioButton _) => Bindings.BindableProperty<Color>.Create(RadioButton.TextColorProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this RadioButton _) => Bindings.BindableProperty<TextTransform>.Create(RadioButton.TextTransformProperty);
    public static Bindings.BindableProperty<object> BindValue(this RadioButton _) => Bindings.BindableProperty<object>.Create(RadioButton.ValueProperty);

    // Rectangle Bindings

    public static Bindings.BindableProperty<double> BindRadiusX(this Rectangle _) => Bindings.BindableProperty<double>.Create(Rectangle.RadiusXProperty);
    public static Bindings.BindableProperty<double> BindRadiusY(this Rectangle _) => Bindings.BindableProperty<double>.Create(Rectangle.RadiusYProperty);

    // RectangleGeometry Bindings

    public static Bindings.BindableProperty<Rect> BindRect(this RectangleGeometry _) => Bindings.BindableProperty<Rect>.Create(RectangleGeometry.RectProperty);

    // RefreshView Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this RefreshView _) => Bindings.BindableProperty<object>.Create(RefreshView.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this RefreshView _) => Bindings.BindableProperty<ICommand>.Create(RefreshView.CommandProperty);
    public static Bindings.BindableProperty<bool> BindIsRefreshing(this RefreshView _) => Bindings.BindableProperty<bool>.Create(RefreshView.IsRefreshingProperty);
    public static Bindings.BindableProperty<Color> BindRefreshColor(this RefreshView _) => Bindings.BindableProperty<Color>.Create(RefreshView.RefreshColorProperty);

    // RelativeLayout Bindings

    public static Bindings.BindableProperty<BoundsConstraint> BindBoundsConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<BoundsConstraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.BoundsConstraintProperty);
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindHeightConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.HeightConstraintProperty);
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindWidthConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.WidthConstraintProperty);
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindXConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.XConstraintProperty);
    public static Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint> BindYConstraint(this Microsoft.Maui.Controls.Compatibility.RelativeLayout _) => Bindings.BindableProperty<Microsoft.Maui.Controls.Compatibility.Constraint>.Create(Microsoft.Maui.Controls.Compatibility.RelativeLayout.YConstraintProperty);

    // ReorderableItemsView Bindings

    public static Bindings.BindableProperty<bool> BindCanMixGroups(this ReorderableItemsView _) => Bindings.BindableProperty<bool>.Create(ReorderableItemsView.CanMixGroupsProperty);
    public static Bindings.BindableProperty<bool> BindCanReorderItems(this ReorderableItemsView _) => Bindings.BindableProperty<bool>.Create(ReorderableItemsView.CanReorderItemsProperty);

    // RotateTransform Bindings

    public static Bindings.BindableProperty<double> BindAngle(this RotateTransform _) => Bindings.BindableProperty<double>.Create(RotateTransform.AngleProperty);
    public static Bindings.BindableProperty<double> BindCenterX(this RotateTransform _) => Bindings.BindableProperty<double>.Create(RotateTransform.CenterXProperty);
    public static Bindings.BindableProperty<double> BindCenterY(this RotateTransform _) => Bindings.BindableProperty<double>.Create(RotateTransform.CenterYProperty);

    // RoundRectangle Bindings

    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this RoundRectangle _) => Bindings.BindableProperty<CornerRadius>.Create(RoundRectangle.CornerRadiusProperty);

    // RoundRectangleGeometry Bindings

    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this RoundRectangleGeometry _) => Bindings.BindableProperty<CornerRadius>.Create(RoundRectangleGeometry.CornerRadiusProperty);
    public static Bindings.BindableProperty<Rect> BindRect(this RoundRectangleGeometry _) => Bindings.BindableProperty<Rect>.Create(RoundRectangleGeometry.RectProperty);

    // RowDefinition Bindings

    public static Bindings.BindableProperty<GridLength> BindHeight(this RowDefinition _) => Bindings.BindableProperty<GridLength>.Create(RowDefinition.HeightProperty);

    // ScaleTransform Bindings

    public static Bindings.BindableProperty<double> BindCenterX(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.CenterXProperty);
    public static Bindings.BindableProperty<double> BindCenterY(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.CenterYProperty);
    public static Bindings.BindableProperty<double> BindScaleX(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.ScaleXProperty);
    public static Bindings.BindableProperty<double> BindScaleY(this ScaleTransform _) => Bindings.BindableProperty<double>.Create(ScaleTransform.ScaleYProperty);

    // ScrollView Bindings

    public static Bindings.BindableProperty<Size> BindContentSize(this ScrollView _) => Bindings.BindableProperty<Size>.Create(ScrollView.ContentSizeProperty);
    public static Bindings.BindableProperty<ScrollBarVisibility> BindHorizontalScrollBarVisibility(this ScrollView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ScrollView.HorizontalScrollBarVisibilityProperty);
    public static Bindings.BindableProperty<ScrollOrientation> BindOrientation(this ScrollView _) => Bindings.BindableProperty<ScrollOrientation>.Create(ScrollView.OrientationProperty);
    public static Bindings.BindableProperty<double> BindScrollX(this ScrollView _) => Bindings.BindableProperty<double>.Create(ScrollView.ScrollXProperty);
    public static Bindings.BindableProperty<double> BindScrollY(this ScrollView _) => Bindings.BindableProperty<double>.Create(ScrollView.ScrollYProperty);
    public static Bindings.BindableProperty<ScrollBarVisibility> BindVerticalScrollBarVisibility(this ScrollView _) => Bindings.BindableProperty<ScrollBarVisibility>.Create(ScrollView.VerticalScrollBarVisibilityProperty);

    // SearchBar Bindings

    public static Bindings.BindableProperty<Color> BindCancelButtonColor(this SearchBar _) => Bindings.BindableProperty<Color>.Create(SearchBar.CancelButtonColorProperty);
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this SearchBar _) => Bindings.BindableProperty<double>.Create(SearchBar.CharacterSpacingProperty);
    public static Bindings.BindableProperty<int> BindCursorPosition(this SearchBar _) => Bindings.BindableProperty<int>.Create(SearchBar.CursorPositionProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this SearchBar _) => Bindings.BindableProperty<FontAttributes>.Create(SearchBar.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this SearchBar _) => Bindings.BindableProperty<bool>.Create(SearchBar.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this SearchBar _) => Bindings.BindableProperty<string>.Create(SearchBar.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this SearchBar _) => Bindings.BindableProperty<double>.Create(SearchBar.FontSizeProperty);
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this SearchBar _) => Bindings.BindableProperty<TextAlignment>.Create(SearchBar.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<bool> BindIsTextPredictionEnabled(this SearchBar _) => Bindings.BindableProperty<bool>.Create(SearchBar.IsTextPredictionEnabledProperty);
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this SearchBar _) => Bindings.BindableProperty<Color>.Create(SearchBar.PlaceholderColorProperty);
    public static Bindings.BindableProperty<string> BindPlaceholder(this SearchBar _) => Bindings.BindableProperty<string>.Create(SearchBar.PlaceholderProperty);
    public static Bindings.BindableProperty<object> BindSearchCommandParameter(this SearchBar _) => Bindings.BindableProperty<object>.Create(SearchBar.SearchCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindSearchCommand(this SearchBar _) => Bindings.BindableProperty<ICommand>.Create(SearchBar.SearchCommandProperty);
    public static Bindings.BindableProperty<int> BindSelectionLength(this SearchBar _) => Bindings.BindableProperty<int>.Create(SearchBar.SelectionLengthProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this SearchBar _) => Bindings.BindableProperty<Color>.Create(SearchBar.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this SearchBar _) => Bindings.BindableProperty<string>.Create(SearchBar.TextProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this SearchBar _) => Bindings.BindableProperty<TextAlignment>.Create(SearchBar.VerticalTextAlignmentProperty);

    // SearchHandler Bindings

    public static Bindings.BindableProperty<string> BindAutomationId(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.AutomationIdProperty);
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.BackgroundColorProperty);
    public static Bindings.BindableProperty<Color> BindCancelButtonColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.CancelButtonColorProperty);
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this SearchHandler _) => Bindings.BindableProperty<double>.Create(SearchHandler.CharacterSpacingProperty);
    public static Bindings.BindableProperty<string> BindClearIconHelpText(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearIconHelpTextProperty);
    public static Bindings.BindableProperty<string> BindClearIconName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearIconNameProperty);
    public static Bindings.BindableProperty<ImageSource> BindClearIcon(this SearchHandler _) => Bindings.BindableProperty<ImageSource>.Create(SearchHandler.ClearIconProperty);
    public static Bindings.BindableProperty<object> BindClearPlaceholderCommandParameter(this SearchHandler _) => Bindings.BindableProperty<object>.Create(SearchHandler.ClearPlaceholderCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindClearPlaceholderCommand(this SearchHandler _) => Bindings.BindableProperty<ICommand>.Create(SearchHandler.ClearPlaceholderCommandProperty);
    public static Bindings.BindableProperty<bool> BindClearPlaceholderEnabled(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.ClearPlaceholderEnabledProperty);
    public static Bindings.BindableProperty<string> BindClearPlaceholderHelpText(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearPlaceholderHelpTextProperty);
    public static Bindings.BindableProperty<ImageSource> BindClearPlaceholderIcon(this SearchHandler _) => Bindings.BindableProperty<ImageSource>.Create(SearchHandler.ClearPlaceholderIconProperty);
    public static Bindings.BindableProperty<string> BindClearPlaceholderName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.ClearPlaceholderNameProperty);
    public static Bindings.BindableProperty<object> BindCommandParameter(this SearchHandler _) => Bindings.BindableProperty<object>.Create(SearchHandler.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this SearchHandler _) => Bindings.BindableProperty<ICommand>.Create(SearchHandler.CommandProperty);
    public static Bindings.BindableProperty<string> BindDisplayMemberName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.DisplayMemberNameProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this SearchHandler _) => Bindings.BindableProperty<FontAttributes>.Create(SearchHandler.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this SearchHandler _) => Bindings.BindableProperty<double>.Create(SearchHandler.FontSizeProperty);
    public static Bindings.BindableProperty<TextAlignment> BindHorizontalTextAlignment(this SearchHandler _) => Bindings.BindableProperty<TextAlignment>.Create(SearchHandler.HorizontalTextAlignmentProperty);
    public static Bindings.BindableProperty<bool> BindIsFocused(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.IsFocusedProperty);
    public static Bindings.BindableProperty<bool> BindIsSearchEnabled(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.IsSearchEnabledProperty);
    public static Bindings.BindableProperty<IEnumerable> BindItemsSource(this SearchHandler _) => Bindings.BindableProperty<IEnumerable>.Create(SearchHandler.ItemsSourceProperty);
    public static Bindings.BindableProperty<DataTemplate> BindItemTemplate(this SearchHandler _) => Bindings.BindableProperty<DataTemplate>.Create(SearchHandler.ItemTemplateProperty);
    public static Bindings.BindableProperty<Keyboard> BindKeyboard(this SearchHandler _) => Bindings.BindableProperty<Keyboard>.Create(SearchHandler.KeyboardProperty);
    public static Bindings.BindableProperty<Color> BindPlaceholderColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.PlaceholderColorProperty);
    public static Bindings.BindableProperty<string> BindPlaceholder(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.PlaceholderProperty);
    public static Bindings.BindableProperty<string> BindQueryIconHelpText(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.QueryIconHelpTextProperty);
    public static Bindings.BindableProperty<string> BindQueryIconName(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.QueryIconNameProperty);
    public static Bindings.BindableProperty<ImageSource> BindQueryIcon(this SearchHandler _) => Bindings.BindableProperty<ImageSource>.Create(SearchHandler.QueryIconProperty);
    public static Bindings.BindableProperty<string> BindQuery(this SearchHandler _) => Bindings.BindableProperty<string>.Create(SearchHandler.QueryProperty);
    public static Bindings.BindableProperty<SearchBoxVisibility> BindSearchBoxVisibility(this SearchHandler _) => Bindings.BindableProperty<SearchBoxVisibility>.Create(SearchHandler.SearchBoxVisibilityProperty);
    public static Bindings.BindableProperty<object> BindSelectedItem(this SearchHandler _) => Bindings.BindableProperty<object>.Create(SearchHandler.SelectedItemProperty);
    public static Bindings.BindableProperty<bool> BindShowsResults(this SearchHandler _) => Bindings.BindableProperty<bool>.Create(SearchHandler.ShowsResultsProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this SearchHandler _) => Bindings.BindableProperty<Color>.Create(SearchHandler.TextColorProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this SearchHandler _) => Bindings.BindableProperty<TextTransform>.Create(SearchHandler.TextTransformProperty);
    public static Bindings.BindableProperty<TextAlignment> BindVerticalTextAlignment(this SearchHandler _) => Bindings.BindableProperty<TextAlignment>.Create(SearchHandler.VerticalTextAlignmentProperty);

    // SelectableItemsView Bindings

    public static Bindings.BindableProperty<object> BindSelectedItem(this SelectableItemsView _) => Bindings.BindableProperty<object>.Create(SelectableItemsView.SelectedItemProperty);
    public static Bindings.BindableProperty<IList<object>> BindSelectedItems(this SelectableItemsView _) => Bindings.BindableProperty<IList<object>>.Create(SelectableItemsView.SelectedItemsProperty);
    public static Bindings.BindableProperty<object> BindSelectionChangedCommandParameter(this SelectableItemsView _) => Bindings.BindableProperty<object>.Create(SelectableItemsView.SelectionChangedCommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindSelectionChangedCommand(this SelectableItemsView _) => Bindings.BindableProperty<ICommand>.Create(SelectableItemsView.SelectionChangedCommandProperty);
    public static Bindings.BindableProperty<SelectionMode> BindSelectionMode(this SelectableItemsView _) => Bindings.BindableProperty<SelectionMode>.Create(SelectableItemsView.SelectionModeProperty);

    // Shadow Bindings

    public static Bindings.BindableProperty<Brush> BindBrush(this Shadow _) => Bindings.BindableProperty<Brush>.Create(Shadow.BrushProperty);
    public static Bindings.BindableProperty<Point> BindOffset(this Shadow _) => Bindings.BindableProperty<Point>.Create(Shadow.OffsetProperty);
    public static Bindings.BindableProperty<float> BindOpacity(this Shadow _) => Bindings.BindableProperty<float>.Create(Shadow.OpacityProperty);
    public static Bindings.BindableProperty<float> BindRadius(this Shadow _) => Bindings.BindableProperty<float>.Create(Shadow.RadiusProperty);

    // Shape Bindings

    public static Bindings.BindableProperty<Stretch> BindAspect(this Shape _) => Bindings.BindableProperty<Stretch>.Create(Shape.AspectProperty);
    public static Bindings.BindableProperty<Brush> BindFill(this Shape _) => Bindings.BindableProperty<Brush>.Create(Shape.FillProperty);
    public static Bindings.BindableProperty<DoubleCollection> BindStrokeDashArray(this Shape _) => Bindings.BindableProperty<DoubleCollection>.Create(Shape.StrokeDashArrayProperty);
    public static Bindings.BindableProperty<double> BindStrokeDashOffset(this Shape _) => Bindings.BindableProperty<double>.Create(Shape.StrokeDashOffsetProperty);
    public static Bindings.BindableProperty<PenLineCap> BindStrokeLineCap(this Shape _) => Bindings.BindableProperty<PenLineCap>.Create(Shape.StrokeLineCapProperty);
    public static Bindings.BindableProperty<PenLineJoin> BindStrokeLineJoin(this Shape _) => Bindings.BindableProperty<PenLineJoin>.Create(Shape.StrokeLineJoinProperty);
    public static Bindings.BindableProperty<double> BindStrokeMiterLimit(this Shape _) => Bindings.BindableProperty<double>.Create(Shape.StrokeMiterLimitProperty);
    public static Bindings.BindableProperty<Brush> BindStroke(this Shape _) => Bindings.BindableProperty<Brush>.Create(Shape.StrokeProperty);
    public static Bindings.BindableProperty<double> BindStrokeThickness(this Shape _) => Bindings.BindableProperty<double>.Create(Shape.StrokeThicknessProperty);

    // Shell Bindings

    public static Bindings.BindableProperty<BackButtonBehavior> BindBackButtonBehavior(this Shell _) => Bindings.BindableProperty<BackButtonBehavior>.Create(Shell.BackButtonBehaviorProperty);
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.BackgroundColorProperty);
    public static Bindings.BindableProperty<ShellItem> BindCurrentItem(this Shell _) => Bindings.BindableProperty<ShellItem>.Create(Shell.CurrentItemProperty);
    public static Bindings.BindableProperty<ShellNavigationState> BindCurrentState(this Shell _) => Bindings.BindableProperty<ShellNavigationState>.Create(Shell.CurrentStateProperty);
    public static Bindings.BindableProperty<Color> BindDisabledColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.DisabledColorProperty);
    public static Bindings.BindableProperty<Brush> BindFlyoutBackdrop(this Shell _) => Bindings.BindableProperty<Brush>.Create(Shell.FlyoutBackdropProperty);
    public static Bindings.BindableProperty<Color> BindFlyoutBackgroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.FlyoutBackgroundColorProperty);
    public static Bindings.BindableProperty<Aspect> BindFlyoutBackgroundImageAspect(this Shell _) => Bindings.BindableProperty<Aspect>.Create(Shell.FlyoutBackgroundImageAspectProperty);
    public static Bindings.BindableProperty<ImageSource> BindFlyoutBackgroundImage(this Shell _) => Bindings.BindableProperty<ImageSource>.Create(Shell.FlyoutBackgroundImageProperty);
    public static Bindings.BindableProperty<Brush> BindFlyoutBackground(this Shell _) => Bindings.BindableProperty<Brush>.Create(Shell.FlyoutBackgroundProperty);
    public static Bindings.BindableProperty<FlyoutBehavior> BindFlyoutBehavior(this Shell _) => Bindings.BindableProperty<FlyoutBehavior>.Create(Shell.FlyoutBehaviorProperty);
    public static Bindings.BindableProperty<object> BindFlyoutContent(this Shell _) => Bindings.BindableProperty<object>.Create(Shell.FlyoutContentProperty);
    public static Bindings.BindableProperty<DataTemplate> BindFlyoutContentTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.FlyoutContentTemplateProperty);
    public static Bindings.BindableProperty<object> BindFlyoutFooter(this Shell _) => Bindings.BindableProperty<object>.Create(Shell.FlyoutFooterProperty);
    public static Bindings.BindableProperty<DataTemplate> BindFlyoutFooterTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.FlyoutFooterTemplateProperty);
    public static Bindings.BindableProperty<FlyoutHeaderBehavior> BindFlyoutHeaderBehavior(this Shell _) => Bindings.BindableProperty<FlyoutHeaderBehavior>.Create(Shell.FlyoutHeaderBehaviorProperty);
    public static Bindings.BindableProperty<object> BindFlyoutHeader(this Shell _) => Bindings.BindableProperty<object>.Create(Shell.FlyoutHeaderProperty);
    public static Bindings.BindableProperty<DataTemplate> BindFlyoutHeaderTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.FlyoutHeaderTemplateProperty);
    public static Bindings.BindableProperty<double> BindFlyoutHeight(this Shell _) => Bindings.BindableProperty<double>.Create(Shell.FlyoutHeightProperty);
    public static Bindings.BindableProperty<ImageSource> BindFlyoutIcon(this Shell _) => Bindings.BindableProperty<ImageSource>.Create(Shell.FlyoutIconProperty);
    public static Bindings.BindableProperty<bool> BindFlyoutIsPresented(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.FlyoutIsPresentedProperty);
    public static Bindings.BindableProperty<bool> BindFlyoutItemIsVisible(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.FlyoutItemIsVisibleProperty);
    public static Bindings.BindableProperty<ScrollMode> BindFlyoutVerticalScrollMode(this Shell _) => Bindings.BindableProperty<ScrollMode>.Create(Shell.FlyoutVerticalScrollModeProperty);
    public static Bindings.BindableProperty<double> BindFlyoutWidth(this Shell _) => Bindings.BindableProperty<double>.Create(Shell.FlyoutWidthProperty);
    public static Bindings.BindableProperty<Color> BindForegroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.ForegroundColorProperty);
    public static Bindings.BindableProperty<DataTemplate> BindItemTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.ItemTemplateProperty);
    public static Bindings.BindableProperty<DataTemplate> BindMenuItemTemplate(this Shell _) => Bindings.BindableProperty<DataTemplate>.Create(Shell.MenuItemTemplateProperty);
    public static Bindings.BindableProperty<bool> BindNavBarHasShadow(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.NavBarHasShadowProperty);
    public static Bindings.BindableProperty<bool> BindNavBarIsVisible(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.NavBarIsVisibleProperty);
    public static Bindings.BindableProperty<PresentationMode> BindPresentationMode(this Shell _) => Bindings.BindableProperty<PresentationMode>.Create(Shell.PresentationModeProperty);
    public static Bindings.BindableProperty<SearchHandler> BindSearchHandler(this Shell _) => Bindings.BindableProperty<SearchHandler>.Create(Shell.SearchHandlerProperty);
    public static Bindings.BindableProperty<Color> BindTabBarBackgroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarBackgroundColorProperty);
    public static Bindings.BindableProperty<Color> BindTabBarDisabledColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarDisabledColorProperty);
    public static Bindings.BindableProperty<Color> BindTabBarForegroundColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarForegroundColorProperty);
    public static Bindings.BindableProperty<bool> BindTabBarIsVisible(this Shell _) => Bindings.BindableProperty<bool>.Create(Shell.TabBarIsVisibleProperty);
    public static Bindings.BindableProperty<Color> BindTabBarTitleColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarTitleColorProperty);
    public static Bindings.BindableProperty<Color> BindTabBarUnselectedColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TabBarUnselectedColorProperty);
    public static Bindings.BindableProperty<Color> BindTitleColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.TitleColorProperty);
    public static Bindings.BindableProperty<View> BindTitleView(this Shell _) => Bindings.BindableProperty<View>.Create(Shell.TitleViewProperty);
    public static Bindings.BindableProperty<Color> BindUnselectedColor(this Shell _) => Bindings.BindableProperty<Color>.Create(Shell.UnselectedColorProperty);

    // ShellContent Bindings

    public static Bindings.BindableProperty<object> BindContent(this ShellContent _) => Bindings.BindableProperty<object>.Create(ShellContent.ContentProperty);
    public static Bindings.BindableProperty<DataTemplate> BindContentTemplate(this ShellContent _) => Bindings.BindableProperty<DataTemplate>.Create(ShellContent.ContentTemplateProperty);
    public static Bindings.BindableProperty<MenuItemCollection> BindMenuItems(this ShellContent _) => Bindings.BindableProperty<MenuItemCollection>.Create(ShellContent.MenuItemsProperty);

    // ShellGroupItem Bindings

    public static Bindings.BindableProperty<FlyoutDisplayOptions> BindFlyoutDisplayOptions(this ShellGroupItem _) => Bindings.BindableProperty<FlyoutDisplayOptions>.Create(ShellGroupItem.FlyoutDisplayOptionsProperty);

    // ShellItem Bindings

    public static Bindings.BindableProperty<ShellSection> BindCurrentItem(this ShellItem _) => Bindings.BindableProperty<ShellSection>.Create(ShellItem.CurrentItemProperty);

    // ShellSection Bindings

    public static Bindings.BindableProperty<ShellContent> BindCurrentItem(this ShellSection _) => Bindings.BindableProperty<ShellContent>.Create(ShellSection.CurrentItemProperty);

    // SkewTransform Bindings

    public static Bindings.BindableProperty<double> BindAngleX(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.AngleXProperty);
    public static Bindings.BindableProperty<double> BindAngleY(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.AngleYProperty);
    public static Bindings.BindableProperty<double> BindCenterX(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.CenterXProperty);
    public static Bindings.BindableProperty<double> BindCenterY(this SkewTransform _) => Bindings.BindableProperty<double>.Create(SkewTransform.CenterYProperty);

    // Slider Bindings

    public static Bindings.BindableProperty<ICommand> BindDragCompletedCommand(this Slider _) => Bindings.BindableProperty<ICommand>.Create(Slider.DragCompletedCommandProperty);
    public static Bindings.BindableProperty<ICommand> BindDragStartedCommand(this Slider _) => Bindings.BindableProperty<ICommand>.Create(Slider.DragStartedCommandProperty);
    public static Bindings.BindableProperty<double> BindMaximum(this Slider _) => Bindings.BindableProperty<double>.Create(Slider.MaximumProperty);
    public static Bindings.BindableProperty<Color> BindMaximumTrackColor(this Slider _) => Bindings.BindableProperty<Color>.Create(Slider.MaximumTrackColorProperty);
    public static Bindings.BindableProperty<double> BindMinimum(this Slider _) => Bindings.BindableProperty<double>.Create(Slider.MinimumProperty);
    public static Bindings.BindableProperty<Color> BindMinimumTrackColor(this Slider _) => Bindings.BindableProperty<Color>.Create(Slider.MinimumTrackColorProperty);
    public static Bindings.BindableProperty<Color> BindThumbColor(this Slider _) => Bindings.BindableProperty<Color>.Create(Slider.ThumbColorProperty);
    public static Bindings.BindableProperty<ImageSource> BindThumbImageSource(this Slider _) => Bindings.BindableProperty<ImageSource>.Create(Slider.ThumbImageSourceProperty);
    public static Bindings.BindableProperty<double> BindValue(this Slider _) => Bindings.BindableProperty<double>.Create(Slider.ValueProperty);

    // SolidColorBrush Bindings

    public static Bindings.BindableProperty<Color> BindColor(this SolidColorBrush _) => Bindings.BindableProperty<Color>.Create(SolidColorBrush.ColorProperty);

    // Span Bindings

    public static Bindings.BindableProperty<Color> BindBackgroundColor(this Span _) => Bindings.BindableProperty<Color>.Create(Span.BackgroundColorProperty);
    public static Bindings.BindableProperty<double> BindCharacterSpacing(this Span _) => Bindings.BindableProperty<double>.Create(Span.CharacterSpacingProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this Span _) => Bindings.BindableProperty<FontAttributes>.Create(Span.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this Span _) => Bindings.BindableProperty<bool>.Create(Span.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this Span _) => Bindings.BindableProperty<string>.Create(Span.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this Span _) => Bindings.BindableProperty<double>.Create(Span.FontSizeProperty);
    public static Bindings.BindableProperty<double> BindLineHeight(this Span _) => Bindings.BindableProperty<double>.Create(Span.LineHeightProperty);
    public static Bindings.BindableProperty<Style> BindStyle(this Span _) => Bindings.BindableProperty<Style>.Create(Span.StyleProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this Span _) => Bindings.BindableProperty<Color>.Create(Span.TextColorProperty);
    public static Bindings.BindableProperty<TextDecorations> BindTextDecorations(this Span _) => Bindings.BindableProperty<TextDecorations>.Create(Span.TextDecorationsProperty);
    public static Bindings.BindableProperty<string> BindText(this Span _) => Bindings.BindableProperty<string>.Create(Span.TextProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this Span _) => Bindings.BindableProperty<TextTransform>.Create(Span.TextTransformProperty);

    // StackBase Bindings

    public static Bindings.BindableProperty<double> BindSpacing(this StackBase _) => Bindings.BindableProperty<double>.Create(StackBase.SpacingProperty);

    // StackLayout Bindings

    public static Bindings.BindableProperty<StackOrientation> BindOrientation(this StackLayout _) => Bindings.BindableProperty<StackOrientation>.Create(StackLayout.OrientationProperty);
    public static Bindings.BindableProperty<double> BindSpacing(this StackLayout _) => Bindings.BindableProperty<double>.Create(StackLayout.SpacingProperty);

    // StateTrigger Bindings

    public static Bindings.BindableProperty<bool> BindIsActive(this StateTrigger _) => Bindings.BindableProperty<bool>.Create(StateTrigger.IsActiveProperty);

    // Stepper Bindings

    public static Bindings.BindableProperty<double> BindIncrement(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.IncrementProperty);
    public static Bindings.BindableProperty<double> BindMaximum(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.MaximumProperty);
    public static Bindings.BindableProperty<double> BindMinimum(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.MinimumProperty);
    public static Bindings.BindableProperty<double> BindValue(this Stepper _) => Bindings.BindableProperty<double>.Create(Stepper.ValueProperty);

    // StreamImageSource Bindings

    public static Bindings.BindableProperty<Func<CancellationToken, Task<Stream>>> BindStream(this StreamImageSource _) => Bindings.BindableProperty<Func<CancellationToken, Task<Stream>>>.Create(StreamImageSource.StreamProperty);

    // StructuredItemsView Bindings

    public static Bindings.BindableProperty<object> BindFooter(this StructuredItemsView _) => Bindings.BindableProperty<object>.Create(StructuredItemsView.FooterProperty);
    public static Bindings.BindableProperty<DataTemplate> BindFooterTemplate(this StructuredItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(StructuredItemsView.FooterTemplateProperty);
    public static Bindings.BindableProperty<object> BindHeader(this StructuredItemsView _) => Bindings.BindableProperty<object>.Create(StructuredItemsView.HeaderProperty);
    public static Bindings.BindableProperty<DataTemplate> BindHeaderTemplate(this StructuredItemsView _) => Bindings.BindableProperty<DataTemplate>.Create(StructuredItemsView.HeaderTemplateProperty);
    public static Bindings.BindableProperty<ItemSizingStrategy> BindItemSizingStrategy(this StructuredItemsView _) => Bindings.BindableProperty<ItemSizingStrategy>.Create(StructuredItemsView.ItemSizingStrategyProperty);
    public static Bindings.BindableProperty<IItemsLayout> BindItemsLayout(this StructuredItemsView _) => Bindings.BindableProperty<IItemsLayout>.Create(StructuredItemsView.ItemsLayoutProperty);

    // SwipeGestureRecognizer Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this SwipeGestureRecognizer _) => Bindings.BindableProperty<object>.Create(SwipeGestureRecognizer.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this SwipeGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(SwipeGestureRecognizer.CommandProperty);
    public static Bindings.BindableProperty<SwipeDirection> BindDirection(this SwipeGestureRecognizer _) => Bindings.BindableProperty<SwipeDirection>.Create(SwipeGestureRecognizer.DirectionProperty);
    public static Bindings.BindableProperty<UInt32> BindThreshold(this SwipeGestureRecognizer _) => Bindings.BindableProperty<UInt32>.Create(SwipeGestureRecognizer.ThresholdProperty);

    // SwipeItem Bindings

    public static Bindings.BindableProperty<Color> BindBackgroundColor(this SwipeItem _) => Bindings.BindableProperty<Color>.Create(SwipeItem.BackgroundColorProperty);
    public static Bindings.BindableProperty<bool> BindIsVisible(this SwipeItem _) => Bindings.BindableProperty<bool>.Create(SwipeItem.IsVisibleProperty);

    // SwipeItems Bindings

    public static Bindings.BindableProperty<SwipeMode> BindMode(this SwipeItems _) => Bindings.BindableProperty<SwipeMode>.Create(SwipeItems.ModeProperty);
    public static Bindings.BindableProperty<SwipeBehaviorOnInvoked> BindSwipeBehaviorOnInvoked(this SwipeItems _) => Bindings.BindableProperty<SwipeBehaviorOnInvoked>.Create(SwipeItems.SwipeBehaviorOnInvokedProperty);

    // SwipeItemView Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this SwipeItemView _) => Bindings.BindableProperty<object>.Create(SwipeItemView.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this SwipeItemView _) => Bindings.BindableProperty<ICommand>.Create(SwipeItemView.CommandProperty);

    // SwipeView Bindings

    public static Bindings.BindableProperty<SwipeItems> BindBottomItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.BottomItemsProperty);
    public static Bindings.BindableProperty<SwipeItems> BindLeftItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.LeftItemsProperty);
    public static Bindings.BindableProperty<SwipeItems> BindRightItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.RightItemsProperty);
    public static Bindings.BindableProperty<double> BindThreshold(this SwipeView _) => Bindings.BindableProperty<double>.Create(SwipeView.ThresholdProperty);
    public static Bindings.BindableProperty<SwipeItems> BindTopItems(this SwipeView _) => Bindings.BindableProperty<SwipeItems>.Create(SwipeView.TopItemsProperty);

    // Switch Bindings

    public static Bindings.BindableProperty<bool> BindIsToggled(this Switch _) => Bindings.BindableProperty<bool>.Create(Switch.IsToggledProperty);
    public static Bindings.BindableProperty<Color> BindOnColor(this Switch _) => Bindings.BindableProperty<Color>.Create(Switch.OnColorProperty);
    public static Bindings.BindableProperty<Color> BindThumbColor(this Switch _) => Bindings.BindableProperty<Color>.Create(Switch.ThumbColorProperty);

    // SwitchCell Bindings

    public static Bindings.BindableProperty<Color> BindOnColor(this SwitchCell _) => Bindings.BindableProperty<Color>.Create(SwitchCell.OnColorProperty);
    public static Bindings.BindableProperty<bool> BindOn(this SwitchCell _) => Bindings.BindableProperty<bool>.Create(SwitchCell.OnProperty);
    public static Bindings.BindableProperty<string> BindText(this SwitchCell _) => Bindings.BindableProperty<string>.Create(SwitchCell.TextProperty);

    // TabbedPage Bindings

    public static Bindings.BindableProperty<Color> BindBarBackgroundColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.BarBackgroundColorProperty);
    public static Bindings.BindableProperty<Brush> BindBarBackground(this TabbedPage _) => Bindings.BindableProperty<Brush>.Create(TabbedPage.BarBackgroundProperty);
    public static Bindings.BindableProperty<Color> BindBarTextColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.BarTextColorProperty);
    public static Bindings.BindableProperty<Color> BindSelectedTabColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.SelectedTabColorProperty);
    public static Bindings.BindableProperty<Color> BindUnselectedTabColor(this TabbedPage _) => Bindings.BindableProperty<Color>.Create(TabbedPage.UnselectedTabColorProperty);

    // TableSectionBase Bindings

    public static Bindings.BindableProperty<Color> BindTextColor(this TableSectionBase _) => Bindings.BindableProperty<Color>.Create(TableSectionBase.TextColorProperty);
    public static Bindings.BindableProperty<string> BindTitle(this TableSectionBase _) => Bindings.BindableProperty<string>.Create(TableSectionBase.TitleProperty);

    // TableView Bindings

    public static Bindings.BindableProperty<bool> BindHasUnevenRows(this TableView _) => Bindings.BindableProperty<bool>.Create(TableView.HasUnevenRowsProperty);
    public static Bindings.BindableProperty<int> BindRowHeight(this TableView _) => Bindings.BindableProperty<int>.Create(TableView.RowHeightProperty);

    // TapGestureRecognizer Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this TapGestureRecognizer _) => Bindings.BindableProperty<object>.Create(TapGestureRecognizer.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this TapGestureRecognizer _) => Bindings.BindableProperty<ICommand>.Create(TapGestureRecognizer.CommandProperty);
    public static Bindings.BindableProperty<int> BindNumberOfTapsRequired(this TapGestureRecognizer _) => Bindings.BindableProperty<int>.Create(TapGestureRecognizer.NumberOfTapsRequiredProperty);

    // TemplatedPage Bindings

    public static Bindings.BindableProperty<ControlTemplate> BindControlTemplate(this TemplatedPage _) => Bindings.BindableProperty<ControlTemplate>.Create(TemplatedPage.ControlTemplateProperty);

    // TemplatedView Bindings

    public static Bindings.BindableProperty<ControlTemplate> BindControlTemplate(this TemplatedView _) => Bindings.BindableProperty<ControlTemplate>.Create(TemplatedView.ControlTemplateProperty);

    // TextCell Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this TextCell _) => Bindings.BindableProperty<object>.Create(TextCell.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this TextCell _) => Bindings.BindableProperty<ICommand>.Create(TextCell.CommandProperty);
    public static Bindings.BindableProperty<Color> BindDetailColor(this TextCell _) => Bindings.BindableProperty<Color>.Create(TextCell.DetailColorProperty);
    public static Bindings.BindableProperty<string> BindDetail(this TextCell _) => Bindings.BindableProperty<string>.Create(TextCell.DetailProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this TextCell _) => Bindings.BindableProperty<Color>.Create(TextCell.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this TextCell _) => Bindings.BindableProperty<string>.Create(TextCell.TextProperty);

    // TimePicker Bindings

    public static Bindings.BindableProperty<double> BindCharacterSpacing(this TimePicker _) => Bindings.BindableProperty<double>.Create(TimePicker.CharacterSpacingProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this TimePicker _) => Bindings.BindableProperty<FontAttributes>.Create(TimePicker.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this TimePicker _) => Bindings.BindableProperty<bool>.Create(TimePicker.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this TimePicker _) => Bindings.BindableProperty<string>.Create(TimePicker.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this TimePicker _) => Bindings.BindableProperty<double>.Create(TimePicker.FontSizeProperty);
    public static Bindings.BindableProperty<string> BindFormat(this TimePicker _) => Bindings.BindableProperty<string>.Create(TimePicker.FormatProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this TimePicker _) => Bindings.BindableProperty<Color>.Create(TimePicker.TextColorProperty);
    public static Bindings.BindableProperty<TimeSpan> BindTime(this TimePicker _) => Bindings.BindableProperty<TimeSpan>.Create(TimePicker.TimeProperty);

    // Transform Bindings

    public static Bindings.BindableProperty<Matrix> BindValue(this Transform _) => Bindings.BindableProperty<Matrix>.Create(Transform.ValueProperty);

    // TransformGroup Bindings

    public static Bindings.BindableProperty<TransformCollection> BindChildren(this TransformGroup _) => Bindings.BindableProperty<TransformCollection>.Create(TransformGroup.ChildrenProperty);

    // TranslateTransform Bindings

    public static Bindings.BindableProperty<double> BindX(this TranslateTransform _) => Bindings.BindableProperty<double>.Create(TranslateTransform.XProperty);
    public static Bindings.BindableProperty<double> BindY(this TranslateTransform _) => Bindings.BindableProperty<double>.Create(TranslateTransform.YProperty);

    // UriImageSource Bindings

    public static Bindings.BindableProperty<TimeSpan> BindCacheValidity(this UriImageSource _) => Bindings.BindableProperty<TimeSpan>.Create(UriImageSource.CacheValidityProperty);
    public static Bindings.BindableProperty<bool> BindCachingEnabled(this UriImageSource _) => Bindings.BindableProperty<bool>.Create(UriImageSource.CachingEnabledProperty);
    public static Bindings.BindableProperty<Uri> BindUri(this UriImageSource _) => Bindings.BindableProperty<Uri>.Create(UriImageSource.UriProperty);

    // UrlWebViewSource Bindings

    public static Bindings.BindableProperty<string> BindUrl(this UrlWebViewSource _) => Bindings.BindableProperty<string>.Create(UrlWebViewSource.UrlProperty);

    // View Bindings

    public static Bindings.BindableProperty<LayoutOptions> BindHorizontalOptions(this View _) => Bindings.BindableProperty<LayoutOptions>.Create(View.HorizontalOptionsProperty);
    public static Bindings.BindableProperty<Thickness> BindMargin(this View _) => Bindings.BindableProperty<Thickness>.Create(View.MarginProperty);
    public static Bindings.BindableProperty<LayoutOptions> BindVerticalOptions(this View _) => Bindings.BindableProperty<LayoutOptions>.Create(View.VerticalOptionsProperty);

    // VisualElement Bindings

    public static Bindings.BindableProperty<double> BindAnchorX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.AnchorXProperty);
    public static Bindings.BindableProperty<double> BindAnchorY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.AnchorYProperty);
    public static Bindings.BindableProperty<Color> BindBackgroundColor(this VisualElement _) => Bindings.BindableProperty<Color>.Create(VisualElement.BackgroundColorProperty);
    public static Bindings.BindableProperty<Brush> BindBackground(this VisualElement _) => Bindings.BindableProperty<Brush>.Create(VisualElement.BackgroundProperty);
    public static Bindings.BindableProperty<IList<Behavior>> BindBehaviors(this VisualElement _) => Bindings.BindableProperty<IList<Behavior>>.Create(VisualElement.BehaviorsProperty);
    public static Bindings.BindableProperty<Geometry> BindClip(this VisualElement _) => Bindings.BindableProperty<Geometry>.Create(VisualElement.ClipProperty);
    public static Bindings.BindableProperty<FlowDirection> BindFlowDirection(this VisualElement _) => Bindings.BindableProperty<FlowDirection>.Create(VisualElement.FlowDirectionProperty);
    public static Bindings.BindableProperty<double> BindHeight(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.HeightProperty);
    public static Bindings.BindableProperty<double> BindHeightRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.HeightRequestProperty);
    public static Bindings.BindableProperty<bool> BindInputTransparent(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.InputTransparentProperty);
    public static Bindings.BindableProperty<bool> BindIsEnabled(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.IsEnabledProperty);
    public static Bindings.BindableProperty<bool> BindIsFocused(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.IsFocusedProperty);
    public static Bindings.BindableProperty<bool> BindIsVisible(this VisualElement _) => Bindings.BindableProperty<bool>.Create(VisualElement.IsVisibleProperty);
    public static Bindings.BindableProperty<double> BindMaximumHeightRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MaximumHeightRequestProperty);
    public static Bindings.BindableProperty<double> BindMaximumWidthRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MaximumWidthRequestProperty);
    public static Bindings.BindableProperty<double> BindMinimumHeightRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MinimumHeightRequestProperty);
    public static Bindings.BindableProperty<double> BindMinimumWidthRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.MinimumWidthRequestProperty);
    public static Bindings.BindableProperty<INavigation> BindNavigation(this VisualElement _) => Bindings.BindableProperty<INavigation>.Create(VisualElement.NavigationProperty);
    public static Bindings.BindableProperty<double> BindOpacity(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.OpacityProperty);
    public static Bindings.BindableProperty<double> BindRotation(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.RotationProperty);
    public static Bindings.BindableProperty<double> BindRotationX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.RotationXProperty);
    public static Bindings.BindableProperty<double> BindRotationY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.RotationYProperty);
    public static Bindings.BindableProperty<double> BindScale(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.ScaleProperty);
    public static Bindings.BindableProperty<double> BindScaleX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.ScaleXProperty);
    public static Bindings.BindableProperty<double> BindScaleY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.ScaleYProperty);
    public static Bindings.BindableProperty<Shadow> BindShadow(this VisualElement _) => Bindings.BindableProperty<Shadow>.Create(VisualElement.ShadowProperty);
    public static Bindings.BindableProperty<Style> BindStyle(this VisualElement _) => Bindings.BindableProperty<Style>.Create(VisualElement.StyleProperty);
    public static Bindings.BindableProperty<double> BindTranslationX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.TranslationXProperty);
    public static Bindings.BindableProperty<double> BindTranslationY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.TranslationYProperty);
    public static Bindings.BindableProperty<IList<TriggerBase>> BindTriggers(this VisualElement _) => Bindings.BindableProperty<IList<TriggerBase>>.Create(VisualElement.TriggersProperty);
    public static Bindings.BindableProperty<IVisual> BindVisual(this VisualElement _) => Bindings.BindableProperty<IVisual>.Create(VisualElement.VisualProperty);
    public static Bindings.BindableProperty<double> BindWidth(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.WidthProperty);
    public static Bindings.BindableProperty<double> BindWidthRequest(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.WidthRequestProperty);
    public static Bindings.BindableProperty<Window> BindWindow(this VisualElement _) => Bindings.BindableProperty<Window>.Create(VisualElement.WindowProperty);
    public static Bindings.BindableProperty<double> BindX(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.XProperty);
    public static Bindings.BindableProperty<double> BindY(this VisualElement _) => Bindings.BindableProperty<double>.Create(VisualElement.YProperty);

    // WebView Bindings

    public static Bindings.BindableProperty<bool> BindCanGoBack(this WebView _) => Bindings.BindableProperty<bool>.Create(WebView.CanGoBackProperty);
    public static Bindings.BindableProperty<bool> BindCanGoForward(this WebView _) => Bindings.BindableProperty<bool>.Create(WebView.CanGoForwardProperty);
    public static Bindings.BindableProperty<CookieContainer> BindCookies(this WebView _) => Bindings.BindableProperty<CookieContainer>.Create(WebView.CookiesProperty);
    public static Bindings.BindableProperty<WebViewSource> BindSource(this WebView _) => Bindings.BindableProperty<WebViewSource>.Create(WebView.SourceProperty);

    // Window Bindings

    public static Bindings.BindableProperty<FlowDirection> BindFlowDirection(this Window _) => Bindings.BindableProperty<FlowDirection>.Create(Window.FlowDirectionProperty);
    public static Bindings.BindableProperty<Page> BindPage(this Window _) => Bindings.BindableProperty<Page>.Create(Window.PageProperty);
    public static Bindings.BindableProperty<string> BindTitle(this Window _) => Bindings.BindableProperty<string>.Create(Window.TitleProperty);
}
