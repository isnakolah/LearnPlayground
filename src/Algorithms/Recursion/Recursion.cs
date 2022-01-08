namespace Algorithms.Recursion;

internal sealed class Recursion
{
    internal static void CountDown(int i)
    {
        Console.WriteLine(i);

        if (i <= 0)
            return;

        CountDown(i - 1);
    }
}
