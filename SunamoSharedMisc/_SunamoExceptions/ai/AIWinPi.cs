namespace SunamoSharedMisc._SunamoExceptions.ai;

public class AIWinPi : IAIWinPi
{
    public Action<string> PHWinPiRunAsDesktopUserNoAdmin { get; set; } = null!;
}
