using System;

public static partial class OrcusStringExtension
{
    public static string Left(this string str, int count)
    {
        str.ExceptionIfNull(nameof(str));

        if (count < 0 || str.Length < count)
            throw new ArgumentOutOfRangeException(nameof(count), count, "Belirtilen karakter miktarı aralık dışında.");

        return str.Substring(0, count);
    }
}
