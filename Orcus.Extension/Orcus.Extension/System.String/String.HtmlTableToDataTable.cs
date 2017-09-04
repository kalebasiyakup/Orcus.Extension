using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;

public static partial class OrcusStringExtension
{
    public static DataTable HtmlTableToDataTable(this string html)
    {
        html.ThrowIfNull(nameof(html));

        return ParseTable(html);
    }

    private const RegexOptions ExpressionOptions = RegexOptions.Singleline | RegexOptions.Multiline | RegexOptions.IgnoreCase;

    private const string CommentPattern = "<!--(.*?)-->";
    //private const string TablePattern = "<table[^>]*>(.*?)</table>";
    private const string HeaderPattern = "<th[^>]*>(.*?)</th>";
    private const string RowPattern = "<tr[^>]*>(.*?)</tr>";
    private const string CellPattern = "<td[^>]*>(.*?)</td>";

    private static DataTable ParseTable(string tableHtml)
    {
        var tableHtmlWithoutComments = WithoutComments(tableHtml);

        var dataTable = new DataTable();

        var rowMatches = Regex.Matches(tableHtmlWithoutComments, RowPattern, ExpressionOptions);

        dataTable.Columns.AddRange(tableHtmlWithoutComments.Contains("<th") ? ParseColumns(tableHtml) : GenerateColumns(rowMatches));

        ParseRows(rowMatches, dataTable);

        return dataTable;
    }

    private static string WithoutComments(string html)
    {
        return Regex.Replace(html, CommentPattern, string.Empty, ExpressionOptions);
    }

    private static DataColumn[] ParseColumns(string tableHtml)
    {
        var headerMatches = Regex.Matches(tableHtml.Replace("<thead>", "").Replace("</thead>", ""), HeaderPattern, ExpressionOptions);

        return (from Match headerMatch in headerMatches
                select new DataColumn(headerMatch.Groups[1].ToString())).ToArray();
    }

    private static DataColumn[] GenerateColumns(MatchCollection rowMatches)
    {
        var columnCount = Regex.Matches(rowMatches[0].ToString(), CellPattern, ExpressionOptions).Count;

        return (from index in Enumerable.Range(0, columnCount)
                select new DataColumn("Column " + Convert.ToString(index))).ToArray();
    }

    private static void ParseRows(IEnumerable rowMatches, DataTable dataTable)
    {
        foreach (Match rowMatch in rowMatches)
        {
            // if the row contains header tags don't use it - it is a header not a row
            if (rowMatch.Value.Contains("<th")) continue;
            var dataRow = dataTable.NewRow();

            var cellMatches = Regex.Matches(
                rowMatch.Value,
                CellPattern,
                ExpressionOptions);

            for (var columnIndex = 0; columnIndex < cellMatches.Count; columnIndex++)
                dataRow[columnIndex] = cellMatches[columnIndex].Groups[1].ToString();

            dataTable.Rows.Add(dataRow);
        }
    }
}
