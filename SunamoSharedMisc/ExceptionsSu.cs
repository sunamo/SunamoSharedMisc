namespace SunamoSharedMisc;

public class ExceptionsSu
{
    public static List<string> ParseExceptions(List<string> lines, params string[] trimIfStartWith)
    {
        lines = lines.Where(line => line.StartsWith("Exception:")).ToList();
        CA.TrimStart("Exception:", lines);
        foreach (var item in trimIfStartWith) CA.TrimStart(item, lines);
        return lines;
    }
}
