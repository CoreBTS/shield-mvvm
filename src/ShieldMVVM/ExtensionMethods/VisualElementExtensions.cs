using CommunityToolkit.Maui.Views;
using System.Reflection;

#pragma warning disable IDE0130 // Namespace does not match folder structure - Used for intellisense
namespace CoreBTS.Maui.ShieldMVVM;
#pragma warning restore IDE0130 // Namespace does not match folder structure

/// <summary>
/// This stores extension methods adding to VisualElement.
/// </summary>
public static class VisualElementExtensions
{
    /// <summary>
    /// Returns the control height in independent units.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Control height in independent units.</returns>
    public static double DeviceScreenHeight(this Element _) =>
        DeviceDisplay.MainDisplayInfo.Height / DeviceDisplay.MainDisplayInfo.Density;

    /// <summary>
    /// Returns the control width as independent units.
    /// </summary>
    /// <param name="_">Extension parameter.</param>
    /// <returns>Control width in independent units.</returns>
    public static double DeviceScreenWidth(this Element _) =>
       DeviceDisplay.MainDisplayInfo.Width / DeviceDisplay.MainDisplayInfo.Density;

    /// <summary>
    /// Calls InitializeComponent via reflection.
    /// </summary>
    /// <param name="ve">The visual element being initialized.</param>
    public static void CallInitializeComponent(this VisualElement ve) =>
        ve.GetType().GetMethod("InitializeComponent", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(ve, null);

    /// <summary>
    /// Calls InitializeComponent via reflection.
    /// </summary>
    /// <param name="p">The popup being initialized..</param>
    public static void CallInitializeComponent(this Popup p) =>
        p.GetType().GetMethod("InitializeComponent", BindingFlags.Instance | BindingFlags.NonPublic)?.Invoke(p, null);
}