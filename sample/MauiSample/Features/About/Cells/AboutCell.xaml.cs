using CoreBTS.Maui.ShieldMVVM.DataTemplates;

namespace MauiSample.Features.About.Cells;

public partial class AboutCell : ViewCellBase<AboutItem, AboutCell>
{
    protected override void SetupBindings()
    {
        Binder.WithControls(Name)
            .For(c => c.BindText(), vm => vm.Name, vm => vm.ConvertToNonNullString());

        Binder.WithControls(Description)
            .For(c => c.BindText(), vm => vm.Description, vm => vm.ConvertToNonNullString());
    }
}