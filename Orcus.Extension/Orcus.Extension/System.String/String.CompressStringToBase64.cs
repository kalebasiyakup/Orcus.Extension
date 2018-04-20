using System;
using System.IO.Compression;
using System.Text;

public static partial class OrcusStringExtension
{
    /// <summary>
    /// Değeri GZip metotu ile sıkıştırılmış Base64 değerine dönüştürür.
    /// </summary>
    /// <param name="str"></param>
    /// <returns></returns>
    public static string CompressStringToBase64(this string str)
    {
        return _compressStringToBase64(str, new UTF8Encoding());
    }

    /// <summary>
    /// Değeri GZip metotu ile sıkıştırılmış Base64 değerine dönüştürür.
    /// </summary>
    /// <param name="str"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static string CompressStringToBase64(this string str, Encoding encoding)
    {
        return _compressStringToBase64(str, encoding);
    }

    private static string _compressStringToBase64(string str, Encoding encoding)
    {
        str.ExceptionIfNull(nameof(str));

        var buffer = encoding.GetBytes(str);
        using (var memoryStream = new System.IO.MemoryStream())
        {
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
                gZipStream.Write(buffer, 0, buffer.Length);

            memoryStream.Position = 0;

            var compressedData = new byte[memoryStream.Length];
            memoryStream.Read(compressedData, 0, compressedData.Length);

            var gZipBuffer = new byte[compressedData.Length + 4];
            Buffer.BlockCopy(compressedData, 0, gZipBuffer, 4, compressedData.Length);
            Buffer.BlockCopy(BitConverter.GetBytes(buffer.Length), 0, gZipBuffer, 0, 4);
            return Convert.ToBase64String(gZipBuffer);
        }
    }
}
