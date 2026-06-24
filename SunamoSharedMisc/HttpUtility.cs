namespace SunamoSharedMisc;

public class HttpUtility
{
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

    public static string HtmlDecode(string text) => WebUtility.HtmlDecode(text);

    public static string HtmlEncode(string html) => HtmlEncodeWithCompatibility(html);

    public static string HtmlEncodeWithCompatibility(string html, bool isBackwardCompatibility = true)
    {
        if (html is null) throw new Exception("html");
        var regex = isBackwardCompatibility
            ? new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;))", RegexOptions.IgnoreCase)
            : new Regex("&(?!(amp;)|(lt;)|(gt;)|(quot;)|(nbsp;)|(reg;))", RegexOptions.IgnoreCase);
        return regex.Replace(html, "&amp;").Replace("<", "&lt;").Replace(">", "&gt;").Replace("\"", "&quot;");
    }

    public static string UrlEncode(string text) => WebUtility.UrlEncode(text);

    public static string UrlDecode(string text) => WebUtility.UrlDecode(text);
}
