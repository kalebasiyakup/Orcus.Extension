using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

public static partial class OrcusDataTableExtension
{
    public static List<T> DataTableToList<T>(this DataTable dataTable) where T : class, new()
    {
        dataTable.ExceptionIfNull(nameof(dataTable));

        List<T> returnList;
        if (dataTable != null)
        {
            var properties = typeof(T).GetProperties();
            var strs = new Dictionary<string, PropertyInfo>();
            var propertyInfoArray = properties;
            foreach (var propertyInfo in propertyInfoArray)
            {
                if (dataTable.Columns[propertyInfo.Name] != null && !strs.Keys.Contains(propertyInfo.Name))
                    strs.Add(propertyInfo.Name, propertyInfo);
            }
            var tempList = new List<T>();
            foreach (DataRow row in dataTable.Rows)
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
