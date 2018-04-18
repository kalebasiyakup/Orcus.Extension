using System.Security.Cryptography;
using System.Text;

public static partial class OrcusStringExtension
{
    public static string ToSha512(this string value)
    {
        return Sha512(value, new UTF8Encoding());
    }

    public static string ToSha512(this string value, Encoding encoding)
    {
        return Sha512(value, encoding);
    }

    private static string Sha512(string value, Encoding encoding)
    {
        value.ExceptionIfNull(nameof(value));

        using (var shaHash = new SHA512CryptoServiceProvider())
        {
            byte[] data = shaHash.ComputeHash(encoding.GetBytes(value));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
