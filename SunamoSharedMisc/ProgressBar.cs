namespace SunamoSharedMisc;

public class ProgressBar
{
    private static readonly int totalSongs = 10;
    public static event Action? AnotherSong;
    public static event Action<int>? OverallSongs;
    public static event Action? WriteProgressBarEnd;

    public static List<int> GetAllSongFromInternet()
    {
        OverallSongs?.Invoke(totalSongs);

        return GetAllSongFromInternet(totalSongs);
    }

    private static List<int> GetAllSongFromInternet(int songCount)
    {
        for (var index = 0; index < songCount; index++)
        {
            AnotherSong?.Invoke();
            Thread.Sleep(100);
        }

        WriteProgressBarEnd?.Invoke();

        return null!;
    }
}
