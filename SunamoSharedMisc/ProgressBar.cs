namespace SunamoSharedMisc;

/// <summary>
/// Represents the progress bar type.
/// </summary>
public class ProgressBar
{
    private static readonly int totalSongs = 10;
    /// <summary>
    /// The another song.
    /// </summary>
    public static event Action? AnotherSong;
    /// <summary>
    /// The overall songs.
    /// </summary>
    public static event Action<int>? OverallSongs;
    /// <summary>
    /// The write progress bar end.
    /// </summary>
    public static event Action? WriteProgressBarEnd;

    /// <summary>
    /// Get all song from internet.
    /// </summary>
    /// <returns>The get all song from internet result.</returns>
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
