using static Algorithms.DivideAndConquer.DivideAndConquer;

namespace Algorithms.Tests.Unit.DivideAndConquer;

public class SumTests
{
    [Theory]
    [InlineData(new[] { 50, 60, 10, }, 120)]
    [InlineData(new[] { -10, 0, -3, 15 }, 2)]
    public void Sum_ShouldReturnSum_WhenItemsValid(int[] array, int expectedResult)
    {
        // Act
        var result = Sum(array);

        // Assert
        result.Should().Be(expectedResult);
    }
}
