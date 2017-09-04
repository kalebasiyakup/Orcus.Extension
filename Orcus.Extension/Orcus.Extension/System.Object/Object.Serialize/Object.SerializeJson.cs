using System.Web.Script.Serialization;

public static partial class OrcusObjectExtension
{
    public static string SerializeJavaScript<T>(this T obj)
    {
        obj.ThrowIfNull(nameof(obj));

        var serializer = new JavaScriptSerializer();
        return serializer.Serialize(obj);
    }
}
