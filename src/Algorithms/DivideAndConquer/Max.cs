namespace Algorithms;

internal static partial class DivideAndConquer
{
    internal static int Max(params int[] items)
    {
        if (items.Length == 1)
            return 1;

        return items[0] > Max(items[1..]) ? items[0] : Max(items[1..]);
    }
}