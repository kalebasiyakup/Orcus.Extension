﻿using System.Security.Cryptography;
using System.Text;

public static partial class OrcusStringExtension
{
    public static string ToSha512(this string str)
    {
        return Sha512(str, new UTF8Encoding());
    }

    public static string ToSha512(this string str, Encoding encoding)
    {
        return Sha512(str, encoding);
    }

    private static string Sha512(string str, Encoding encoding)
    {
        str.ExceptionIfNull(nameof(str));

        using (var shaHash = new SHA512CryptoServiceProvider())
        {
            byte[] data = shaHash.ComputeHash(encoding.GetBytes(str));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
                sBuilder.Append(data[i].ToString("x2"));

            return sBuilder.ToString();
        }
    }
}
