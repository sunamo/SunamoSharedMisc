namespace SunamoSharedMisc.Constants;

/// <summary>
/// Represents the random statuses type.
/// </summary>
public class RandomStatuses
{
    /// <summary>
    /// Set status of type.
    /// </summary>
    /// <param name="type">The type.</param>
    public void SetStatusOfType(TypeOfMessageShared type)
    {
        ThisApp.SetStatus(type, type.ToString());
    }

    /// <summary>
    /// Set all types.
    /// </summary>
    public void SetAllTypes()
    {
        foreach (var item in EnumHelper.GetValues<TypeOfMessageShared>())
        {
            SetStatusOfType(item);
        }
    }
}
