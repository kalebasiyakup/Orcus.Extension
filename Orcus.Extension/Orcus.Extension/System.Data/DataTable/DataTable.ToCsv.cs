using System;
using System.Data;
using System.IO;
using System.Text;

public static partial class OrcusDataTableExtension
{
    public static void ToCsv(this DataTable sourceDataTable,
                                string pathToSave = @"c:\OrcusExport",
                                string fileName = "ExportCsv",
                                string delimiter = ";", 
                                bool includeHeader = true)
    {
        sourceDataTable.ExceptionIfNull(nameof(sourceDataTable));

        var result = new StringBuilder();

        if (includeHeader)
        {
            foreach (DataColumn column in sourceDataTable.Columns)
            {
                result.Append(column.ColumnName);
                result.Append(delimiter);
            }
            result.Remove(--result.Length, 0);
            result.Append(Environment.NewLine);
        }

        foreach (DataRow row in sourceDataTable.Rows)
        {
            foreach (var item in row.ItemArray)
            {
                if (item is DBNull)
                    result.Append(delimiter);
                else
                {
                    var itemAsString = item.ToString();
                    itemAsString = itemAsString.Replace("\"", "\"\"");
                    itemAsString = "\"" + itemAsString + "\"";
                    result.Append(itemAsString + delimiter);
                }
            }

            result.Remove(--result.Length, 0);

            result.Append(Environment.NewLine);
        }

        if (!Directory.Exists(pathToSave))
            Directory.CreateDirectory(pathToSave);

        File.WriteAllText(string.Concat(pathToSave, pathToSave.Right(1) == @"\" ? "" : @"\", fileName, ".csv"), result.ToString());
    }
}
