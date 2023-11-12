using System.Windows.Input;

namespace CoreBTS.Maui.ShieldMVVM.Controls;

/// <summary>
/// This class wraps any BindableObject control that supports gesture recognizers and adds a 
/// tap gesture to support click binding.
/// </summary>
/// <typeparam name="T">The type of control to add the tap gesture to.</typeparam>
public class ClickableControl<T>
    where T : BindableObject, IGestureRecognizers
{
    /// <summary>
    /// Gets the bindable property to hook up to click events.
    /// </summary>
    public static readonly BindableProperty CommandProperty =
        BindableProperty.Create(
            nameof(ClickableControl<T>), 
            typeof(ICommand), 
            typeof(ClickableControl<T>), 
            propertyChanged: OnCommandPropertyChanged);

    private ClickableControl() { }

    static void OnCommandPropertyChanged(BindableObject bindable, object oldValue, object newValue)
    {
        var control = (T)bindable;
        var command = (ICommand)newValue;

        var classId = nameof(ClickableControl<T>);
        var gestureRecognizer = new TapGestureRecognizer() { ClassId = classId };
        gestureRecognizer.Tapped += (s, e) =>
        {
            if (command != null && command.CanExecute(null))
                command.Execute(null);
        };

        foreach (var gesture in control.GestureRecognizers
            .Where(a => a is TapGestureRecognizer tap && tap.ClassId == classId))
        {
            control.GestureRecognizers.Remove(gesture);
        }

        control.GestureRecognizers.Add(gestureRecognizer);
    }
}