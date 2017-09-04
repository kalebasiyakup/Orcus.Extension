using System;
using System.Text;

public static partial class OrcusOperatingSystemExtension
{
    public static string FormatToHtml(this OperatingSystem operatingSystem)
    {
        operatingSystem.ThrowIfNull(nameof(operatingSystem));

        var stringBuilder = new StringBuilder();
        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:800px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");

        stringBuilder.Append("<tr>");
        stringBuilder.Append("<td valign=\"top\" width=\"109px\"><b><i>Operating System</i></b></td>");
        stringBuilder.Append("<td>");

        stringBuilder.Append("<table border=\"1\" cellpadding=\"1\" cellspacing=\"0\" style=\"text-align:left;width:680px;font-family:Tahoma;font-size: 12px;color:#000000;font-weight:normal;\">");
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("OS Version", operatingSystem.Version.ToString()));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("OS Platform", operatingSystem.Platform.ToString(), true));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("OS Service Pack", operatingSystem.ServicePack));
        stringBuilder.Append(OrcusHtmlFormat.RowAddColor("OS Version String", operatingSystem.VersionString, true));

        stringBuilder.Append("</table>");
        stringBuilder.Append("</td>");
        stringBuilder.Append("</tr>");

        stringBuilder.Append("</table>");

        return stringBuilder.ToString();
    }
}
