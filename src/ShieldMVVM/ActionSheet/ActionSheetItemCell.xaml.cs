using CoreBTS.Maui.ShieldMVVM.DataTemplates;

namespace CoreBTS.Maui.ShieldMVVM.ActionSheet;

/// <summary>
/// This represents an individual button shown in an action sheet.
/// </summary>
public partial class ActionSheetItemCell : ViewCellBase<ActionSheetItem, ActionSheetItemCell>
{
    /// <summary>
    /// Defines all control bindings.
    /// </summary>
    protected override void SetupBindings()
    {
        Binder.WithControl(ActionButton)
            .For(c => c.BindTextColor(), vm => vm.TextColor)
            .For(c => c.BindText(), vm => vm.Text)
            .For(c => c.BindCommandParameter(), vm => vm.Key)
            .For(c => c.BindClick(), vm => vm.ActionCommand);
    }
}