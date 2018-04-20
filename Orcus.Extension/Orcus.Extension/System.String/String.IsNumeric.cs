using System.Linq;
using System.Text.RegularExpressions;

public static partial class OrcusStringExtension
{
    public static bool IsNumeric(this string str)
    {
        return !Regex.IsMatch(str, "[^0-9]");
    }
}
