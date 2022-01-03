﻿namespace Algorithms.Extensions;

public static class SearchExtensions
{
    public static int BinarySearch<T>(this ICollection<T> collection, T item) where T : IComparable<T>
    {
        return Search.BinarySearch.FindElement(collection, item);
    }
}
