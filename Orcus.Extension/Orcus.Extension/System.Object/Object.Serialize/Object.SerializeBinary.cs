using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;

public static partial class OrcusObjectExtension
{
    public static string SerializeBinary<T>(this T obj)
    {
        obj.ExceptionIfNull(nameof(obj));

        var binaryWrite = new BinaryFormatter();

        using (var memoryStream = new MemoryStream())
        {
            binaryWrite.Serialize(memoryStream, obj);
            return Encoding.Default.GetString(memoryStream.ToArray());
        }
    }

    public static string SerializeBinary<T>(this T obj, Encoding encoding)
    {
        obj.ExceptionIfNull(nameof(obj));

        var binaryWrite = new BinaryFormatter();

        using (var memoryStream = new MemoryStream())
        {
            binaryWrite.Serialize(memoryStream, obj);
            return encoding.GetString(memoryStream.ToArray());
        }
    }
}
