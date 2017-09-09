using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

public static partial class OrcusDataTableExtension
{
    public static List<T> DataTableToList<T>(this DataTable sourceDataTable) where T : class, new()
    {
        sourceDataTable.ExceptionIfNull(nameof(sourceDataTable));

        List<T> returnList;
        if (sourceDataTable != null)
        {
            var properties = typeof(T).GetProperties();
            var strs = new Dictionary<string, PropertyInfo>();
            var propertyInfoArray = properties;
            foreach (var propertyInfo in propertyInfoArray)
            {
                if (sourceDataTable.Columns[propertyInfo.Name] != null && !strs.Keys.Contains(propertyInfo.Name))
                    strs.Add(propertyInfo.Name, propertyInfo);
            }
            var tempList = new List<T>();
            foreach (DataRow row in sourceDataTable.Rows)
            {
                var t = Activator.CreateInstance<T>();
                foreach (var str in strs)
                {
                    if (!(row[str.Key] is DBNull))
                        str.Value.SetValue(t, row[str.Key]);
                    else
                        str.Value.SetValue(t, null);
                }
                tempList.Add(t);
            }
            returnList = tempList;
        }
        else
        {
            returnList = null;
        }
        return returnList;
    }
}
