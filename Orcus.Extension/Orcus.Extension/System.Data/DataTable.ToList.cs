using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;

namespace Orcus.Extension
{
    public static partial class DataTableExtension
    {
        public static List<T> ToList<T>(this DataTable dt)
        {
            List<T> ts;
            if (dt != null)
            {
                var properties = typeof(T).GetProperties();
                var strs = new Dictionary<string, PropertyInfo>();
                var propertyInfoArray = properties;
                foreach (var propertyInfo in propertyInfoArray)
                {
                    if (dt.Columns[propertyInfo.Name] != null && !strs.Keys.Contains(propertyInfo.Name))
                        strs.Add(propertyInfo.Name, propertyInfo);
                }
                var ts1 = new List<T>();
                foreach (DataRow row in dt.Rows)
                {
                    var t = Activator.CreateInstance<T>();
                    foreach (var str in strs)
                    {
                        if (!(row[str.Key] is DBNull))
                            str.Value.SetValue(t, row[str.Key]);
                        else
                            str.Value.SetValue(t, null);
                    }
                    ts1.Add(t);
                }
                ts = ts1;
            }
            else
            {
                ts = null;
            }
            return ts;
        }
    }
}
