namespace SunamoSharedMisc;

public class StringBuilderString
{
    private readonly bool isString;
    private readonly string text = null!;
    private readonly StringBuilder stringBuilder = null!;

    public StringBuilderString(string value)
    {
        text = value;
        isString = true;
    }

    public StringBuilderString(StringBuilder value)
    {
        stringBuilder = value;
    }

    public int Length { get; set; }

    public char this[int index]
    {
        get
        {
            if (isString)
                return text[index];
            return stringBuilder[index];
        }
        set
        {
            if (isString)
                ThrowEx.NotSupported();
            else
                stringBuilder[index] = value;
        }
    }

    public bool IsNullOrWhiteSpace()
    {
        if (isString) return string.IsNullOrWhiteSpace(text);
        return stringBuilder is not null && stringBuilder.ToString().Trim() != string.Empty;
    }
}
