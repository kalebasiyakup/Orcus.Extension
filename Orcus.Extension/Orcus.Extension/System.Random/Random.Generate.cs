using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static partial class OrcusRandomExtension
{
    public static string RandomGenerate(this int length)
    {
        var generated = new StringBuilder();

        var randomizer = new Random();
        var possibleChars = new List<int>();
        possibleChars.AddRange(Enumerable.Range(48, 10)); //0-9
        possibleChars.AddRange(Enumerable.Range(65, 26)); //A-Z
        possibleChars.AddRange(Enumerable.Range(97, 26)); //a-z

        for (var i = 1; i <= length; i++)
            generated.Append((char)possibleChars[randomizer.Next(possibleChars.Count)]);

        return generated.ToString();
    }
}
