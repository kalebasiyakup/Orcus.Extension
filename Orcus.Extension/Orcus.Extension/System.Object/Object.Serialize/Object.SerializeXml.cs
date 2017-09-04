using System.IO;
using System.Xml.Serialization;

public static partial class OrcusObjectExtension
{
    public static string SerializeXml(this object obj)
    {
        obj.ThrowIfNull(nameof(obj));

        var xmlSerializer = new XmlSerializer(obj.GetType());

        using (var stringWriter = new StringWriter())
        {
            xmlSerializer.Serialize(stringWriter, obj);
            using (var streamReader = new StringReader(stringWriter.GetStringBuilder().ToString()))
            {
                return streamReader.ReadToEnd();
            }
        }
    }
}
