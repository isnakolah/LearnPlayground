namespace Algorithms;

internal static partial class DivideAndConquer
{
    internal static List<int> Quicksort(List<int> arr)
    {
        if (arr.Count <= 1)
            return arr;

        var pivot = arr[0];
        var less = new List<int>();
        var greater = new List<int>();

        arr.ForEach(x =>
        {
            if (x < pivot)
                less.Add(x);
            else
                greater.Add(x);
        });

        less.Add(pivot);
        less.AddRange(greater);

        return less;
    }

    internal static List<int> Quicksort(params int[] arr)
    {
        return Quicksort(arr.ToList());
    }
}
