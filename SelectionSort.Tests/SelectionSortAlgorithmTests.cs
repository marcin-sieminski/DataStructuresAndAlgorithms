namespace SelectionSort.Tests;

public class SelectionSortAlgorithmTests
{
    [Fact]
    public void GivenOneElementArray_ShouldReturnInputArray()
    {
        var input = new[] { 1 };
        var sut = new SelectionSort();

        var result = sut.Sort(input);

        Assert.Equal(result, input);
    }

    [Theory]
    [InlineData(new[] { 0, -1 })]
    [InlineData(new[] { 2, 1 })]
    [InlineData(new[] { 10, 20 })]
    public void Given2ElementArray_ShouldReturnSorted2ElementArray(int[] input)
    {
        var sut = new SelectionSort();

        var result = sut.Sort(input);

        Assert.Equal(2, result.Length);
        Assert.True(result[0] < result[1]);
    }

    [Theory]
    [InlineData(new[] { 2, 1, 52, -400, 12 })]
    [InlineData(new[] { 10, 20, 111, 0, 0, 1, -5, -45, -55, 1111 })]
    public void GivenAnyArray_ShouldReturnSortedArray(int[] input)
    {
        var sut = new SelectionSort();

        var result = sut.Sort(input);

        for (int i = 0; i < result.Length - 1; i++)
        {
            Assert.True(result[i] <= result[i + 1]);
        }
    }
}