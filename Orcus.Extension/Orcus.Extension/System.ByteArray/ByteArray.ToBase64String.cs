using System;

public static partial class OrcusStringExtension
{
    public static string ToBase64String(this byte[] @byte)
    {
        return Convert.ToBase64String(@byte);
    }

    public static string ToBase64String(this byte[] @byte, Base64FormattingOptions options)
    {
        return Convert.ToBase64String(@byte, options);
    }
}
