using Algorithms.Exceptions;
using Algorithms.Search;

namespace Algorithms.Tests.Unit.Search;

public class BinarySearchTests
{
    [Fact]
    public void FindElement_ShouldThrow_NullArgumentException_WhenItemIsNull()
    {
        // Arrange
        var collection = new string[] { "Test1", "Test2", "Test3" };

        // Act
        var result = () => BinarySearch.FindElement(collection, null);

        // Assert
        result.Should().Throw<ArgumentNullException>().WithParameterName("item");
    }

    [Fact]
    public void FindElement_ShouldThrow_ItemNotInCollectionException_WhenItemNotInCollection()
    {
        // Arrange
        var collection = new string[] { "Test1", "Test2", "Test3" };

        // Act
        var result = () => BinarySearch.FindElement(collection, "Test4");

        // Assert
        result.Should().ThrowExactly<ItemNotInCollectionException>();
    }

    [Theory]
    [InlineData(new string[] { "Test1", "Test2", "Test3" }, "Test2", 1)]
    [InlineData(new string[] { "10", "13", "18", "23"}, "18", 2)]
    [InlineData(new string[] {"Abacas", "Abandon", "Abraham"}, "Abacas", 0)]
    public void FindElement_ShouldReturnIndex_IfItemExistsInCollection(string[] collection, string item, int expectedIndex)
    {
        // Act 
        var result = BinarySearch.FindElement(collection, item);

        // Assert
        result.Should().Be(expectedIndex);
    }

    [Fact]
    public void FindElement_ShouldNotThrowAnyException_IfItemInCollection()
    {
        // Arrange
        var collection = new string[] { "Test1", "Test2", "Test3" };

        // Act 
        var result = () => BinarySearch.FindElement(collection, "Test2");

        // Assert
        result.Should().NotThrow();
    }
}
