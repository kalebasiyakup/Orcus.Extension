using System.IO;
using System.Xml.Serialization;

public static partial class OrcusObjectExtension
{
    public static T DeserializeXml<T>(this string str)
    {
        str.ThrowIfNull(nameof(str));

        var xmlSerializer = new XmlSerializer(typeof(T));
        var stringReader = new StringReader(str);

        return (T)xmlSerializer.Deserialize(stringReader);
    }
}
