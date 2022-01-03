namespace Algorithms.Exceptions;

internal class CollectionEmptyException : Exception
{
    public CollectionEmptyException() : base("Collection cannot be empty")
    {
    }
}
