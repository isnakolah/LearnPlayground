using Algorithms.Exceptions;
using System.Runtime.CompilerServices;

[assembly: InternalsVisibleTo("Algorithms.Tests.Unit")]
namespace Algorithms.Search;

internal sealed class BinarySearch
{
    internal static int FindElement<T>(ICollection<T> collection, T item) where T : IComparable<T>
    {
        if (item is null)
            throw new ArgumentNullException(nameof(item));
        
        var (low, high) = (0, collection.Count - 1);

        while (low <= high)
        {
            var mid = (low + high) / 2;
            var guess = collection.ElementAt(mid);

            if (GuessEqualToItem(item, guess))
                return mid;
            if (GuessGreaterThanItem(item, guess))
                high = mid - 1;
            if (GuessLessThanItem(item, guess))
                low = mid + 1;
        }

        throw new ItemNotInCollectionException();
    }

    private static bool GuessLessThanItem<T>(T item, T guess) where T : IComparable<T>
    {
        return guess.CompareTo(item) == -1;
    }

    private static bool GuessGreaterThanItem<T>(T item, T guess) where T : IComparable<T>
    {
        return guess.CompareTo(item) == 1;
    }

    private static bool GuessEqualToItem<T>(T item, T guess) where T : IComparable<T>
    {
        return guess.CompareTo(item) == 0;
    }
}
