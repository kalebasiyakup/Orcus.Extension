using System.Collections.Generic;
using System.Linq;

public static partial class OrcusIEnumerableTExtension
{
    public static bool IsNotEmpty<T>(this IEnumerable<T> enumerable)
    {
        return enumerable.Any();
    }
}
