using System.Text;

public static class OrcusHtmlFormat
{
    public static string RowAddColor(string a, string b, bool rowGri = false)
    {
        return string.Format(!rowGri ? "<tr><td>{0} = {1}</td></tr>" : "<tr style=\"background - color: #e9e9e9;\"><td>{0} = {1}</td></tr>", a, b);
    }

    public static string RowAdd(string key, string value)
    {
        var stringBuilder = new StringBuilder();
        stringBuilder.Append("<tr>");
        stringBuilder.Append(string.Concat("<td valign=\"top\" width=\"109px\"><b><i>", key, "</i></b></td>"));
        stringBuilder.Append(string.Concat("<td>", value, "</td>"));
        stringBuilder.Append("</tr>");
        return stringBuilder.ToString();
    }
}
