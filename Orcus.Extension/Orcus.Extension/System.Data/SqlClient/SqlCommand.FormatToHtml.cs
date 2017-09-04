using System;
using System.Data.SqlClient;
using System.Text;

public static partial class OrcusSqlCommandExtension
{
    public static string FormatToHtml(this SqlCommand sqlCommand)
    {
        sqlCommand.ThrowIfNull(nameof(sqlCommand));

        var stringBuilder = new StringBuilder();

        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:800px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");

        stringBuilder.Append(OrcusHtmlFormat.RowAdd("CommandType", sqlCommand.CommandType.ToString()));

        var connStr = sqlCommand.Connection.ConnectionString;
        if (!string.IsNullOrEmpty(connStr))
        {
            var ind1 = connStr.IndexOf("Password", StringComparison.Ordinal);

            if (ind1 > -1)
            {
                stringBuilder.Append(OrcusHtmlFormat.RowAdd("Connection", connStr.Substring(0, ind1)));
            }
        }

        stringBuilder.Append(OrcusHtmlFormat.RowAdd("CommandText", sqlCommand.CommandText));

        if (sqlCommand.Parameters.Count > 0)
        {
            stringBuilder.Append("<tr>");
            stringBuilder.Append("<td valign=\"top\" width=\"109px\"><b><i>Parameters</i></b></td>");
            stringBuilder.Append("<td>");

            stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:680px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");

            foreach (SqlParameter parameter in sqlCommand.Parameters)
            {
                stringBuilder.Append(OrcusHtmlFormat.RowAddColor(parameter.ParameterName, (parameter.Value?.ToString() ?? "null")));
            }

            stringBuilder.Append("</table>");
            stringBuilder.Append("</tr>");
            stringBuilder.Append("</td>");
        }

        stringBuilder.Append("</table>");

        return stringBuilder.ToString();
    }
}
