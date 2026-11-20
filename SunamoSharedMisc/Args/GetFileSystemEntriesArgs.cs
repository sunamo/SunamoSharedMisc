namespace SunamoSharedMisc.Args;

/// <summary>
/// Represents the get file system entries args type.
/// </summary>
public class GetFileSystemEntriesArgs
{
    /// <summary>
    /// Gets or sets the progress bar helper.
    /// </summary>
    public IProgressBarHelperShared? ProgressBarHelper { get; set; } = null;

    /// <summary>
    /// Gets or sets the progress bar instance.
    /// </summary>
    public ProgressBar? ProgressBarInstance { get; set; } = null;
}
