namespace SunamoSharedMisc.Args;

public class GetFileSystemEntriesArgs
{
    public IProgressBarHelperShared? ProgressBarHelper { get; set; } = null;

    public ProgressBar? ProgressBarInstance { get; set; } = null;
}
