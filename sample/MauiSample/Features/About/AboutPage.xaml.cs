using CoreBTS.Maui.ShieldMVVM.Bindings;
using MauiSample.Features.About.Cells;

namespace MauiSample.Features.About;

public partial class AboutPage : ContentPageBase<AboutPageViewModel>
{
    public AboutPage(AboutPageViewModel viewModel) : base(viewModel)
    {
    }

    protected override void SetupBindings()
    {
        Binder.WithControl(Counter)
            .For(c => c.BindText(), vm => vm.Counter, 
                c => GenericConverter<int, string>.Create(value => value.ToString()));

        Binder.WithControl(DoneButton)
            .For(c => c.BindCommand(), vm => vm.DoneCommand);

        Binder.WithControl(MyText)
            .Once(c => c.BindText(), vm => vm.GetType().FullName);

        Binder.WithControl(AddButton)
            .For(c => c.BindCommand(), vm => vm.AddCommand);

        Binder.WithControl(List)
            .ForTemplate(vm => vm.AboutItems, AboutCell.ItemTemplate)
            .ForSingleSelection(vm => vm.SelectedCommand);
    }
}