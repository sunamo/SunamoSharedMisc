namespace SunamoSharedMisc._SunamoExceptions.ai;

/// <summary>
/// Represents the AI win pi type.
/// </summary>
public class AIWinPi : IAIWinPi
{
    /// <summary>
    /// Gets or sets the PH win pi run as desktop user no admin.
    /// </summary>
    public Action<string> PHWinPiRunAsDesktopUserNoAdmin { get; set; } = null!;
}
