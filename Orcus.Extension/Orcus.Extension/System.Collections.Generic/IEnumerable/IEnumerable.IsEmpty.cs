using System.Collections.Generic;
using System.Linq;

public static partial class OrcusIEnumerableTExtension
{
    public static bool IsEmpty<T>(this IEnumerable<T> enumerable)
    {
        return !enumerable.Any();
    }
}
