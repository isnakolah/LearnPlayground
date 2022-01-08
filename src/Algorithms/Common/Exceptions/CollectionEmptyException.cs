namespace Algorithms.Common.Exceptions;

internal class CollectionEmptyException : Exception
{
    public CollectionEmptyException() : base("Collection cannot be empty")
    {
    }
}
