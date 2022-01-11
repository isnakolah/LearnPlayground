using System.Runtime.CompilerServices;
using static Algorithms.DivideAndConquer;

[assembly: InternalsVisibleTo("Algorithms.Tests.Unit")]

var sorted = Quicksort(10, 11, 3, 5, 10, 5, 2);

Console.WriteLine(sorted.FirstOrDefault());
