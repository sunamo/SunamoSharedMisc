namespace SunamoSharedMisc;

public static class ReClasser
{
    // Must be here because it is used in JsonSystemTextJson etc.
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
