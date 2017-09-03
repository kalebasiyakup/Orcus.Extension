using System;

namespace Orcus.Extension
{
    public static partial class StringExtension
    {
        public static string Right(this string value, int count)
        {
            if (count < 0 || value.Length < count)
                throw new ArgumentOutOfRangeException(nameof(count), count, "Belirtilen karakter miktarı aralık dışında.");

            return value.Substring(value.Length - count, count);
        }
    }
}
