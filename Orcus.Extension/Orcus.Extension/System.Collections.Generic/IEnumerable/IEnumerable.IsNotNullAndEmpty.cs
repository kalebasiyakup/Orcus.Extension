using System.Collections.Generic;
using System.Linq;

public static partial class OrcusIEnumerableTExtension
{
    public static bool IsNotNullAndEmpty<T>(this IEnumerable<T> enumerable)
    {
        return enumerable != null && enumerable.Any();
    }
}
