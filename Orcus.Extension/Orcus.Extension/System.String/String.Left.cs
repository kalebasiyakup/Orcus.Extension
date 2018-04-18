using System;

public static partial class OrcusStringExtension
{
    public static string Left(this string value, int count)
    {
        value.ExceptionIfNull(nameof(value));

        if (count < 0 || value.Length < count)
            throw new ArgumentOutOfRangeException(nameof(count), count, "Belirtilen karakter miktarı aralık dışında.");

        return value.Substring(0, count);
    }
}
