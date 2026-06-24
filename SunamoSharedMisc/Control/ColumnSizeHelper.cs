namespace SunamoSharedMisc.Control;

public class ColumnSizeHelper
{
    public static List<double> CalculateWidthOfColumnsAgain(List<double> columnWidths, double widthChange)
    {
        if (widthChange == 0)
        {
            throw new Exception(Translate.FromKey(XlfKeys.ParameterZmenaOOfMethodColumnSizeHelperCalculateWidthOfColumnsAgainHasValue) + " ");
        }

        widthChange /= columnWidths.Count;
        for (int i = 0; i < columnWidths.Count; i++)
        {
            if (columnWidths[i] != 0)
            {
                columnWidths[i] += widthChange;
            }
        }

        return columnWidths;
    }
}
