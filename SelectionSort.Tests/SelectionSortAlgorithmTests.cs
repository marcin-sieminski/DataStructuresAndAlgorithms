namespace SelectionSort.Tests;

public class SelectionSortAlgorithmTests
{
    [Theory]
    [InlineData(new[] { 0 })]
    [InlineData(new[] { 1 })]
    [InlineData(new[] { -155 })]
    [InlineData(new[] { -2000000 })]
    public void GivenOneElementIntArray_ShouldReturnInputArray(int[] array)
    {
        var expected = new[] { array[0] };

        SelectionSortHelper.Sort(array);

        Assert.Equal(expected, array);
    }

    [Theory]
    [InlineData(new[] { 0, -1 })]
    [InlineData(new[] { 2, 1 })]
    [InlineData(new[] { 100, 20 })]
    [InlineData(new[] { 5, 0 })]
    public void Given2ElementIntArray_ShouldReturnSorted2ElementArray(int[] array)
    {
        SelectionSortHelper.Sort(array);

        Assert.Equal(2, array.Length);
        Assert.True(array[0] <= array[1]);
    }

    [Theory]
    [InlineData(new[] { 2, 1, 52, -400, 12 })]
    [InlineData(new[] { 10, 20, 111, 0, 0, 1, -5, -45, -55, 1111 })]
    [InlineData(new[] { -2000000, 123, 999, -1, -98788, 1000000, 90000000, -90000000 })]
    [InlineData(new[] { Int32.MaxValue, Int32.MinValue })]
    public void GivenAnySizeIntArray_ShouldReturnSortedArray(int[] array)
    {
        SelectionSortHelper.Sort(array);

        for (int i = 0; i < array.Length - 1; i++)
        {
            Assert.True(array[i] <= array[i + 1]);
        }
    }

    [Theory]
    [InlineData(new[] { 10.5, -45.55, 555.12, 555.12, 0.0, 1054.5 })]
    [InlineData(new[] { 789.1, -2558.5556, -56565.55555, -656.0, 154756.66555, 0.5 })]
    [InlineData(new[] { Double.MaxValue, Double.MinValue })]
    public void GivenDoubleArray_ShouldReturnSortedArray(double[] array)
    {
        SelectionSortHelper.Sort(array);

        for (var i = 0; i < array.Length - 1; i++)
        {
            Assert.True(array[i] <= array[i + 1]);
        }
    }

    [Theory]
    [InlineData(new[] { 1.0f, 15656.4555f, 0.56565f, -6565.5656f })]
    [InlineData(new[] { float.MaxValue, float.MinValue })]
    public void GivenFloatTypeArray_ShouldReturnSortedArray(float[] array)
    {
        SelectionSortHelper.Sort(array);

        for (var i = 0; i < array.Length - 1; i++)
        {
            Assert.True(array[i] <= array[i + 1]);
        }
    }

    [Theory]
    [InlineData(new[] { 10.10f, float.NaN, 0f })]
    [InlineData(new[] { 999999999999999.9f, -999999999999999.9f, 0f, float.NaN })]
    public void GivenFloatArrayWithNaN_ShouldSortNaNOnFirstPosition(float[] array)
    {
        SelectionSortHelper.Sort(array);
        Assert.True(array[0].CompareTo(float.NaN) == 0);
    }

    [Fact]
    public void GivenStringTypeArray_ShouldReturnSortedArray()
    {
        var array = new[] { "Zofia", "Adam", "Krystyna", "Wojciech", "Zenon", "Marcin" };

        SelectionSortHelper.Sort(array);

        for (var i = 0; i < array.Length - 1; i++)
        {
            Assert.True(array[i].CompareTo(array[i + 1]) <= 0);
        }
    }

    [Fact]
    public void GivenOneElementStringTypeNullArray_ShouldThrowException()
    {
        string[] array = { null };

        Assert.Throws<NullReferenceException>(() => SelectionSortHelper.Sort(array));
    }

    [Fact]
    public void GivenTwoElementStringTypArrayWithNull_ShouldThrowException()
    {
        string[] array = { string.Empty, null };

        Assert.Throws<NullReferenceException>(() => SelectionSortHelper.Sort(array));
    }

}