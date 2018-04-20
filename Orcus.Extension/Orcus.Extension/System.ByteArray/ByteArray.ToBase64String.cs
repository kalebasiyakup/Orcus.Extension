using System;

public static partial class OrcusStringExtension
{
    public static String ToBase64String(this Byte[] @byte)
    {
        return Convert.ToBase64String(@byte);
    }

    public static String ToBase64String(this Byte[] @byte, Base64FormattingOptions options)
    {
        return Convert.ToBase64String(@byte, options);
    }
}
