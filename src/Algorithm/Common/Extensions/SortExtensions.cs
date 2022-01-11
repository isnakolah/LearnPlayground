namespace Algorithms.Common.Extensions;

public static class SortExtensions
{
    public static ICollection<T> SelectionSort<T>(this ICollection<T> collection) where T : IComparable<T>
    {
        return Sort.SelectionSort(collection);
    }

    public static List<int> Quicksort(this int[] arr)
    {
        return DivideAndConquer.Quicksort(arr.ToList()).ToList();
    }
}
