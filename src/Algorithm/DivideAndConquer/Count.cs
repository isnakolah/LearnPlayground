namespace Algorithms;

internal static partial class DivideAndConquer
{
    internal static int Count(params int[] items)
    {
        if (items.Length == 1)
            return 1;

        return 1 + Count(items[1..]);
    }
}