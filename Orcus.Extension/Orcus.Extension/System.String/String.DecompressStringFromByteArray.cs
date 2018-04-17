using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class OrcusStringExtension
{
    /// <summary>
    /// CompressStringToByteArray metotu ile sıkıştırılmış olan değeri GZip metotu ile açılmış olan değeri verir.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string DecompressStringFromByteArray(this byte[] value)
    {
        return _decompressStringFromByteArray(value, new UTF8Encoding());
    }

    /// <summary>
    /// CompressStringToByteArray metotu ile sıkıştırılmış olan değeri GZip metotu ile açılmış olan değeri verir.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static string DecompressStringFromByteArray(this byte[] value, Encoding encoding)
    {
        return _decompressStringFromByteArray(value, encoding);
    }

    private static string _decompressStringFromByteArray(byte[] value, Encoding encoding)
    {
        value.ExceptionIfNull(nameof(value));

        using (var memoryStream = new MemoryStream())
        {
            int dataLength = BitConverter.ToInt32(value, 0);
            memoryStream.Write(value, 4, value.Length - 4);

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
