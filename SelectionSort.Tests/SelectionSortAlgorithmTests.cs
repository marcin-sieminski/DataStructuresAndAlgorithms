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
}