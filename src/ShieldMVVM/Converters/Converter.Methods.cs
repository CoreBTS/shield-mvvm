using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

public static partial class Converter
{
    /// <summary>
    /// A converter that creates a command if given an Action.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<Action, ICommand> ConvertToCommand(this BindingConverter<Action, ICommand> _) =>
       Create(_,
           value => new RelayCommand(value));

    /// <summary>
    /// A converter that creates an async command if given a function that returns a task.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>An IValueConverter.</returns>
    public static IValueConverter<Func<Task>, ICommand> ConvertToCommand(this BindingConverter<Func<Task>, ICommand> _) =>
       Create(_,
           value => new AsyncRelayCommand(value));
}
