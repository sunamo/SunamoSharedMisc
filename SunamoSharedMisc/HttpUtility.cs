namespace SunamoSharedMisc;

/// <summary>
/// Represents the http utility type.
/// </summary>
public class HttpUtility
{
    /// <summary>
    /// Parse query string.
    /// </summary>
    /// <param name="queryString">The query string.</param>
    /// <returns>The parse query string result.</returns>
    public static NameValueCollection ParseQueryString(string queryString)
    {
        NameValueCollection queryParameters = new();
        var querySegments = queryString.Split('&');
        foreach (var segment in querySegments)
        {
            var parts = segment.Split('=');
            if (parts.Length > 0)
            {
                var key = parts[0].Trim('?', ' ');
                var value = parts[1].Trim();
                queryParameters.Add(key, value);
            }
        }

        return queryParameters;
    }

    /// <summary>
    /// Html decode.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The html decode result.</returns>
    public static string HtmlDecode(string text) => WebUtility.HtmlDecode(text);

    /// <summary>
    /// Html encode.
    /// </summary>
    /// <param name="html">The html.</param>
    /// <returns>The html encode result.</returns>
    public static string HtmlEncode(string html) => HtmlEncodeWithCompatibility(html);

    /// <summary>
    /// Html encode with compatibility.
    /// </summary>
    /// <param name="html">The html.</param>
    /// <param name="isBackwardCompatibility">The is backward compatibility.</param>
    /// <returns>The html encode with compatibility result.</returns>
    public static string HtmlEncodeWithCompatibility(string html, bool isBackwardCompatibility = true)
    {
        if (html is null) throw new Exception("html");
        var regex = isBackwardCompatibility
            ? new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;))", RegexOptions.IgnoreCase)
            : new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;)|(nbsp;)|(reg;))", RegexOptions.IgnoreCase);
        return regex.Replace(html, "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
    }

    /// <summary>
    /// Url encode.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The url encode result.</returns>
    public static string UrlEncode(string text) => WebUtility.UrlEncode(text);

    /// <summary>
    /// Url decode.
    /// </summary>
    /// <param name="text">The text.</param>
    /// <returns>The url decode result.</returns>
    public static string UrlDecode(string text) => WebUtility.UrlDecode(text);
}
