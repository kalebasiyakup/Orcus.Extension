using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

public static partial class OrcusObjectExtension
{
    public static string SerializeJson<T>(this T obj)
    {
        obj.ExceptionIfNull(nameof(obj));

        var serializer = new DataContractJsonSerializer(typeof(T));

        using (var memoryStream = new MemoryStream())
        {
            serializer.WriteObject(memoryStream, obj);
            return Encoding.Default.GetString(memoryStream.ToArray());
        }
    }

    public static string SerializeJson<T>(this T obj, Encoding encoding)
    {
        obj.ExceptionIfNull(nameof(obj));

        var serializer = new DataContractJsonSerializer(typeof(T));

        using (var memoryStream = new MemoryStream())
        {
            serializer.WriteObject(memoryStream, obj);
            return encoding.GetString(memoryStream.ToArray());
        }
    }
}
