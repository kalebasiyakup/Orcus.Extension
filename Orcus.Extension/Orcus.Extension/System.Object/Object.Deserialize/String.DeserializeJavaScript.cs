using System.Web.Script.Serialization;

public static partial class OrcusObjectExtension
{
    public static T DeserializeJavaScript<T>(this string str)
    {
        str.ThrowIfNull(nameof(str));

        var serializer = new JavaScriptSerializer();
        return serializer.Deserialize<T>(str);
    }
}
