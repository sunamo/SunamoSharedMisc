namespace SunamoSharedMisc.BgWorkers;

public class GetFilesEveryFolderBgWorker
{
    private BackgroundWorker? backgroundWorker = null;
    public event RunWorkerCompletedEventHandler? RunWorkerCompleted;

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

    public List<string>? Result { get; set; } = null;

    private void BackgroundWorker_DoWork(object? sender, DoWorkEventArgs eventArgs)
    {
    }
}
