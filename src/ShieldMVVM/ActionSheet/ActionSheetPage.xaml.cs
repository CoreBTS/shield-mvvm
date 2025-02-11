using CoreBTS.Maui.ShieldMVVM.Bindings;
using CoreBTS.Maui.ShieldMVVM.Converters;
using CoreBTS.Maui.ShieldMVVM.Pages;

namespace CoreBTS.Maui.ShieldMVVM.ActionSheet;

/// <summary>
/// This page allows the user to choose an action from an action sheet.
/// </summary>
/// <param name="viewModel">The data being bound to.</param>
public partial class ActionSheetPage(ActionSheetViewModel viewModel) : DialogPageBase<ActionSheetViewModel>(viewModel)
{
    /// <summary>
    /// Defines all control bindings.
    /// </summary>
    protected override void SetupBindings()
    {
        Binder.WithControl(InnerGrid)
            .For(c => c.BindMaximumWidthRequest(), vm => vm.MaxWidth);

        Binder.WithControl(PageTitleLabel)
            .For(c => c.BindText(), vm => vm.PageTitle, c => c.ConvertToNonNullString())
            .For(c => c.BindIsVisible(), vm => vm.PageTitle, c => c.ConvertToNullableHasLength());

        Binder.WithControl(MessageLabel)
            .For(c => c.BindText(), vm => vm.Message, c => c.ConvertToNonNullString());

        Binder.WithControl(CancelButton)
            .For(c => c.BindText(), vm => vm.CancelLabel)
            .For(c => c.BindTextColor(), vm => vm.CancelTextColor)
            .For(c => c.BindClick(), vm => vm.CloseCommand);

        Binder.WithControl(ButtonStackLayout)
            .ForTemplateLayout(vm => vm.Actions!, ActionSheetItemCell.ItemTemplate);
    }
}