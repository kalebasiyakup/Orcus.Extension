using System;

public static partial class OrcusStringExtension
{
    public static bool IsNotNullOrWhiteSpace(this string str)
    {
        return !String.IsNullOrWhiteSpace(str);
    }
}
