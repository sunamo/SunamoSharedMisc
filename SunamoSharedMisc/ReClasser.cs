namespace SunamoSharedMisc;

/// <summary>
/// Represents the re classer type.
/// </summary>
public static class ReClasser
{
    // Must be here because it is used in JsonSystemTextJson etc.
    /// <summary>
    /// Fix me up.
    /// </summary>
    /// <param name="fixMe">The fix me.</param>
    /// <returns>The fix me up result.</returns>
    public static dynamic FixMeUp(this object fixMe)
    {
        var objectType = fixMe.GetType();
        var result = new ExpandoObject() as IDictionary<string, object>;
        var properties = objectType.GetProperties();
        foreach (var property in properties)
        {
            var propertyValue = property.GetValue(fixMe);
            if (propertyValue is string && string.IsNullOrWhiteSpace(propertyValue.ToString()))
            {
                continue;
            }

            if (propertyValue is null)
            {
                continue;
            }

            result.Add(property.Name, propertyValue);
        }

        return result;
    }
}
