namespace SunamoSharedMisc._SunamoExceptions.Interfaces;

/// <summary>
/// Represents the IAI win pi type.
/// </summary>
public interface IAIWinPi
{
    /// <summary>
    /// Gets or sets the PH win pi run as desktop user no admin.
    /// </summary>
    Action<string> PHWinPiRunAsDesktopUserNoAdmin { get; set; }
}
