using System.Linq;

public static partial class OrcusStringExtension
{
    public static bool IsNumeric(this string str)
    {
        str.ThrowIfNull(nameof(str));

        return str.ToCharArray().All(x => x.IsNumber());
    }
}
