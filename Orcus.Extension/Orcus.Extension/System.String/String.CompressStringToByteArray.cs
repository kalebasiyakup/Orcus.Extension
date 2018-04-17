using System.IO.Compression;
using System.Text;

public static partial class OrcusStringExtension
{
    /// <summary>
    /// Değeri GZip metotu ile sıkıştırılmış byte değerine dönüştürür.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static byte[] CompressStringToByteArray(this string value)
    {
        return _compressStringToByteArray(value, new UTF8Encoding());
    }

    /// <summary>
    /// Değeri GZip metotu ile sıkıştırılmış byte değerine dönüştürür.
    /// </summary>
    /// <param name="value"></param>
    /// <param name="encoding"></param>
    /// <returns></returns>
    public static byte[] CompressStringToByteArray(this string value, Encoding encoding)
    {
        return _compressStringToByteArray(value, encoding);
    }

    private static byte[] _compressStringToByteArray(string value, Encoding encoding)
    {
        value.ExceptionIfNull(nameof(value));

        var buffer = encoding.GetBytes(value);
        var memoryStream = new System.IO.MemoryStream();
        using (var gZipStream = new GZipStream(memoryStream, CompressionMode.Compress, true))
        {
            gZipStream.Write(buffer, 0, buffer.Length);
        }

        memoryStream.Position = 0;

        var compressedData = new byte[memoryStream.Length];
        memoryStream.Read(compressedData, 0, compressedData.Length);

        return new byte[compressedData.Length + 4];
    }
}
