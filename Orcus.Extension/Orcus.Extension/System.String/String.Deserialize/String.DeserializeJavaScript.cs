﻿using System.Web.Script.Serialization;

public static partial class OrcusObjectExtension
{
    public static T DeserializeJavaScript<T>(this string str)
    {
        str.ExceptionIfNull(nameof(str));

        var serializer = new JavaScriptSerializer();
        return serializer.Deserialize<T>(str);
    }
}
