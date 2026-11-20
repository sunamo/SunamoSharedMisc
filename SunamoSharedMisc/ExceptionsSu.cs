namespace SunamoSharedMisc;

/// <summary>
/// Represents the exceptions su type.
/// </summary>
public class ExceptionsSu
{
    /// <summary>
    /// Parse exceptions.
    /// </summary>
    /// <param name="lines">The lines.</param>
    /// <param name="trimIfStartWith">The trim if start with.</param>
    /// <returns>The parse exceptions result.</returns>
    public static List<string> ParseExceptions(List<string> lines, params string[] trimIfStartWith)
    {
        lines = lines.Where(line => line.StartsWith("Exception:")).ToList();
        CA.TrimStart("Exception:", lines);
        foreach (var item in trimIfStartWith) CA.TrimStart(item, lines);
        return lines;
    }
}
