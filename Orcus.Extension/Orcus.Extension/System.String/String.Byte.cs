using System;

public static partial class OrcusStringExtension
{
    public static byte[] ToBytes(this string str)
    {
        str.ExceptionIfNull(nameof(str));

        var bytes = new byte[str.Length * sizeof(char)];
        Buffer.BlockCopy(str.ToCharArray(), 0, bytes, 0, bytes.Length);
        return bytes;
    }
}
