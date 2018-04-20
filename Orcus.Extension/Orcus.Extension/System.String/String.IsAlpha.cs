﻿using System.Text.RegularExpressions;

public static partial class OrcusStringExtension
{
    public static bool IsAlpha(this string str)
    {
        return !Regex.IsMatch(str, "[^a-zA-Z]");
    }
}
