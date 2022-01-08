namespace Algorithms.Common.Extensions;

public static class SortExtensions
{
    public static ICollection<T> SelectionSort<T>(this ICollection<T> collection) where T : IComparable<T>
    {
        return Sort.SelectionSort.Sort(collection);
    }
}
