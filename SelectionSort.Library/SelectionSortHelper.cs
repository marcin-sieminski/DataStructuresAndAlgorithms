﻿namespace SelectionSort.Library;

public static class SelectionSortHelper
{
    public static T[] Sort<T>(T[] array) where T : IComparable
    {
        if (array[0] is null)
        {
            throw new NullReferenceException("Array contains null.");
        }
        for (var i = 0; i < array.Length - 1; i++)
        {
            if (array[i + 1] is null)
            {
                throw new NullReferenceException("Array contains null.");
            }
            var minIndex = i;
            var minValue = array[i];
            for (var j = i + 1; j < array.Length; j++)
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

    private static void Swap<T>(T[] array, int first, int second) where T : IComparable
    {
        (array[first], array[second]) = (array[second], array[first]);
    }
}