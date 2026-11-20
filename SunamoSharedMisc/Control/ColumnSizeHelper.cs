namespace SunamoSharedMisc.Control;

/// <summary>
/// Represents the column size helper type.
/// </summary>
public class ColumnSizeHelper
{
    /// <summary>
    /// Calculate width of columns again.
    /// </summary>
    /// <param name="columnWidths">The column widths.</param>
    /// <param name="widthChange">The width change.</param>
    /// <returns>The calculate width of columns again result.</returns>
    public static List<double> CalculateWidthOfColumnsAgain(List<double> columnWidths, double widthChange)
    {
        if (widthChange == 0)
        {
            throw new Exception("Parameter change o of method column size helper calculate width of columns again has value" + " ");
        }

        widthChange /= columnWidths.Count;
        for (int index = 0; index < columnWidths.Count; index++)
        {
            if (columnWidths[index] != 0)
            {
                columnWidths[index] += widthChange;
            }
        }

        return columnWidths;
    }
}
