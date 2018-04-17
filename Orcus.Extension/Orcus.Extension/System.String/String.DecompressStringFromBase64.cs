using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class OrcusStringExtension
{
    /// <summary>
    /// CompressStringToBase64 metotu ile sıkıştırılmış olan değeri GZip metotu ile açılmış olan değeri verir.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string DecompressStringFromBase64(this string value)
    {
        return _decompressStringFromBase64(value, new UTF8Encoding());
    }

    /// <summary>
    /// CompressStringToBase64 metotu ile sıkıştırılmış olan değeri GZip metotu ile açılmış olan değeri verir.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static string DecompressStringFromBase64(this string value, Encoding encoding)
    {
        return _decompressStringFromBase64(value, encoding);
    }

    private static string _decompressStringFromBase64(string value, Encoding encoding)
    {
        byte[] gZipBuffer = Convert.FromBase64String(value);
        using (var memoryStream = new MemoryStream())
        {
            int dataLength = BitConverter.ToInt32(gZipBuffer, 0);
            memoryStream.Write(gZipBuffer, 4, gZipBuffer.Length - 4);

            var buffer = new byte[dataLength];

            memoryStream.Position = 0;
            using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
            {
                gZipStream.Read(buffer, 0, buffer.Length);
            }

            return encoding.GetString(buffer);
        }
    }
}
