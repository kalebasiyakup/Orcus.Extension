using System;

public static partial class OrcusStringExtension
{
    public static string Right(this string str, int count)
    {
        str.ExceptionIfNull(nameof(str));

        if (count < 0 || str.Length < count)
            throw new ArgumentOutOfRangeException(nameof(count), count, "Belirtilen karakter miktarı aralık dışında.");

        return str.Substring(str.Length - count, count);
    }
}
