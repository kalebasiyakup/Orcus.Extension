using System;

public static partial class OrcusStringExtension
{
    public static string Left(this string value, int count)
    {
        value.ThrowIfNull(nameof(value));

        if (count < 0 || value.Length < count)
            throw new ArgumentOutOfRangeException(nameof(count), count, "Belirtilen karakter miktarı aralık dışında.");

        return value.Substring(value.Length - count, count);
    }
}
