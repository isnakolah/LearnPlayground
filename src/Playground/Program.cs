using Algorithms.Common.Extensions;

var nums = new int[] { 3, -1, 20, 15, 2, 1, 2 }.Quicksort().ToArray();

Console.WriteLine(nums[..^3].Length);
