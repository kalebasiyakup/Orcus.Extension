using System;
using System.IO;
using System.Text;

public static partial class OrcusStringExtension
{ 
    public static Stream ToMemoryStream(this string str)
    {
        Encoding encoding = Activator.CreateInstance<ASCIIEncoding>();
        return new MemoryStream(encoding.GetBytes(str));
    }
}
