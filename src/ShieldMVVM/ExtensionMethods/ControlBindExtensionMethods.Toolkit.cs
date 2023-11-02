using CommunityToolkit.Maui.Animations;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.ImageSources;
using CommunityToolkit.Maui.Layouts;
using CommunityToolkit.Maui.Views;
using System.Collections;
using System.Collections.ObjectModel;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace CoreBTS.Maui.ShieldMVVM.ExtensionMethods;

public static partial class ControlBindExtensionMethods
{
    // AnimationBehavior Bindings

    public static Bindings.BindableProperty<ICommand> BindAnimateCommand(this AnimationBehavior _) => Bindings.BindableProperty<ICommand>.Create(AnimationBehavior.AnimateCommandProperty);
    public static Bindings.BindableProperty<BaseAnimation> BindAnimationType(this AnimationBehavior _) => Bindings.BindableProperty<BaseAnimation>.Create(AnimationBehavior.AnimationTypeProperty);

    // AvatarView Bindings

    public static Bindings.BindableProperty<Color> BindBorderColor(this AvatarView _) => Bindings.BindableProperty<Color>.Create(AvatarView.BorderColorProperty);
    public static Bindings.BindableProperty<double> BindBorderWidth(this AvatarView _) => Bindings.BindableProperty<double>.Create(AvatarView.BorderWidthProperty);
    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this AvatarView _) => Bindings.BindableProperty<CornerRadius>.Create(AvatarView.CornerRadiusProperty);
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this AvatarView _) => Bindings.BindableProperty<FontAttributes>.Create(AvatarView.FontAttributesProperty);
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this AvatarView _) => Bindings.BindableProperty<bool>.Create(AvatarView.FontAutoScalingEnabledProperty);
    public static Bindings.BindableProperty<string> BindFontFamily(this AvatarView _) => Bindings.BindableProperty<string>.Create(AvatarView.FontFamilyProperty);
    public static Bindings.BindableProperty<double> BindFontSize(this AvatarView _) => Bindings.BindableProperty<double>.Create(AvatarView.FontSizeProperty);
    public static Bindings.BindableProperty<ImageSource> BindImageSource(this AvatarView _) => Bindings.BindableProperty<ImageSource>.Create(AvatarView.ImageSourceProperty);
    public static Bindings.BindableProperty<Color> BindTextColor(this AvatarView _) => Bindings.BindableProperty<Color>.Create(AvatarView.TextColorProperty);
    public static Bindings.BindableProperty<string> BindText(this AvatarView _) => Bindings.BindableProperty<string>.Create(AvatarView.TextProperty);
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this AvatarView _) => Bindings.BindableProperty<TextTransform>.Create(AvatarView.TextTransformProperty);

    // CharactersValidationBehavior Bindings

    public static Bindings.BindableProperty<CharacterType> BindCharacterType(this CharactersValidationBehavior _) => Bindings.BindableProperty<CharacterType>.Create(CharactersValidationBehavior.CharacterTypeProperty);
    public static Bindings.BindableProperty<int> BindMaximumCharacterTypeCount(this CharactersValidationBehavior _) => Bindings.BindableProperty<int>.Create(CharactersValidationBehavior.MaximumCharacterTypeCountProperty);
    public static Bindings.BindableProperty<int> BindMinimumCharacterTypeCount(this CharactersValidationBehavior _) => Bindings.BindableProperty<int>.Create(CharactersValidationBehavior.MinimumCharacterTypeCountProperty);

    // DockLayout Bindings

    public static Bindings.BindableProperty<DockPosition> BindDockPosition(this DockLayout _) => Bindings.BindableProperty<DockPosition>.Create(DockLayout.DockPositionProperty);
    public static Bindings.BindableProperty<double> BindHorizontalSpacing(this DockLayout _) => Bindings.BindableProperty<double>.Create(DockLayout.HorizontalSpacingProperty);
    public static Bindings.BindableProperty<bool> BindShouldExpandLastChild(this DockLayout _) => Bindings.BindableProperty<bool>.Create(DockLayout.ShouldExpandLastChildProperty);
    public static Bindings.BindableProperty<double> BindVerticalSpacing(this DockLayout _) => Bindings.BindableProperty<double>.Create(DockLayout.VerticalSpacingProperty);

    // DrawingView Bindings

    public static Bindings.BindableProperty<Action<RectF>> BindDrawAction(this DrawingView _) => Bindings.BindableProperty<Action<RectF>>.Create(DrawingView.DrawActionProperty);
    public static Bindings.BindableProperty<ICommand> BindDrawingLineCompletedCommand(this DrawingView _) => Bindings.BindableProperty<ICommand>.Create(DrawingView.DrawingLineCompletedCommandProperty);
    public static Bindings.BindableProperty<bool> BindIsMultiLineModeEnabled(this DrawingView _) => Bindings.BindableProperty<bool>.Create(DrawingView.IsMultiLineModeEnabledProperty);
    public static Bindings.BindableProperty<Color> BindLineColor(this DrawingView _) => Bindings.BindableProperty<Color>.Create(DrawingView.LineColorProperty);
    public static Bindings.BindableProperty<ObservableCollection<IDrawingLine>> BindLines(this DrawingView _) => Bindings.BindableProperty<ObservableCollection<IDrawingLine>>.Create(DrawingView.LinesProperty);
    public static Bindings.BindableProperty<float> BindLineWidth(this DrawingView _) => Bindings.BindableProperty<float>.Create(DrawingView.LineWidthProperty);
    public static Bindings.BindableProperty<bool> BindShouldClearOnFinish(this DrawingView _) => Bindings.BindableProperty<bool>.Create(DrawingView.ShouldClearOnFinishProperty);

    // EventToCommandBehavior Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this EventToCommandBehavior _) => Bindings.BindableProperty<object>.Create(EventToCommandBehavior.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this EventToCommandBehavior _) => Bindings.BindableProperty<ICommand>.Create(EventToCommandBehavior.CommandProperty);
    public static Bindings.BindableProperty<IValueConverter> BindEventArgsConverter(this EventToCommandBehavior _) => Bindings.BindableProperty<IValueConverter>.Create(EventToCommandBehavior.EventArgsConverterProperty);
    public static Bindings.BindableProperty<string> BindEventName(this EventToCommandBehavior _) => Bindings.BindableProperty<string>.Create(EventToCommandBehavior.EventNameProperty);

    // Expander Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this Expander _) => Bindings.BindableProperty<object>.Create(Expander.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this Expander _) => Bindings.BindableProperty<ICommand>.Create(Expander.CommandProperty);
    public static Bindings.BindableProperty<IView> BindContent(this Expander _) => Bindings.BindableProperty<IView>.Create(Expander.ContentProperty);
    public static Bindings.BindableProperty<ExpandDirection> BindDirection(this Expander _) => Bindings.BindableProperty<ExpandDirection>.Create(Expander.DirectionProperty);
    public static Bindings.BindableProperty<IView> BindHeader(this Expander _) => Bindings.BindableProperty<IView>.Create(Expander.HeaderProperty);
    public static Bindings.BindableProperty<bool> BindIsExpanded(this Expander _) => Bindings.BindableProperty<bool>.Create(Expander.IsExpandedProperty);

    // FadeAnimation Bindings

    public static Bindings.BindableProperty<double> BindOpacity(this FadeAnimation _) => Bindings.BindableProperty<double>.Create(FadeAnimation.OpacityProperty);

    // GravatarImageSource Bindings

    public static Bindings.BindableProperty<TimeSpan> BindCacheValidity(this GravatarImageSource _) => Bindings.BindableProperty<TimeSpan>.Create(GravatarImageSource.CacheValidityProperty);
    public static Bindings.BindableProperty<bool> BindCachingEnabled(this GravatarImageSource _) => Bindings.BindableProperty<bool>.Create(GravatarImageSource.CachingEnabledProperty);
    public static Bindings.BindableProperty<string> BindEmail(this GravatarImageSource _) => Bindings.BindableProperty<string>.Create(GravatarImageSource.EmailProperty);
    public static Bindings.BindableProperty<DefaultImage> BindImage(this GravatarImageSource _) => Bindings.BindableProperty<DefaultImage>.Create(GravatarImageSource.ImageProperty);

    // IconTintColorBehavior Bindings

    public static Bindings.BindableProperty<Color> BindTintColor(this IconTintColorBehavior _) => Bindings.BindableProperty<Color>.Create(IconTintColorBehavior.TintColorProperty);

    // LazyView Bindings

    public static Bindings.BindableProperty<bool> BindHasLazyViewLoaded(this LazyView _) => Bindings.BindableProperty<bool>.Create(LazyView.HasLazyViewLoadedProperty);

    // MaskedBehavior Bindings

    public static Bindings.BindableProperty<string> BindMask(this MaskedBehavior _) => Bindings.BindableProperty<string>.Create(MaskedBehavior.MaskProperty);
    public static Bindings.BindableProperty<Char> BindUnmaskedCharacter(this MaskedBehavior _) => Bindings.BindableProperty<Char>.Create(MaskedBehavior.UnmaskedCharacterProperty);

    // MaxLengthReachedBehavior Bindings

    public static Bindings.BindableProperty<ICommand> BindCommand(this MaxLengthReachedBehavior _) => Bindings.BindableProperty<ICommand>.Create(MaxLengthReachedBehavior.CommandProperty);
    public static Bindings.BindableProperty<bool> BindShouldDismissKeyboardAutomatically(this MaxLengthReachedBehavior _) => Bindings.BindableProperty<bool>.Create(MaxLengthReachedBehavior.ShouldDismissKeyboardAutomaticallyProperty);

    // MultiValidationBehavior Bindings

    public static Bindings.BindableProperty<object> BindError(this MultiValidationBehavior _) => Bindings.BindableProperty<object>.Create(MultiValidationBehavior.ErrorProperty);
    public static Bindings.BindableProperty<List<object>> BindErrors(this MultiValidationBehavior _) => Bindings.BindableProperty<List<object>>.Create(MultiValidationBehavior.ErrorsProperty);

    // NumericValidationBehavior Bindings

    public static Bindings.BindableProperty<int> BindMaximumDecimalPlaces(this NumericValidationBehavior _) => Bindings.BindableProperty<int>.Create(NumericValidationBehavior.MaximumDecimalPlacesProperty);
    public static Bindings.BindableProperty<double> BindMaximumValue(this NumericValidationBehavior _) => Bindings.BindableProperty<double>.Create(NumericValidationBehavior.MaximumValueProperty);
    public static Bindings.BindableProperty<int> BindMinimumDecimalPlaces(this NumericValidationBehavior _) => Bindings.BindableProperty<int>.Create(NumericValidationBehavior.MinimumDecimalPlacesProperty);
    public static Bindings.BindableProperty<double> BindMinimumValue(this NumericValidationBehavior _) => Bindings.BindableProperty<double>.Create(NumericValidationBehavior.MinimumValueProperty);

    // Popup Bindings

    public static Bindings.BindableProperty<bool> BindCanBeDismissedByTappingOutsideOfPopup(this Popup _) => Bindings.BindableProperty<bool>.Create(Popup.CanBeDismissedByTappingOutsideOfPopupProperty);
    public static Bindings.BindableProperty<Color> BindColor(this Popup _) => Bindings.BindableProperty<Color>.Create(Popup.ColorProperty);
    public static Bindings.BindableProperty<View> BindContent(this Popup _) => Bindings.BindableProperty<View>.Create(Popup.ContentProperty);
    public static Bindings.BindableProperty<LayoutAlignment> BindHorizontalOptions(this Popup _) => Bindings.BindableProperty<LayoutAlignment>.Create(Popup.HorizontalOptionsProperty);
    public static Bindings.BindableProperty<Size> BindSize(this Popup _) => Bindings.BindableProperty<Size>.Create(Popup.SizeProperty);
    public static Bindings.BindableProperty<LayoutAlignment> BindVerticalOptions(this Popup _) => Bindings.BindableProperty<LayoutAlignment>.Create(Popup.VerticalOptionsProperty);

    // ProgressBarAnimationBehavior Bindings

    public static Bindings.BindableProperty<Easing> BindEasing(this ProgressBarAnimationBehavior _) => Bindings.BindableProperty<Easing>.Create(ProgressBarAnimationBehavior.EasingProperty);
    public static Bindings.BindableProperty<UInt32> BindLength(this ProgressBarAnimationBehavior _) => Bindings.BindableProperty<UInt32>.Create(ProgressBarAnimationBehavior.LengthProperty);
    public static Bindings.BindableProperty<double> BindProgress(this ProgressBarAnimationBehavior _) => Bindings.BindableProperty<double>.Create(ProgressBarAnimationBehavior.ProgressProperty);

    // RequiredStringValidationBehavior Bindings

    public static Bindings.BindableProperty<bool> BindExactMatch(this RequiredStringValidationBehavior _) => Bindings.BindableProperty<bool>.Create(RequiredStringValidationBehavior.ExactMatchProperty);
    public static Bindings.BindableProperty<string> BindRequiredString(this RequiredStringValidationBehavior _) => Bindings.BindableProperty<string>.Create(RequiredStringValidationBehavior.RequiredStringProperty);

    // SemanticOrderView Bindings

    public static Bindings.BindableProperty<IEnumerable> BindViewOrder(this SemanticOrderView _) => Bindings.BindableProperty<IEnumerable>.Create(SemanticOrderView.ViewOrderProperty);

    // SetFocusOnEntryCompletedBehavior Bindings

    public static Bindings.BindableProperty<VisualElement> BindNextElement(this SetFocusOnEntryCompletedBehavior _) => Bindings.BindableProperty<VisualElement>.Create(SetFocusOnEntryCompletedBehavior.NextElementProperty);

    // TextValidationBehavior Bindings

    public static Bindings.BindableProperty<TextDecorationFlags> BindDecorationFlags(this TextValidationBehavior _) => Bindings.BindableProperty<TextDecorationFlags>.Create(TextValidationBehavior.DecorationFlagsProperty);
    public static Bindings.BindableProperty<int> BindMaximumLength(this TextValidationBehavior _) => Bindings.BindableProperty<int>.Create(TextValidationBehavior.MaximumLengthProperty);
    public static Bindings.BindableProperty<int> BindMinimumLength(this TextValidationBehavior _) => Bindings.BindableProperty<int>.Create(TextValidationBehavior.MinimumLengthProperty);
    public static Bindings.BindableProperty<RegexOptions> BindRegexOptions(this TextValidationBehavior _) => Bindings.BindableProperty<RegexOptions>.Create(TextValidationBehavior.RegexOptionsProperty);
    public static Bindings.BindableProperty<string> BindRegexPattern(this TextValidationBehavior _) => Bindings.BindableProperty<string>.Create(TextValidationBehavior.RegexPatternProperty);

    // UniformItemsLayout Bindings

    public static Bindings.BindableProperty<int> BindMaxColumns(this UniformItemsLayout _) => Bindings.BindableProperty<int>.Create(UniformItemsLayout.MaxColumnsProperty);
    public static Bindings.BindableProperty<int> BindMaxRows(this UniformItemsLayout _) => Bindings.BindableProperty<int>.Create(UniformItemsLayout.MaxRowsProperty);

    // UriValidationBehavior Bindings

    public static Bindings.BindableProperty<UriKind> BindUriKind(this UriValidationBehavior _) => Bindings.BindableProperty<UriKind>.Create(UriValidationBehavior.UriKindProperty);

    // UserStoppedTypingBehavior Bindings

    public static Bindings.BindableProperty<object> BindCommandParameter(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<object>.Create(UserStoppedTypingBehavior.CommandParameterProperty);
    public static Bindings.BindableProperty<ICommand> BindCommand(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<ICommand>.Create(UserStoppedTypingBehavior.CommandProperty);
    public static Bindings.BindableProperty<int> BindMinimumLengthThreshold(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<int>.Create(UserStoppedTypingBehavior.MinimumLengthThresholdProperty);
    public static Bindings.BindableProperty<bool> BindShouldDismissKeyboardAutomatically(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<bool>.Create(UserStoppedTypingBehavior.ShouldDismissKeyboardAutomaticallyProperty);
    public static Bindings.BindableProperty<int> BindStoppedTypingTimeThreshold(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<int>.Create(UserStoppedTypingBehavior.StoppedTypingTimeThresholdProperty);

    // ValidationBehavior Bindings

    public static Bindings.BindableProperty<ValidationFlags> BindFlags(this ValidationBehavior _) => Bindings.BindableProperty<ValidationFlags>.Create(ValidationBehavior.FlagsProperty);
    public static Bindings.BindableProperty<ICommand> BindForceValidateCommand(this ValidationBehavior _) => Bindings.BindableProperty<ICommand>.Create(ValidationBehavior.ForceValidateCommandProperty);
    public static Bindings.BindableProperty<Style> BindInvalidStyle(this ValidationBehavior _) => Bindings.BindableProperty<Style>.Create(ValidationBehavior.InvalidStyleProperty);
    public static Bindings.BindableProperty<bool> BindIsNotValid(this ValidationBehavior _) => Bindings.BindableProperty<bool>.Create(ValidationBehavior.IsNotValidProperty);
    public static Bindings.BindableProperty<bool> BindIsRunning(this ValidationBehavior _) => Bindings.BindableProperty<bool>.Create(ValidationBehavior.IsRunningProperty);
    public static Bindings.BindableProperty<bool> BindIsValid(this ValidationBehavior _) => Bindings.BindableProperty<bool>.Create(ValidationBehavior.IsValidProperty);
    public static Bindings.BindableProperty<Style> BindValidStyle(this ValidationBehavior _) => Bindings.BindableProperty<Style>.Create(ValidationBehavior.ValidStyleProperty);
    public static Bindings.BindableProperty<object> BindValue(this ValidationBehavior _) => Bindings.BindableProperty<object>.Create(ValidationBehavior.ValueProperty);
    public static Bindings.BindableProperty<string> BindValueName(this ValidationBehavior _) => Bindings.BindableProperty<string>.Create(ValidationBehavior.ValuePropertyNameProperty);
}