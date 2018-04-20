using System.IO;
using System.IO.Compression;
using System.Text;

public static partial class OrcusStringExtension
{
    public static byte[] CompressGZip(this string str)
    {
        str.ExceptionIfNull(nameof(str));

        return _compressGZip(str, Encoding.Default);
    }

    public static byte[] CompressGZip(this string str, Encoding encoding)
    {
        str.ExceptionIfNull(nameof(str));

        return _compressGZip(str, encoding);
    }

    private static byte[] _compressGZip(string str, Encoding encoding)
    {
        byte[] stringAsBytes = encoding.GetBytes(str);
        using (var memoryStream = new MemoryStream())
        {
            using (var zipStream = new GZipStream(memoryStream, CompressionMode.Compress))
            {
                zipStream.Write(stringAsBytes, 0, stringAsBytes.Length);
                zipStream.Close();
                return (memoryStream.ToArray());
            }
        }
    }
}
