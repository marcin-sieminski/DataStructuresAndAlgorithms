namespace SelectionSort;

public class SelectionSort
{
    public T[] Sort<T>(T[] array) where T : IComparable
    {
        if (array[0] is null)
        {
            throw new NullReferenceException("Array contains null.");
        }
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] is null)
            {
                throw new NullReferenceException("Array contains null.");
            }
            int minIndex = i;
            T minValue = array[i];
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j].CompareTo(minValue) < 0)
                {
                    minIndex = j;
                    minValue = array[j];
                }

            }
            Swap(array, i, minIndex);
        }
        return array;
    }

    private void Swap<T>(T[] array, int first, int second) where T : IComparable
    {
        T temp = array[first];
        array[first] = array[second];
        array[second] = temp;
    }
}