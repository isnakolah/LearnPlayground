namespace Algorithms.Common.Exceptions;

internal sealed class ItemNotInCollectionException : Exception
{
    public ItemNotInCollectionException() : base("Item not in the collection")
    {
    }
}