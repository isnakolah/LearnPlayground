using Algorithms.Extensions;
using System.Runtime.CompilerServices;
using static Algorithms.DivideAndConquer.DivideAndConquer;

[assembly: InternalsVisibleTo("Algorithms.Tests.Unit")]
namespace Algorithms;

public static class Main
{
    public static void Run()
    {
        var total = Sum(10, 32, 132, 15);
        var noOfItems = NumberOfItems(10, 123, 15);
        var maxNumber = Max(10, 123, 1, 150, 20, 13323, 10, 1305);

        Console.WriteLine(total);
        Console.WriteLine(noOfItems);
        Console.WriteLine(maxNumber);
    }

    internal static void SortAndSearch()
    {
        var marks = new int[] 
        { 13, 14, 15, 16, 17, 1, 2, 26, 27, 28, 29, 5, 6, 7, 8, 9, 10, 11, 12, 18, 19, 20, 21, 22, 30, 31, 3, 4, 23, 24, 25, 32 };

        var lowest = marks.SelectionSort().BinarySearch(10);

        Console.WriteLine(lowest);
    }
}