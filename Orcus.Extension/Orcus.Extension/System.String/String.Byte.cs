using System;

public static partial class OrcusStringExtension
{
    public static byte[] ToBytes(this string value)
    {
        value.ExceptionIfNull(nameof(value));

        var bytes = new byte[value.Length * sizeof(char)];
        Buffer.BlockCopy(value.ToCharArray(), 0, bytes, 0, bytes.Length);
        return bytes;
    }
}
