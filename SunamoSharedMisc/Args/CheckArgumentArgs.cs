namespace SunamoSharedMisc.Args;

public class CheckArgumentArgs
{
    public StringBuilder? StringBuilder { get; set; } = null;

    public string? ArgName { get; set; } = null;

    public bool IsTrim { get; set; } = false;

    public CheckArgumentArgs(string argName, StringBuilder stringBuilder)
    {
        ArgName = argName;
        StringBuilder = stringBuilder;
    }
}
