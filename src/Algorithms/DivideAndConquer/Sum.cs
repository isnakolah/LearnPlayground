namespace Algorithms.DivideAndConquer;

internal static class DivideAndConquerSum
{
    internal static int Sum(params int[] items)
    {
        if (items.Length == 1)
            return items[0];

        return items[0] + Sum(items[1..]);
    }

    internal static int NumberOfItems(params int[] items)
    {
        if (items.Length == 1)
            return 1;

        return 1 + NumberOfItems(items[1..]);
    }

    internal static int MaximumNumber(params int[] items)
    {
        if (items.Length == 1)
            return 1;

        return items[0] > MaximumNumber(items[1..]) ? items[0] : MaximumNumber(items[1..]);
    }
}
