using System.Security.Cryptography;
using System.Text;

public static partial class OrcusStringExtension
{
    public static string ToMd5Hash(this string str)
    {
        str.ExceptionIfNull(nameof(str));

        using (var md5 = new MD5CryptoServiceProvider())
        {
            byte[] dizi = Encoding.UTF8.GetBytes(str);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();
            foreach (byte ba in dizi)
                sb.Append(ba.ToString("x2").ToLower());

            return sb.ToString();
        }
    }
}
