namespace Algorithms;

internal static partial class DivideAndConquer
{
    internal static int Sum(params int[] items)
    {
        if (items.Length == 1)
            return items[0];

        return items[0] + Sum(items[1..]);
    }
}
