using System;
using System.Collections;
using System.Linq;
using System.Text;

public static class OrcusExceptionExtension
{
    public static string FormatExceptionToHtml(this Exception ex)
    {
        ex.ExceptionIfNull(nameof(ex));

        var stringBuilder = new StringBuilder();

        #region HtmlBase
        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:800px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");
        stringBuilder.Append(OrcusHtmlFormat.RowAdd("Source", ex.Source));
        stringBuilder.Append(OrcusHtmlFormat.RowAdd("Message", ex.Message));
        stringBuilder.Append(OrcusHtmlFormat.RowAdd("StackTrace", ex.StackTrace));
        if (ex.InnerException != null)
            stringBuilder.Append(OrcusHtmlFormat.RowAdd("InnerException Message", ex.InnerException.Message));

        #endregion

        #region ExceptionData

        foreach (var pair in from DictionaryEntry pair in ex.Data
                             where pair.Key.ToString().Contains("SQLCOMMANDERROR")
                             select pair)
        {
            stringBuilder.Append(pair.Value);
        }

        if (!(from DictionaryEntry pair in ex.Data
              where !pair.Key.ToString().Contains("SQLCOMMANDERROR")
              where !pair.Key.ToString().Contains("HelpLink.")
              select pair).Any())
        {
            stringBuilder.Append("</table>");
            return stringBuilder.ToString();
        }

        stringBuilder.Append("<tr>");
        stringBuilder.Append("<td valign=\"top\" width=\"109px\"><b><i>Exception Data</i></b></td>");
        stringBuilder.Append("<td>");

        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:680px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");

        var rowGri = false;
        foreach (var pair in from DictionaryEntry pair in ex.Data
                             where !pair.Key.ToString().Contains("SQLCOMMANDERROR")
                             where !pair.Key.ToString().Contains("HelpLink.")
                             select pair)
        {
            stringBuilder.Append(OrcusHtmlFormat.RowAddColor(pair.Key.ToString(), pair.Value.ToString(), rowGri));
            rowGri = !rowGri;
        }

        stringBuilder.Append("</table>");
        stringBuilder.Append("</tr>");
        stringBuilder.Append("</td>");
        #endregion

        stringBuilder.Append("</table>");
        return stringBuilder.ToString();
    }
}
