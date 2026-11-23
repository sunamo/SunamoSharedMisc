namespace SunamoSharedMisc._SunamoExceptions;

/// <summary>
/// Represents the AI store type.
/// </summary>
public class AIStore
{
    /// <summary>
    /// Gets or sets the win pi.
    /// </summary>
    public static IAIWinPi WinPi { get; set; } = null!;
}
