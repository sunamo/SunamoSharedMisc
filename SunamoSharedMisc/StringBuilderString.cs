namespace SunamoSharedMisc;

/// <summary>
/// Represents the string builder string type.
/// </summary>
public class StringBuilderString
{
    private readonly bool isString;
    private readonly string text = null!;
    private readonly StringBuilder stringBuilder = null!;

    /// <summary>
    /// Initializes a new instance of the string builder string class.
    /// </summary>
    /// <param name="value">The value.</param>
    public StringBuilderString(string value)
    {
        text = value;
        isString = true;
    }

    /// <summary>
    /// Initializes a new instance of the string builder string class.
    /// </summary>
    /// <param name="value">The value.</param>
    public StringBuilderString(StringBuilder value)
    {
        stringBuilder = value;
    }

    /// <summary>
    /// Gets or sets the length.
    /// </summary>
    public int Length { get; set; }

    /// <summary>
    /// The this int.
    /// </summary>
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

    /// <summary>
    /// Initializes a new instance of the is null or white space class.
    /// </summary>
    public bool IsNullOrWhiteSpace()
    {
        if (isString) return string.IsNullOrWhiteSpace(text);
        return stringBuilder is not null && stringBuilder.ToString().Trim() != string.Empty;
    }
}
