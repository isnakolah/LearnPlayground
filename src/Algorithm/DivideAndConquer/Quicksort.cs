namespace Algorithms;

internal static partial class DivideAndConquer
{
    internal static IList<int> Quicksort(this List<int> list)
    {
        if (list.Count < 2)
            return list;

        var (pivot, less, greater) = (list[0], new List<int>(), new List<int>());

        foreach (var x in list.Skip(1))
        {
            if (x >= pivot)
                greater.Add(x);
            else
                less.Add(x);
        }

        less.Quicksort().Add(pivot);
        less.AddRange(greater.Quicksort());

        return less;
    } 
}
