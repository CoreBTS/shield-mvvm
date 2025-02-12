using CommunityToolkit.Mvvm.Input;

namespace CoreBTS.Maui.ShieldMVVM.ActionSheet;

/// <summary>
/// This stores information about an individual item in an action sheet.
/// </summary>
public class ActionSheetItem
{
    /// <summary>
    /// Constructor with required values.
    /// </summary>
    /// <param name="key">The lookup key that must be unique.</param>
    /// <param name="text">The text of the action.</param>
    /// <param name="textColor">The text color of the action; defaults to Black.</param>
    public ActionSheetItem(string key, string text, Color? textColor = null)
    {
        Key = key;
        Text = text;
        ActionCommand = new AsyncRelayCommand<string?>(DoAction);
        TextColor = textColor ?? Colors.Black;
    }

    /// <summary>
    /// Gets the lookup key.
    /// </summary>
    public string Key { get; }
    
    /// <summary>
    /// Gets the text of the action.
    /// </summary>
    public string Text { get; }

    /// <summary>
    /// Gets the text color of the action.
    /// </summary>
    public Color TextColor { get; }

    /// <summary>
    /// Gets the command to the action to run when the action is pressed.
    /// </summary>
    public IAsyncRelayCommand<string?> ActionCommand { get; }
    
    internal Func<string?, Task>? CallbackAction { get; set; }

    /// <summary>
    /// Gets the action to run when the action is pressed.
    /// </summary>
    /// <param name="key"></param>
    /// <returns></returns>
    public async Task DoAction(string? key)
    {
        if (CallbackAction != null)
            await CallbackAction.Invoke(key);
    }

    /// <summary>
    /// Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    public override string ToString() => Text;
};
