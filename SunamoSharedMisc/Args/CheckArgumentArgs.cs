namespace SunamoSharedMisc.Args;

/// <summary>
/// Represents the check argument args type.
/// </summary>
public class CheckArgumentArgs
{
    /// <summary>
    /// Gets or sets the string builder.
    /// </summary>
    public StringBuilder? StringBuilder { get; set; } = null;

    /// <summary>
    /// Gets or sets the arg name.
    /// </summary>
    public string? ArgName { get; set; } = null;

    /// <summary>
    /// Gets or sets the is trim.
    /// </summary>
    public bool IsTrim { get; set; } = false;

    /// <summary>
    /// Check argument args.
    /// </summary>
    /// <param name="argName">The arg name.</param>
    /// <param name="stringBuilder">The string builder.</param>
    /// <returns>The check argument args result.</returns>
    public CheckArgumentArgs(string argName, StringBuilder stringBuilder)
    {
        ArgName = argName;
        StringBuilder = stringBuilder;
    }
}
