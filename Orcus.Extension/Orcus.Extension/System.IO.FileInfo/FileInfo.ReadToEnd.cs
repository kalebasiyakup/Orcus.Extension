using System.IO;
using System.Text;

public static partial class OrcusFileInfoExtension
{
    public static string ReadToEnd(this FileInfo fileInfo)
    {
        using (FileStream stream = File.Open(fileInfo.FullName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
        {
            using (var reader = new StreamReader(stream, Encoding.Default))
            {
                return reader.ReadToEnd();
            }
        }
    }
}
