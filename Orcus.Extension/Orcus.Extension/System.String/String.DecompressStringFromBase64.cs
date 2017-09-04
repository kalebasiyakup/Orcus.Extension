using System;
using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class OrcusStringExtension
{
    public static string DecompressStringFromBase64(this string value)
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

            return Encoding.UTF8.GetString(buffer);
        }
    }
}
