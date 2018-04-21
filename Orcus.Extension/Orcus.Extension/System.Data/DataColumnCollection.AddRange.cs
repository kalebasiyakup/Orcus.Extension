using System.Data;

public static partial class OrcusDataTableExtension
{
    public static void AddRange(this DataColumnCollection dataColumnCollection, params string[] columns)
    {
        foreach (var column in columns)
            dataColumnCollection.Add(column);
    }
}