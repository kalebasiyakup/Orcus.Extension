using System;
using System.Text;

public static class OrcusBarcode
{
    // JavaScript BarCode39 v. 1.0 (c) Lutz Tautenhahn, 2005
    // The author grants you a non-exclusive, royalty free, license to use,
    // modify and redistribute this software.
    // This software is provided "as is", without a warranty of any kind.

    private const string Chars = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ-. *$/+%";

    private static readonly string[] Codes = {
            "111221211","211211112","112211112","212211111","111221112","211221111","112221111","111211212",
            "211211211","112211211","211112112","112112112","212112111","111122112","211122111","112122111",
            "111112212","211112211","112112211","111122211","211111122","112111122","212111121","111121122",
            "211121121","112121121","111111222","211111221","112111221","111121221","221111112","122111112",
            "222111111","121121112","221121111","122121111","121111212","221111211","122111211","121121211",
            "121212111","121211121","121112121","111212121"};

    private static readonly string[] BarPic = { "http://www.yakupkalebasi.com/AttachFiles/b.gif", "http://www.yakupkalebasi.com/AttachFiles/w.gif" };

    public static string CreateCode39(string theX, string theY, int theBarHeight, int theFontHeight, string theBarCodeText, int theBarCodeSize)
    {
        var stringBuilder = new StringBuilder();
        var position = string.Empty;
        var barCodeSize = 1;

        if (theBarCodeSize > 0)
            barCodeSize = Convert.ToInt32(theBarCodeSize);

        if (barCodeSize < 1)
            barCodeSize = 1;

        if (!string.IsNullOrEmpty(theX) && !string.IsNullOrEmpty(theY))
        {
            position = "position:absolute;left:" + theX + ";top:" + theY + ";";
        }

        if (theFontHeight > 4 && (theBarHeight >= 2 * theFontHeight))
        {
            var fontStyle = "style=\"font-size:" + theFontHeight + "px;font-family:Verdana;\"";

            stringBuilder.Append("<div style=\"" + position + "font-size:" + theFontHeight + "px;font-family:Verdana;\">");
            stringBuilder.Append("<table noborder=\"\" cellpadding=\"0\" cellspacing=\"0\">");
            stringBuilder.Append("<tr>");
            stringBuilder.Append("<td rowspan=\"2\" valign=\"top\">" + CodePics("*", theBarHeight, barCodeSize) + "</td>");

            for (int i = 0; i < theBarCodeText.Length; i++)
                stringBuilder.Append("<td>" + CodePics(theBarCodeText.Substring(i, 1), theBarHeight - theFontHeight - 1, barCodeSize) + "</td>");

            stringBuilder.Append("<td rowspan=\"2\" valign=\"top\">" + CodePics("*", theBarHeight, barCodeSize) + "</td>");
            stringBuilder.Append("</tr>");
            stringBuilder.Append("<tr>");

            for (var i = 0; i < theBarCodeText.Length; i++)
                stringBuilder.Append("<td align=\"center\" " + fontStyle + ">" + theBarCodeText.Substring(i, 1) + "</td>");

            stringBuilder.Append("</tr>");
            stringBuilder.Append("</table>");
            stringBuilder.Append("</div>");
        }
        else
        {
            stringBuilder.Append("<div style=\"" + position + "\"><table noborder=\"0\" cellpadding=\"0\" cellspacing=\"0\">");
            stringBuilder.Append("<tr>");
            stringBuilder.Append("<td>" + CodePics("*", theBarHeight, barCodeSize) + "</td>");

            for (var i = 0; i < theBarCodeText.Length; i++)
                stringBuilder.Append("<td>" + CodePics(theBarCodeText.Substring(i, 1), theBarHeight, barCodeSize) + "</td>");

            stringBuilder.Append("<td>" + CodePics("*", theBarHeight, barCodeSize) + "</td>");
            stringBuilder.Append("</tr>");
            stringBuilder.Append("</table>");
            stringBuilder.Append("</div>");
        }

        return stringBuilder.ToString();
    }

    private static string CodePics(string theChar, int theHeight, int theSize)
    {
        var retVal = "";
        var cc = "9";
        var counter = Chars.IndexOf(theChar, StringComparison.Ordinal);

        if (counter >= 0)
            cc = Codes[counter];

        for (counter = 0; counter < cc.Length; counter++)
        {
            retVal += "<img src=\"" + BarPic[counter % 2] + "\" width=\"" + ((Convert.ToInt32(cc.Substring(counter, 1)) * (3 * theSize - theSize % 2) - theSize + theSize % 2) / 2) + "\" height=\"" + theHeight + "\">";
        }

        retVal += "<img src=\"" + BarPic[counter % 2] + "\" width=\"" + theSize + "\" height=\"" + theHeight + "\">";

        return (retVal);
    }
}
