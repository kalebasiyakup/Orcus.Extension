using System;
using System.Data;
using System.IO;
using System.Text;

namespace Orcus.Extension
{
    public static partial class DataTableExtension
    {
        public static void ToCsv(this DataTable table, string delimiter, bool includeHeader, string savePath = @"c:\", string fileName = "export")
        {
            var result = new StringBuilder();

            if (includeHeader)
            {
                foreach (DataColumn column in table.Columns)
                {
                    result.Append(column.ColumnName);
                    result.Append(delimiter);
                }
                result.Remove(--result.Length, 0);
                result.Append(Environment.NewLine);
            }

            foreach (DataRow row in table.Rows)
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

            using (var writer = new StreamWriter(string.Concat(savePath, savePath.Right(1) == @"\" ? "" : @"\", fileName, ".csv"), true))
            {
                writer.Write(result.ToString());
            }
        }
    }
}
