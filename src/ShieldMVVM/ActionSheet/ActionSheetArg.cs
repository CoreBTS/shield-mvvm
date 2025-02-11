namespace CoreBTS.Maui.ShieldMVVM.ActionSheet;

/// <summary>
/// Sends data to show the action sheet to the user.
/// </summary>
/// <param name="PageTitle">The page title to show.</param>
/// <param name="Message">The message below the title to show.</param>
/// <param name="ActionItems">The actions the user can press.</param>
/// <param name="CancelLabel">The text of the cancel button.</param>
/// <param name="CancelTextColor">The color of the ext on the cancel button.</param>
/// <param name="MaxWidth">The maximum width of the entire action sheet.</param>
public record ActionSheetArg(string PageTitle, string Message, List<ActionSheetItem>? ActionItems, string CancelLabel = "Cancel", Color? CancelTextColor = null, double MaxWidth = 400D)
{
}
