using System.Linq;

public static partial class OrcusStringExtension
{
    public static bool IsAlpha(this string str)
    {
        str.ExceptionIfNull(nameof(str));

        return str.ToCharArray().All(x => x.IsLetter());
    }
}
