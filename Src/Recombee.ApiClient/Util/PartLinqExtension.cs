using System.Collections.Generic;
using System.Linq;

//http://stackoverflow.com/questions/13709626/split-an-ienumerablet-into-fixed-sized-chunks-return-an-ienumerableienumerab
static class PartLinqExtension
{ 
    public static IEnumerable<IEnumerable<T>> Part<T>(this IEnumerable<T> items, int partitionSize)
    {
        return items.Select((item, inx) => new { item, inx })
                    .GroupBy(x => x.inx / partitionSize)
                    .Select(g => g.Select(x => x.item));
    }
}
