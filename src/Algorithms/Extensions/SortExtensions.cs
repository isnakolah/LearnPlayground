using Algorithms.Sort;

namespace Algorithms.Extensions;

public static class SortExtensions
{
    public static ICollection<T> Sort<T>(this ICollection<T> collection) where T : IComparable<T>
    {
        return SelectionSort.Sort(collection);
    }
}
