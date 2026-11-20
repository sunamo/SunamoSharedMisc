namespace SunamoSharedMisc.Control;

public class ColumnSizeHelper
{
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
