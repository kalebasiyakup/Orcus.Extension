using System;
using System.Security.Cryptography;
using System.Text;

public static partial class OrcusStringExtension
{
    public static string ToMd5Hash(this string value)
    {
        value.ExceptionIfNull(nameof(value));

        using (MD5 md5 = new MD5CryptoServiceProvider())
        {
            byte[] originalBytes = Encoding.Default.GetBytes(value);
            byte[] encodedBytes = md5.ComputeHash(originalBytes);
            return BitConverter.ToString(encodedBytes).Replace("-", string.Empty);
        }
    }
}
