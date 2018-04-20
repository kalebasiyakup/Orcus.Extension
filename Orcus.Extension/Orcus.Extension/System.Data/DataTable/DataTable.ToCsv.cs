using System;
using System.Data;
using System.IO;
using System.Text;

public static partial class OrcusDataTableExtension
{
    public static void ToCsv(this DataTable dataTable,
                                string pathToSave = @"c:\OrcusExport",
                                string fileName = "ExportCsv",
                                string delimiter = ";", 
                                bool includeHeader = true)
    {
        dataTable.ExceptionIfNull(nameof(dataTable));

        var result = new StringBuilder();

        if (includeHeader)
        {
            foreach (DataColumn column in dataTable.Columns)
            {
                result.Append(column.ColumnName);
                result.Append(delimiter);
            }
            result.Remove(--result.Length, 0);
            result.Append(Environment.NewLine);
        }

        foreach (DataRow row in dataTable.Rows)
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
