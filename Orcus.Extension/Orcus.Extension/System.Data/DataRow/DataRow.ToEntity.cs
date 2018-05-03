using System;
using System.Data;
using System.Reflection;

public static partial class OrcusStringExtension
{
    public static T ToEntity<T>(this DataRow dataRow) where T : new()
    {
        Type type = typeof(T);
        PropertyInfo[] properties = type.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        FieldInfo[] fields = type.GetFields(BindingFlags.Public | BindingFlags.Instance);

        var entity = new T();

        foreach (PropertyInfo property in properties)
        {
            if (dataRow.Table.Columns.Contains(property.Name))
            {
                Type valueType = property.PropertyType;
                property.SetValue(entity, dataRow[property.Name].To(valueType), null);
            }
        }

        foreach (FieldInfo field in fields)
        {
            if (dataRow.Table.Columns.Contains(field.Name))
            {
                Type valueType = field.FieldType;
                field.SetValue(entity, dataRow[field.Name].To(valueType));
            }
        }

        return entity;
    }
}
