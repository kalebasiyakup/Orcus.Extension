using System.Globalization;
using System.Text;
using System.Web;

public static partial class OrcusHttpContextExtension
{
    public static string FormatHttpContext(this HttpContext httpContext)
    {
        httpContext.ExceptionIfNull(nameof(httpContext));

        var stringBuilder = new StringBuilder();
        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:800px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");

        stringBuilder.Append("<tr>");
        stringBuilder.Append("<td valign=\"top\" width=\"109px\"><b><i>Browser Detail</i></b></td>");
        stringBuilder.Append("<td>");

        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:680px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");

        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("UserHostAddress", httpContext.IpAdress()));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("ComputerName", httpContext.MachineName(), true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser", httpContext.Request.Browser.Browser));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.Type", httpContext.Request.Browser.Type, true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.Platform", httpContext.Request.Browser.Platform));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.Version", httpContext.Request.Browser.Version, true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.MajorVersion", httpContext.Request.Browser.MajorVersion.ToString()));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.MinorVersion", httpContext.Request.Browser.MinorVersion.ToString(CultureInfo.InvariantCulture), true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.ClrVersion", httpContext.Request.Browser.ClrVersion.ToString()));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("BrowserCookies", httpContext.Request.Browser.Cookies ? "Enabled" : "Disabled", true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.Frames", httpContext.Request.Browser.Frames ? "Enabled" : "Disabled"));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.JavaScript", httpContext.Request.Browser.JavaScript ? "Enabled" : "Disabled", true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("Browser.IsMobileDevice", httpContext.Request.Browser.IsMobileDevice ? "True" : "False"));

        stringBuilder.Append("</table>");
        stringBuilder.Append("</tr>");
        stringBuilder.Append("</td>");

        stringBuilder.Append("</table>");

        return stringBuilder.ToString();
    }
}
