namespace SunamoSharedMisc._SunamoExceptions.ai;

/// <summary>
/// Represents the AI init args type.
/// </summary>
public class AIInitArgs
{
    /// <summary>
    /// Gets or sets the win pi.
    /// </summary>
    public AIAssembly<IAIWinPi> WinPi { get; set; } = null!;
}
