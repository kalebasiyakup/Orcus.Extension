using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

public static partial class OrcusIListExtension
{
    public static void ToCsv<T>(this IList<T> list,
                                string pathToSave = @"c:\OrcusExport",
                                string fileName = "ExportCsv",
                                string delimiter = ";",
                                bool includeHeader = true,
                                string include = "",
                                string exclude = "") where T : class, new()
    {
        list.ExceptionIfNull(nameof(list));

        PropertyInfo[] props = typeof(T).GetProperties();
        List<PropertyInfo> propList = GetSelectedProperties(props, include, exclude);

        var result = new StringBuilder();

        if (includeHeader)
        {
            foreach (var column in propList)
            {
                result.Append(column.Name);
                result.Append(delimiter);
            }
            result.Remove(--result.Length, 0);
            result.Append(Environment.NewLine);
        }

        foreach (var row in list)
        {
            foreach (var prop in propList)
            {
                var val = prop.PropertyType == typeof(string) ? "\"{0}\"" : "{0}";
                result.Append(string.Format(val, prop.GetValue(row, null)) + delimiter);
            }

            result.Remove(--result.Length, 0);

            result.Append(Environment.NewLine);
        }
        if (!Directory.Exists(pathToSave))
            Directory.CreateDirectory(pathToSave);

        File.WriteAllText(string.Concat(pathToSave, pathToSave.Right(1) == @"\" ? "" : @"\", fileName, ".csv"), result.ToString());
    }

    private static List<PropertyInfo> GetSelectedProperties(PropertyInfo[] props, string include, string exclude)
    {
        List<PropertyInfo> propList = new List<PropertyInfo>();
        if (include != "")
        {
            var includeProps = include.ToLower().Split(',').ToList();
            foreach (var item in props)
            {
                var propName = includeProps.FirstOrDefault(a => a == item.Name.ToLower());
                if (!string.IsNullOrEmpty(propName))
                    propList.Add(item);
            }
        }
        else if (exclude != "")
        {
            var excludeProps = exclude.ToLower().Split(',');
            foreach (var item in props)
            {
                var propName = excludeProps.FirstOrDefault(a => a == item.Name.ToLower());
                if (string.IsNullOrEmpty(propName))
                    propList.Add(item);
            }
        }
        else
        {
            propList.AddRange(props.ToList());
        }
        return propList;
    }
}
