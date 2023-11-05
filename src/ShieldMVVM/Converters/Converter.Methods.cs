using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace CoreBTS.Maui.ShieldMVVM.Converters;

public static partial class Converter
{
    public static IValueConverter<Action, ICommand> ConvertToCommand(this BindingConverter<Action, ICommand> _) =>
       Create(_,
           value => new RelayCommand(value));

    public static IValueConverter<Func<Task>, ICommand> ConvertToCommand(this BindingConverter<Func<Task>, ICommand> _) =>
       Create(_,
           value => new AsyncRelayCommand(value));
}
