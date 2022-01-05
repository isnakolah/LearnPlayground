using Algorithms.Exceptions;

namespace Algorithms.Sort;

internal static class SelectionSort
{
    public static ICollection<T> Sort<T>(ICollection<T> collection) where T : IComparable<T>
    {
        if (collection.Count == 0)
            throw new CollectionEmptyException();

        collection = collection.ToList();

        var count = collection.Count;

        var sortedCollection = new List<T>();

        for (int i = 0; i < count; i++)
        {
            var smallestElement = FindSmallest(collection);

            if (collection.Remove(smallestElement))
                sortedCollection.Add(smallestElement);
        }

        return sortedCollection;
    }

    internal static T FindSmallest<T>(ICollection<T> collection) where T : IComparable<T>
    {
        var smallestElement = collection.First();

        foreach (var item in collection)
        {
            if (item.CompareTo(smallestElement) == -1)
                smallestElement = item;
        }

        return smallestElement;
    }
}
