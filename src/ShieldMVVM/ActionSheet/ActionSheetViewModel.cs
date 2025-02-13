using CommunityToolkit.Mvvm.ComponentModel;
using CoreBTS.Maui.ShieldMVVM.Navigation;
using CoreBTS.Maui.ShieldMVVM.Support;
using CoreBTS.Maui.ShieldMVVM.ViewModel;

namespace CoreBTS.Maui.ShieldMVVM.ActionSheet;

/// <summary>
/// This class drives the Action Sheet page.
/// </summary>
public partial class ActionSheetViewModel: DialogViewModelBase<ActionSheetArg, ActionSheetItem>
{
    /// <summary>
    /// Basic constructor that requires the navigation service.
    /// </summary>
    /// <param name="navigationService">The service to navigate to other view models.</param>
    public ActionSheetViewModel(INavigationService navigationService) : base(navigationService)
    {
        CancelLabel = "Cancel";
        CancelTextColor = Colors.Black;
    }
#pragma warning disable IDE0079 // Not unnecessary
#pragma warning disable MVVMTK0045 // Issues with [ObservableProperty] via a partial property

    /// <summary>
    /// Gets or sets the page title of the action sheet.
    /// </summary>
    [ObservableProperty]
    public string? _pageTitle;

    /// <summary>
    /// Gets or sets the message below the title of the action sheet.
    /// </summary>
    [ObservableProperty]
    public string? _message;

    /// <summary>
    /// Gets or sets the max width of the action sheet.
    /// </summary>
    [ObservableProperty]
    public double _maxWidth = 400D;

    /// <summary>
    /// Gets or sets the color of the cancel button's text.
    /// </summary>
    [ObservableProperty]
    public Color _cancelTextColor;

    /// <summary>
    /// Gets or sets the text of the cancel button.
    /// </summary>
    [ObservableProperty]
    public string _cancelLabel;

#pragma warning restore MVVMTK0045
#pragma warning restore IDE0079

    /// <summary>
    /// Gets the actions the user can take on the action sheet.
    /// </summary>
    public ObservableRangeCollection<ActionSheetItem>? Actions { get; private set; }

    /// <summary>
    /// Maps the incoming parameters to values on the view model.
    /// </summary>
    /// <param name="parameters">The values to map.</param>
    public override void Prepare(ActionSheetArg parameters)
    {
        ArgumentNullException.ThrowIfNull(parameters, nameof(parameters));
        ArgumentNullException.ThrowIfNull(parameters.ActionItems, nameof(parameters.ActionItems));

        PageTitle = parameters.PageTitle;
        Message = parameters.Message;

        foreach (var action in parameters.ActionItems)
        {
            action.CallbackAction = HandleAction;
        }
        Actions = new ObservableRangeCollection<ActionSheetItem>(parameters.ActionItems);

        MaxWidth = parameters.MaxWidth;
        CancelLabel = parameters.CancelLabel ?? "Cancel";
        CancelTextColor = parameters.CancelTextColor ?? Colors.Black;
    }

    /// <summary>
    /// Currently does nothing.
    /// </summary>
    /// <param name="token">
    /// A System.Threading.CancellationToken to observe while waiting for the task to complete.
    /// </param>
    /// <returns>An awaitable task.</returns>
    public override Task InitializeAsync(CancellationToken token = default)
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Handles the action of the user clicking one of the buttons.
    /// </summary>
    /// <param name="key">The key of the chosen ActionSheetItem.</param>
    /// <returns>An awaitable task.</returns>
    public Task HandleAction(string? key)
    {
        Result = Actions?.FirstOrDefault(a => a.Key == key);

        CloseCommand.Execute(null);

        return Task.CompletedTask;
    }
}
