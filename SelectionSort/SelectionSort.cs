namespace SelectionSort;

public class SelectionSort
{
    public T[] Sort<T>(T[] array) where T : IComparable
    {
        var sortedArray = new T[array.Length];

        if (array.Length == 1)
        {
            sortedArray = array;
        }
        
        return sortedArray;
    }
}