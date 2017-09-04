using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

public static partial class OrcusObjectExtension
{
    public static T DeserializeJson<T>(this string str)
    {
        str.ThrowIfNull(nameof(str));

        var serializer = new DataContractJsonSerializer(typeof(T));

        using (var stream = new MemoryStream(Encoding.Default.GetBytes(str)))
        {
            return (T)serializer.ReadObject(stream);
        }
    }

    public static T DeserializeJson<T>(this string str, Encoding encoding)
    {
        str.ThrowIfNull(nameof(str));

        var serializer = new DataContractJsonSerializer(typeof(T));

        using (var stream = new MemoryStream(encoding.GetBytes(str)))
        {
            return (T)serializer.ReadObject(stream);
        }
    }
}
