using Algorithms.Exceptions;
using Algorithms.Sort;

namespace Algorithms.Tests.Unit.Sort;

public class SelectionSortTests
{

    [Theory]
    [InlineData(new string[] { "Abakalwa", "Zion", "Davis", "Anna" }, new string[] { "Abakalwa", "Anna", "Davis", "Zion" })]
    [InlineData(new string[] { "10", "1", "3", "14", "0", "-1" }, new string[] { "-1", "0", "1", "3", "10", "14" })]
    public void Sort_ShouldReturnSortedCollection_WhenCollectionProvided(string[] collection, string[] _)
    {
        // Act
        var result = SelectionSort.Sort(collection);

        // Assert
        result.Should().BeInAscendingOrder();
    }

    [Theory]
    [InlineData(new string[] { "Abakalwa", "Zion", "Davis", "Anna" }, new string[] { "Abakalwa", "Anna", "Davis", "Zion" })]
    [InlineData(new string[] { "10", "1", "3", "14", "0", "-1" }, new string[] { "-1", "0", "1", "3", "10", "14" })]
    public void Sort_ShouldNotThrowError_WhenCollectionProvided(string[] collection, string[] _)
    {
        // Act
        var result = () => SelectionSort.Sort(collection);

        // Assert
        result.Should().NotThrow();
    }

    [Fact]
    public void Sort_ShouldThrowError_IfCollectionProvidedIsEmpty()
    {
        // Arrange
        var collection = Array.Empty<int>();

        // Act
        var result = () => SelectionSort.Sort(collection);

        // Assert
        result.Should().ThrowExactly<CollectionEmptyException>();
    }

    [Theory]
    [InlineData(new string[] { "Abakalwa", "Zion", "Davis", "Anna" }, "Abakalwa")]
    [InlineData(new string[] { "10", "1", "3", "14", "0", "-1" }, "-1")]
    public void FindSmallest_ShouldReturnSmallest_WhenCollectionProvided(string[] collection, string expectedResult)
    {
        // Act
        var result = SelectionSort.FindSmallest(collection);

        // Assert
        result.Should().Be(expectedResult);
    }
}
