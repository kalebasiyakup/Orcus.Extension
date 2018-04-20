using System;
using System.ComponentModel;

public static partial class OrcusStringExtension
{
    public static T To<T>(this Object obj)
    {
        if (obj != null)
        {
            Type targetType = typeof(T);

            if (obj.GetType() == targetType)
            {
                return (T)obj;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(obj);
            if (converter != null)
            {
                if (converter.CanConvertTo(targetType))
                {
                    return (T)converter.ConvertTo(obj, targetType);
                }
            }

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null)
            {
                if (converter.CanConvertFrom(obj.GetType()))
                {
                    return (T)converter.ConvertFrom(obj);
                }
            }

            if (obj == DBNull.Value)
            {
                return (T)(object)null;
            }
        }

        return (T)obj;
    }

    public static object To(this Object obj, Type type)
    {
        if (obj != null)
        {
            Type targetType = type;

            if (obj.GetType() == targetType)
            {
                return obj;
            }

            TypeConverter converter = TypeDescriptor.GetConverter(obj);
            if (converter != null)
            {
                if (converter.CanConvertTo(targetType))
                {
                    return converter.ConvertTo(obj, targetType);
                }
            }

            converter = TypeDescriptor.GetConverter(targetType);
            if (converter != null)
            {
                if (converter.CanConvertFrom(obj.GetType()))
                {
                    return converter.ConvertFrom(obj);
                }
            }

            if (obj == DBNull.Value)
            {
                return null;
            }
        }

        return obj;
    }
}
