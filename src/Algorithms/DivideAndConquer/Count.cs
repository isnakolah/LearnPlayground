namespace Algorithms.DivideAndConquer;

internal static partial class DivideAndConquer
{
    internal static int NumberOfItems(params int[] items)
    {
        if (items.Length == 1)
            return 1;

        return 1 + NumberOfItems(items[1..]);
    }
}