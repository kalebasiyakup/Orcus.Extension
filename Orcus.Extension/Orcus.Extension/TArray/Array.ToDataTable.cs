using System;
using System.Data;
using System.Reflection;

public static partial class OrcusStringExtension
{
    public static DataTable ToDataTable<T>(this T[] obj)
    {
        Type type = typeof(T);

        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var dt = new DataTable();

        foreach (PropertyInfo property in properties)
        {
            dt.Columns.Add(property.Name, property.PropertyType);
        }

        foreach (FieldInfo field in fields)
        {
            dt.Columns.Add(field.Name, field.FieldType);
        }

        foreach (T item in obj)
        {
            DataRow dr = dt.NewRow();

            foreach (PropertyInfo property in properties)
            {
                dr[property.Name] = property.GetValue(item, null);
            }

            foreach (FieldInfo field in fields)
            {
                dr[field.Name] = field.GetValue(item);
            }

            dt.Rows.Add(dr);
        }

        return dt;
    }
}
