using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public static partial class OrcusObjectExtension
{
    public static T DeserializeBinary<T>(this string str)
    {
        str.ExceptionIfNull(nameof(str));

        using (var stream = new MemoryStream(Encoding.Default.GetBytes(str)))
        {
            var binaryRead = new BinaryFormatter();
            return (T)binaryRead.Deserialize(stream);
        }
    }

    public static T DeserializeBinary<T>(this string str, Encoding encoding)
    {
        str.ExceptionIfNull(nameof(str));

        using (var stream = new MemoryStream(encoding.GetBytes(str)))
        {
            var binaryRead = new BinaryFormatter();
            return (T)binaryRead.Deserialize(stream);
        }
    }
}
