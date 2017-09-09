using System.Security.Cryptography;
using System.Text;

public static partial class OrcusStringExtension
{
    public static string ToSha512(this string value)
    {
        value.ExceptionIfNull(nameof(value));

        using (var shaHash = new SHA512CryptoServiceProvider())
        {
            byte[] data = shaHash.ComputeHash(Encoding.UTF8.GetBytes(value));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
