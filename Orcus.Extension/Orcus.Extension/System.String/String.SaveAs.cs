using System.IO;

public static partial class OrcusStringExtension
{
    public static void SaveAs(this string str, string fileName, bool append = false)
    {
        using (TextWriter tw = new StreamWriter(fileName, append))
        {
            tw.Write(str);
        }
    }

    public static void SaveAs(this string str, FileInfo file, bool append = false)
    {
        using (TextWriter tw = new StreamWriter(file.FullName, append))
        {
            tw.Write(str);
        }
    }
}
