using CommunityToolkit.Maui.Animations;
using CommunityToolkit.Maui.Behaviors;
using CommunityToolkit.Maui.Core;
using CommunityToolkit.Maui.ImageSources;
using CommunityToolkit.Maui.Layouts;
using CommunityToolkit.Maui.Views;
using System.Collections;
using System.Text.RegularExpressions;
using System.Windows.Input;

namespace CoreBTS.Maui.ShieldMVVM;

/// <summary>
/// This class stores all the Bind* extension methods for generic BindableProperty.
/// </summary>
public static partial class ControlBindExtensionMethods
{
    // ***** ClickableControl Bindings *****

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this AvatarView _) => new(Controls.ClickableControl<AvatarView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the DockLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this DockLayout _) => new(Controls.ClickableControl<DockLayout>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the DrawingView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this DrawingView _) => new(Controls.ClickableControl<DrawingView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this Expander _) => new(Controls.ClickableControl<Expander>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the LazyView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this LazyView _) => new(Controls.ClickableControl<LazyView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the SemanticOrderView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this SemanticOrderView _) => new(Controls.ClickableControl<SemanticOrderView>.CommandProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindClick for the UniformItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ICommand.</returns>
    public static Bindings.BindableProperty<ICommand> BindClick(this UniformItemsLayout _) => new(Controls.ClickableControl<UniformItemsLayout>.CommandProperty);

    // ***** Start of Generated Bindings *****

    // ***** AnimationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the AnimateCommandProperty as BindAnimateCommand for the AnimationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AnimationBehavior.</returns>
    public static Bindings.BindableProperty<ICommand> BindAnimateCommand(this AnimationBehavior _) => Bindings.BindableProperty<ICommand>.Create(AnimationBehavior.AnimateCommandProperty);

    /// <summary>
    /// Allows binding to the AnimationTypeProperty as BindAnimationType for the AnimationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AnimationBehavior.</returns>
    public static Bindings.BindableProperty<BaseAnimation> BindAnimationType(this AnimationBehavior _) => Bindings.BindableProperty<BaseAnimation>.Create(AnimationBehavior.AnimationTypeProperty);

    // ***** AvatarView Bindings *****

    /// <summary>
    /// Allows binding to the BorderColorProperty as BindBorderColor for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<Color> BindBorderColor(this AvatarView _) => Bindings.BindableProperty<Color>.Create(AvatarView.BorderColorProperty);

    /// <summary>
    /// Allows binding to the BorderWidthProperty as BindBorderWidth for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<double> BindBorderWidth(this AvatarView _) => Bindings.BindableProperty<double>.Create(AvatarView.BorderWidthProperty);

    /// <summary>
    /// Allows binding to the CornerRadiusProperty as BindCornerRadius for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<CornerRadius> BindCornerRadius(this AvatarView _) => Bindings.BindableProperty<CornerRadius>.Create(AvatarView.CornerRadiusProperty);

    /// <summary>
    /// Allows binding to the FontAttributesProperty as BindFontAttributes for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<FontAttributes> BindFontAttributes(this AvatarView _) => Bindings.BindableProperty<FontAttributes>.Create(AvatarView.FontAttributesProperty);

    /// <summary>
    /// Allows binding to the FontAutoScalingEnabledProperty as BindFontAutoScalingEnabled for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<bool> BindFontAutoScalingEnabled(this AvatarView _) => Bindings.BindableProperty<bool>.Create(AvatarView.FontAutoScalingEnabledProperty);

    /// <summary>
    /// Allows binding to the FontFamilyProperty as BindFontFamily for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<string> BindFontFamily(this AvatarView _) => Bindings.BindableProperty<string>.Create(AvatarView.FontFamilyProperty);

    /// <summary>
    /// Allows binding to the FontSizeProperty as BindFontSize for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<double> BindFontSize(this AvatarView _) => Bindings.BindableProperty<double>.Create(AvatarView.FontSizeProperty);

    /// <summary>
    /// Allows binding to the ImageSourceProperty as BindImageSource for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<ImageSource> BindImageSource(this AvatarView _) => Bindings.BindableProperty<ImageSource>.Create(AvatarView.ImageSourceProperty);

    /// <summary>
    /// Allows binding to the TextColorProperty as BindTextColor for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<Color> BindTextColor(this AvatarView _) => Bindings.BindableProperty<Color>.Create(AvatarView.TextColorProperty);

    /// <summary>
    /// Allows binding to the TextProperty as BindText for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<string> BindText(this AvatarView _) => Bindings.BindableProperty<string>.Create(AvatarView.TextProperty);

    /// <summary>
    /// Allows binding to the TextTransformProperty as BindTextTransform for the AvatarView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type AvatarView.</returns>
    public static Bindings.BindableProperty<TextTransform> BindTextTransform(this AvatarView _) => Bindings.BindableProperty<TextTransform>.Create(AvatarView.TextTransformProperty);

    // ***** CharactersValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the CharacterTypeProperty as BindCharacterType for the CharactersValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CharactersValidationBehavior.</returns>
    public static Bindings.BindableProperty<CharacterType> BindCharacterType(this CharactersValidationBehavior _) => Bindings.BindableProperty<CharacterType>.Create(CharactersValidationBehavior.CharacterTypeProperty);

    /// <summary>
    /// Allows binding to the MaximumCharacterTypeCountProperty as BindMaximumCharacterTypeCount for the CharactersValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CharactersValidationBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMaximumCharacterTypeCount(this CharactersValidationBehavior _) => Bindings.BindableProperty<int>.Create(CharactersValidationBehavior.MaximumCharacterTypeCountProperty);

    /// <summary>
    /// Allows binding to the MinimumCharacterTypeCountProperty as BindMinimumCharacterTypeCount for the CharactersValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type CharactersValidationBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMinimumCharacterTypeCount(this CharactersValidationBehavior _) => Bindings.BindableProperty<int>.Create(CharactersValidationBehavior.MinimumCharacterTypeCountProperty);

    // ***** DockLayout Bindings *****

    /// <summary>
    /// Allows binding to the DockPositionProperty as BindDockPosition for the DockLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DockLayout.</returns>
    public static Bindings.BindableProperty<DockPosition> BindDockPosition(this DockLayout _) => Bindings.BindableProperty<DockPosition>.Create(DockLayout.DockPositionProperty);

    /// <summary>
    /// Allows binding to the HorizontalSpacingProperty as BindHorizontalSpacing for the DockLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DockLayout.</returns>
    public static Bindings.BindableProperty<double> BindHorizontalSpacing(this DockLayout _) => Bindings.BindableProperty<double>.Create(DockLayout.HorizontalSpacingProperty);

    /// <summary>
    /// Allows binding to the ShouldExpandLastChildProperty as BindShouldExpandLastChild for the DockLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DockLayout.</returns>
    public static Bindings.BindableProperty<bool> BindShouldExpandLastChild(this DockLayout _) => Bindings.BindableProperty<bool>.Create(DockLayout.ShouldExpandLastChildProperty);

    /// <summary>
    /// Allows binding to the VerticalSpacingProperty as BindVerticalSpacing for the DockLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type DockLayout.</returns>
    public static Bindings.BindableProperty<double> BindVerticalSpacing(this DockLayout _) => Bindings.BindableProperty<double>.Create(DockLayout.VerticalSpacingProperty);

    // ***** DrawingView Bindings *****

    // ***** EventToCommandBehavior Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the EventToCommandBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EventToCommandBehavior.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this EventToCommandBehavior _) => Bindings.BindableProperty<object>.Create(EventToCommandBehavior.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the EventToCommandBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EventToCommandBehavior.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this EventToCommandBehavior _) => Bindings.BindableProperty<ICommand>.Create(EventToCommandBehavior.CommandProperty);

    /// <summary>
    /// Allows binding to the EventArgsConverterProperty as BindEventArgsConverter for the EventToCommandBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EventToCommandBehavior.</returns>
    public static Bindings.BindableProperty<IValueConverter> BindEventArgsConverter(this EventToCommandBehavior _) => Bindings.BindableProperty<IValueConverter>.Create(EventToCommandBehavior.EventArgsConverterProperty);

    /// <summary>
    /// Allows binding to the EventNameProperty as BindEventName for the EventToCommandBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type EventToCommandBehavior.</returns>
    public static Bindings.BindableProperty<string> BindEventName(this EventToCommandBehavior _) => Bindings.BindableProperty<string>.Create(EventToCommandBehavior.EventNameProperty);

    // ***** Expander Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Expander.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this Expander _) => Bindings.BindableProperty<object>.Create(Expander.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Expander.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this Expander _) => Bindings.BindableProperty<ICommand>.Create(Expander.CommandProperty);

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Expander.</returns>
    public static Bindings.BindableProperty<IView> BindContent(this Expander _) => Bindings.BindableProperty<IView>.Create(Expander.ContentProperty);

    /// <summary>
    /// Allows binding to the DirectionProperty as BindDirection for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Expander.</returns>
    public static Bindings.BindableProperty<ExpandDirection> BindDirection(this Expander _) => Bindings.BindableProperty<ExpandDirection>.Create(Expander.DirectionProperty);

    /// <summary>
    /// Allows binding to the HeaderProperty as BindHeader for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Expander.</returns>
    public static Bindings.BindableProperty<IView> BindHeader(this Expander _) => Bindings.BindableProperty<IView>.Create(Expander.HeaderProperty);

    /// <summary>
    /// Allows binding to the IsExpandedProperty as BindIsExpanded for the Expander control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Expander.</returns>
    public static Bindings.BindableProperty<bool> BindIsExpanded(this Expander _) => Bindings.BindableProperty<bool>.Create(Expander.IsExpandedProperty);

    // ***** FadeAnimation Bindings *****

    /// <summary>
    /// Allows binding to the OpacityProperty as BindOpacity for the FadeAnimation control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type FadeAnimation.</returns>
    public static Bindings.BindableProperty<double> BindOpacity(this FadeAnimation _) => Bindings.BindableProperty<double>.Create(FadeAnimation.OpacityProperty);

    // ***** GravatarImageSource Bindings *****

    /// <summary>
    /// Allows binding to the CacheValidityProperty as BindCacheValidity for the GravatarImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GravatarImageSource.</returns>
    public static Bindings.BindableProperty<TimeSpan> BindCacheValidity(this GravatarImageSource _) => Bindings.BindableProperty<TimeSpan>.Create(GravatarImageSource.CacheValidityProperty);

    /// <summary>
    /// Allows binding to the CachingEnabledProperty as BindCachingEnabled for the GravatarImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GravatarImageSource.</returns>
    public static Bindings.BindableProperty<bool> BindCachingEnabled(this GravatarImageSource _) => Bindings.BindableProperty<bool>.Create(GravatarImageSource.CachingEnabledProperty);

    /// <summary>
    /// Allows binding to the EmailProperty as BindEmail for the GravatarImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GravatarImageSource.</returns>
    public static Bindings.BindableProperty<string> BindEmail(this GravatarImageSource _) => Bindings.BindableProperty<string>.Create(GravatarImageSource.EmailProperty);

    /// <summary>
    /// Allows binding to the ImageProperty as BindImage for the GravatarImageSource control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type GravatarImageSource.</returns>
    public static Bindings.BindableProperty<DefaultImage> BindImage(this GravatarImageSource _) => Bindings.BindableProperty<DefaultImage>.Create(GravatarImageSource.ImageProperty);

    // ***** IconTintColorBehavior Bindings *****

    /// <summary>
    /// Allows binding to the TintColorProperty as BindTintColor for the IconTintColorBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type IconTintColorBehavior.</returns>
    public static Bindings.BindableProperty<Color> BindTintColor(this IconTintColorBehavior _) => Bindings.BindableProperty<Color>.Create(IconTintColorBehavior.TintColorProperty);

    // ***** LazyView Bindings *****

    /// <summary>
    /// Allows binding to the HasLazyViewLoadedProperty as BindHasLazyViewLoaded for the LazyView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type LazyView.</returns>
    public static Bindings.BindableProperty<bool> BindHasLazyViewLoaded(this LazyView _) => Bindings.BindableProperty<bool>.Create(LazyView.HasLazyViewLoadedProperty);

    // ***** MaskedBehavior Bindings *****

    /// <summary>
    /// Allows binding to the MaskProperty as BindMask for the MaskedBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MaskedBehavior.</returns>
    public static Bindings.BindableProperty<string> BindMask(this MaskedBehavior _) => Bindings.BindableProperty<string>.Create(MaskedBehavior.MaskProperty);

    /// <summary>
    /// Allows binding to the UnmaskedCharacterProperty as BindUnmaskedCharacter for the MaskedBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MaskedBehavior.</returns>
    public static Bindings.BindableProperty<Char> BindUnmaskedCharacter(this MaskedBehavior _) => Bindings.BindableProperty<Char>.Create(MaskedBehavior.UnmaskedCharacterProperty);

    // ***** MaxLengthReachedBehavior Bindings *****

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the MaxLengthReachedBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MaxLengthReachedBehavior.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this MaxLengthReachedBehavior _) => Bindings.BindableProperty<ICommand>.Create(MaxLengthReachedBehavior.CommandProperty);

    /// <summary>
    /// Allows binding to the ShouldDismissKeyboardAutomaticallyProperty as BindShouldDismissKeyboardAutomatically for the MaxLengthReachedBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MaxLengthReachedBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindShouldDismissKeyboardAutomatically(this MaxLengthReachedBehavior _) => Bindings.BindableProperty<bool>.Create(MaxLengthReachedBehavior.ShouldDismissKeyboardAutomaticallyProperty);

    // ***** MultiValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the ErrorProperty as BindError for the MultiValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MultiValidationBehavior.</returns>
    public static Bindings.BindableProperty<object> BindError(this MultiValidationBehavior _) => Bindings.BindableProperty<object>.Create(MultiValidationBehavior.ErrorProperty);

    /// <summary>
    /// Allows binding to the ErrorsProperty as BindErrors for the MultiValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type MultiValidationBehavior.</returns>
    public static Bindings.BindableProperty<List<object>> BindErrors(this MultiValidationBehavior _) => Bindings.BindableProperty<List<object>>.Create(MultiValidationBehavior.ErrorsProperty);

    // ***** NumericValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the MaximumDecimalPlacesProperty as BindMaximumDecimalPlaces for the NumericValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NumericValidationBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMaximumDecimalPlaces(this NumericValidationBehavior _) => Bindings.BindableProperty<int>.Create(NumericValidationBehavior.MaximumDecimalPlacesProperty);

    /// <summary>
    /// Allows binding to the MaximumValueProperty as BindMaximumValue for the NumericValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NumericValidationBehavior.</returns>
    public static Bindings.BindableProperty<double> BindMaximumValue(this NumericValidationBehavior _) => Bindings.BindableProperty<double>.Create(NumericValidationBehavior.MaximumValueProperty);

    /// <summary>
    /// Allows binding to the MinimumDecimalPlacesProperty as BindMinimumDecimalPlaces for the NumericValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NumericValidationBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMinimumDecimalPlaces(this NumericValidationBehavior _) => Bindings.BindableProperty<int>.Create(NumericValidationBehavior.MinimumDecimalPlacesProperty);

    /// <summary>
    /// Allows binding to the MinimumValueProperty as BindMinimumValue for the NumericValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type NumericValidationBehavior.</returns>
    public static Bindings.BindableProperty<double> BindMinimumValue(this NumericValidationBehavior _) => Bindings.BindableProperty<double>.Create(NumericValidationBehavior.MinimumValueProperty);

    // ***** Popup Bindings *****

    /// <summary>
    /// Allows binding to the CanBeDismissedByTappingOutsideOfPopupProperty as BindCanBeDismissedByTappingOutsideOfPopup for the Popup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Popup.</returns>
    public static Bindings.BindableProperty<bool> BindCanBeDismissedByTappingOutsideOfPopup(this Popup _) => Bindings.BindableProperty<bool>.Create(Popup.CanBeDismissedByTappingOutsideOfPopupProperty);

    /// <summary>
    /// Allows binding to the ColorProperty as BindColor for the Popup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Popup.</returns>
    public static Bindings.BindableProperty<Color> BindColor(this Popup _) => Bindings.BindableProperty<Color>.Create(Popup.ColorProperty);

    /// <summary>
    /// Allows binding to the ContentProperty as BindContent for the Popup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Popup.</returns>
    public static Bindings.BindableProperty<View> BindContent(this Popup _) => Bindings.BindableProperty<View>.Create(Popup.ContentProperty);

    /// <summary>
    /// Allows binding to the HorizontalOptionsProperty as BindHorizontalOptions for the Popup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Popup.</returns>
    public static Bindings.BindableProperty<LayoutAlignment> BindHorizontalOptions(this Popup _) => Bindings.BindableProperty<LayoutAlignment>.Create(Popup.HorizontalOptionsProperty);

    /// <summary>
    /// Allows binding to the SizeProperty as BindSize for the Popup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Popup.</returns>
    public static Bindings.BindableProperty<Size> BindSize(this Popup _) => Bindings.BindableProperty<Size>.Create(Popup.SizeProperty);

    /// <summary>
    /// Allows binding to the VerticalOptionsProperty as BindVerticalOptions for the Popup control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type Popup.</returns>
    public static Bindings.BindableProperty<LayoutAlignment> BindVerticalOptions(this Popup _) => Bindings.BindableProperty<LayoutAlignment>.Create(Popup.VerticalOptionsProperty);

    // ***** ProgressBarAnimationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the EasingProperty as BindEasing for the ProgressBarAnimationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ProgressBarAnimationBehavior.</returns>
    public static Bindings.BindableProperty<Easing> BindEasing(this ProgressBarAnimationBehavior _) => Bindings.BindableProperty<Easing>.Create(ProgressBarAnimationBehavior.EasingProperty);

    /// <summary>
    /// Allows binding to the LengthProperty as BindLength for the ProgressBarAnimationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ProgressBarAnimationBehavior.</returns>
    public static Bindings.BindableProperty<UInt32> BindLength(this ProgressBarAnimationBehavior _) => Bindings.BindableProperty<UInt32>.Create(ProgressBarAnimationBehavior.LengthProperty);

    /// <summary>
    /// Allows binding to the ProgressProperty as BindProgress for the ProgressBarAnimationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ProgressBarAnimationBehavior.</returns>
    public static Bindings.BindableProperty<double> BindProgress(this ProgressBarAnimationBehavior _) => Bindings.BindableProperty<double>.Create(ProgressBarAnimationBehavior.ProgressProperty);

    // ***** RequiredStringValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the ExactMatchProperty as BindExactMatch for the RequiredStringValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RequiredStringValidationBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindExactMatch(this RequiredStringValidationBehavior _) => Bindings.BindableProperty<bool>.Create(RequiredStringValidationBehavior.ExactMatchProperty);

    /// <summary>
    /// Allows binding to the RequiredStringProperty as BindRequiredString for the RequiredStringValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type RequiredStringValidationBehavior.</returns>
    public static Bindings.BindableProperty<string> BindRequiredString(this RequiredStringValidationBehavior _) => Bindings.BindableProperty<string>.Create(RequiredStringValidationBehavior.RequiredStringProperty);

    // ***** SemanticOrderView Bindings *****

    /// <summary>
    /// Allows binding to the ViewOrderProperty as BindViewOrder for the SemanticOrderView control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SemanticOrderView.</returns>
    public static Bindings.BindableProperty<IEnumerable> BindViewOrder(this SemanticOrderView _) => Bindings.BindableProperty<IEnumerable>.Create(SemanticOrderView.ViewOrderProperty);

    // ***** SetFocusOnEntryCompletedBehavior Bindings *****

    /// <summary>
    /// Allows binding to the NextElementProperty as BindNextElement for the SetFocusOnEntryCompletedBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type SetFocusOnEntryCompletedBehavior.</returns>
    public static Bindings.BindableProperty<VisualElement> BindNextElement(this SetFocusOnEntryCompletedBehavior _) => Bindings.BindableProperty<VisualElement>.Create(SetFocusOnEntryCompletedBehavior.NextElementProperty);

    // ***** TextValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the DecorationFlagsProperty as BindDecorationFlags for the TextValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextValidationBehavior.</returns>
    public static Bindings.BindableProperty<TextDecorationFlags> BindDecorationFlags(this TextValidationBehavior _) => Bindings.BindableProperty<TextDecorationFlags>.Create(TextValidationBehavior.DecorationFlagsProperty);

    /// <summary>
    /// Allows binding to the MaximumLengthProperty as BindMaximumLength for the TextValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextValidationBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMaximumLength(this TextValidationBehavior _) => Bindings.BindableProperty<int>.Create(TextValidationBehavior.MaximumLengthProperty);

    /// <summary>
    /// Allows binding to the MinimumLengthProperty as BindMinimumLength for the TextValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextValidationBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMinimumLength(this TextValidationBehavior _) => Bindings.BindableProperty<int>.Create(TextValidationBehavior.MinimumLengthProperty);

    /// <summary>
    /// Allows binding to the RegexOptionsProperty as BindRegexOptions for the TextValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextValidationBehavior.</returns>
    public static Bindings.BindableProperty<RegexOptions> BindRegexOptions(this TextValidationBehavior _) => Bindings.BindableProperty<RegexOptions>.Create(TextValidationBehavior.RegexOptionsProperty);

    /// <summary>
    /// Allows binding to the RegexPatternProperty as BindRegexPattern for the TextValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type TextValidationBehavior.</returns>
    public static Bindings.BindableProperty<string> BindRegexPattern(this TextValidationBehavior _) => Bindings.BindableProperty<string>.Create(TextValidationBehavior.RegexPatternProperty);

    // ***** UniformItemsLayout Bindings *****

    /// <summary>
    /// Allows binding to the MaxColumnsProperty as BindMaxColumns for the UniformItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UniformItemsLayout.</returns>
    public static Bindings.BindableProperty<int> BindMaxColumns(this UniformItemsLayout _) => Bindings.BindableProperty<int>.Create(UniformItemsLayout.MaxColumnsProperty);

    /// <summary>
    /// Allows binding to the MaxRowsProperty as BindMaxRows for the UniformItemsLayout control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UniformItemsLayout.</returns>
    public static Bindings.BindableProperty<int> BindMaxRows(this UniformItemsLayout _) => Bindings.BindableProperty<int>.Create(UniformItemsLayout.MaxRowsProperty);

    // ***** UriValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the UriKindProperty as BindUriKind for the UriValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UriValidationBehavior.</returns>
    public static Bindings.BindableProperty<UriKind> BindUriKind(this UriValidationBehavior _) => Bindings.BindableProperty<UriKind>.Create(UriValidationBehavior.UriKindProperty);

    // ***** UserStoppedTypingBehavior Bindings *****

    /// <summary>
    /// Allows binding to the CommandParameterProperty as BindCommandParameter for the UserStoppedTypingBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UserStoppedTypingBehavior.</returns>
    public static Bindings.BindableProperty<object> BindCommandParameter(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<object>.Create(UserStoppedTypingBehavior.CommandParameterProperty);

    /// <summary>
    /// Allows binding to the CommandProperty as BindCommand for the UserStoppedTypingBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UserStoppedTypingBehavior.</returns>
    public static Bindings.BindableProperty<ICommand> BindCommand(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<ICommand>.Create(UserStoppedTypingBehavior.CommandProperty);

    /// <summary>
    /// Allows binding to the MinimumLengthThresholdProperty as BindMinimumLengthThreshold for the UserStoppedTypingBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UserStoppedTypingBehavior.</returns>
    public static Bindings.BindableProperty<int> BindMinimumLengthThreshold(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<int>.Create(UserStoppedTypingBehavior.MinimumLengthThresholdProperty);

    /// <summary>
    /// Allows binding to the ShouldDismissKeyboardAutomaticallyProperty as BindShouldDismissKeyboardAutomatically for the UserStoppedTypingBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UserStoppedTypingBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindShouldDismissKeyboardAutomatically(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<bool>.Create(UserStoppedTypingBehavior.ShouldDismissKeyboardAutomaticallyProperty);

    /// <summary>
    /// Allows binding to the StoppedTypingTimeThresholdProperty as BindStoppedTypingTimeThreshold for the UserStoppedTypingBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type UserStoppedTypingBehavior.</returns>
    public static Bindings.BindableProperty<int> BindStoppedTypingTimeThreshold(this UserStoppedTypingBehavior _) => Bindings.BindableProperty<int>.Create(UserStoppedTypingBehavior.StoppedTypingTimeThresholdProperty);

    // ***** ValidationBehavior Bindings *****

    /// <summary>
    /// Allows binding to the FlagsProperty as BindFlags for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<ValidationFlags> BindFlags(this ValidationBehavior _) => Bindings.BindableProperty<ValidationFlags>.Create(ValidationBehavior.FlagsProperty);

    /// <summary>
    /// Allows binding to the ForceValidateCommandProperty as BindForceValidateCommand for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<ICommand> BindForceValidateCommand(this ValidationBehavior _) => Bindings.BindableProperty<ICommand>.Create(ValidationBehavior.ForceValidateCommandProperty);

    /// <summary>
    /// Allows binding to the InvalidStyleProperty as BindInvalidStyle for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<Style> BindInvalidStyle(this ValidationBehavior _) => Bindings.BindableProperty<Style>.Create(ValidationBehavior.InvalidStyleProperty);

    /// <summary>
    /// Allows binding to the IsNotValidProperty as BindIsNotValid for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindIsNotValid(this ValidationBehavior _) => Bindings.BindableProperty<bool>.Create(ValidationBehavior.IsNotValidProperty);

    /// <summary>
    /// Allows binding to the IsRunningProperty as BindIsRunning for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindIsRunning(this ValidationBehavior _) => Bindings.BindableProperty<bool>.Create(ValidationBehavior.IsRunningProperty);

    /// <summary>
    /// Allows binding to the IsValidProperty as BindIsValid for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<bool> BindIsValid(this ValidationBehavior _) => Bindings.BindableProperty<bool>.Create(ValidationBehavior.IsValidProperty);

    /// <summary>
    /// Allows binding to the ValidStyleProperty as BindValidStyle for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<Style> BindValidStyle(this ValidationBehavior _) => Bindings.BindableProperty<Style>.Create(ValidationBehavior.ValidStyleProperty);

    /// <summary>
    /// Allows binding to the ValueProperty as BindValue for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<object> BindValue(this ValidationBehavior _) => Bindings.BindableProperty<object>.Create(ValidationBehavior.ValueProperty);

    /// <summary>
    /// Allows binding to the ValuePropertyNameProperty as BindValueName for the ValidationBehavior control.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Generic BindableProperty of type ValidationBehavior.</returns>
    public static Bindings.BindableProperty<string> BindValueName(this ValidationBehavior _) => Bindings.BindableProperty<string>.Create(ValidationBehavior.ValuePropertyNameProperty);
}