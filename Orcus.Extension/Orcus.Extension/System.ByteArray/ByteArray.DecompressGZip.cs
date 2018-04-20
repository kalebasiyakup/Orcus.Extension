using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class OrcusCharExtension
{
    public static string DecompressGZip(this byte[] @byte)
    {
        return _decompressGZip(@byte, Encoding.Default);
    }

    public static string DecompressGZip(this byte[] @byte, Encoding encoding)
    {
        return _decompressGZip(@byte, encoding);
    }

    private static string _decompressGZip(byte[] value, Encoding encoding)
    {
        const int bufferSize = 1024;
        using (var memoryStream = new MemoryStream(value))
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Decompress))
            {
                using (var outStream = new MemoryStream())
                {
                    var buffer = new byte[bufferSize];
                    int totalBytes = 0;
                    int readBytes;
                    while ((readBytes = zipStream.Read(buffer, 0, bufferSize)) > 0)
                    {
                        outStream.Write(buffer, 0, readBytes);
                        totalBytes += readBytes;
                    }
                    return encoding.GetString(outStream.GetBuffer(), 0, totalBytes);
                }
            }
        }
    }
}
