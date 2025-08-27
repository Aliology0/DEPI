using System;

class Utility
{
    public static T[] ReverseArray<T>(T[] array)
    {
        T[] reversedArray = new T[array.Length];
        for (int i = array.Length - 1; i >= 0; i--)
        {
            reversedArray[array.Length - i - 1] = array[i];
        }
        return reversedArray;
    }

    public static void Swap<T>(ref T[] array, int index1, int index2)
    {
        if (index1 < 0 || index1 >= array.Length || index2 < 0 || index2 >= array.Length)
        {
            throw new ArgumentOutOfRangeException("Invalid array index");
        }

        T temp = array[index1];
        array[index1] = array[index2];
        array[index2] = temp;
    }

    public static T FindMax<T>(T[] array) where T : IComparable<T>
    {
        if (array == null || array.Length == 0)
            throw new ArgumentException("Array is null or empty");

        T max = array[0];
        foreach (var item in array)
        {
            if (item.CompareTo(max) > 0)
            {
                max = item;
            }
        }
        return max;
    }
}