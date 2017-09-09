using System;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

public static partial class OrcusIEnumerableTExtension
{
    public static DataTable ToDataTable<T>(this IEnumerable<T> collection)
    {
        collection.ExceptionIfNull(nameof(collection));
        var dtReturn = new DataTable();

        PropertyInfo[] oProps = null;

        foreach (var rec in collection)
        {
            if (oProps == null)
            {
                oProps = rec.GetType().GetProperties();
                foreach (var pi in oProps)
                {
                    var colType = pi.PropertyType;

                    if ((colType.IsGenericType) && (colType.GetGenericTypeDefinition() == typeof(Nullable<>)))
                    {
                        colType = colType.GetGenericArguments()[0];
                    }

                    dtReturn.Columns.Add(new DataColumn(pi.Name, colType));
                }
            }

            var dr = dtReturn.NewRow();

            foreach (var pi in oProps)
                dr[pi.Name] = pi.GetValue(rec, null) ?? DBNull.Value;

            dtReturn.Rows.Add(dr);
        }
        return dtReturn;
    }
}
