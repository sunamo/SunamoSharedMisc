namespace SunamoSharedMisc.BgWorkers;

/// <summary>
/// Represents the get files every folder bg worker type.
/// </summary>
public class GetFilesEveryFolderBgWorker
{
    private BackgroundWorker? backgroundWorker = null;
    /// <summary>
    /// The run worker completed.
    /// </summary>
    public event RunWorkerCompletedEventHandler? RunWorkerCompleted;

    /// <summary>
    /// Get files every folder bg worker.
    /// </summary>
    /// <returns>The get files every folder bg worker result.</returns>
    public GetFilesEveryFolderBgWorker()
    {
        backgroundWorker = new BackgroundWorker();
        backgroundWorker.DoWork += BackgroundWorker_DoWork;
        backgroundWorker.RunWorkerCompleted += BackgroundWorker_RunWorkerCompleted;
    }

    private void BackgroundWorker_RunWorkerCompleted(object? sender, RunWorkerCompletedEventArgs eventArgs)
    {
        RunWorkerCompleted?.Invoke(sender, eventArgs);
    }

    /// <summary>
    /// Gets or sets the result.
    /// </summary>
    public List<string>? Result { get; set; } = null;

    private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs eventArgs)
    {
    }
}
