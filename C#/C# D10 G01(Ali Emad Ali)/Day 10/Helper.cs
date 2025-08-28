using System;
using System.ComponentModel;

public static class Helper
{

    public delegate bool CompareDelegate<T>(T a, T b);
    public static void SortASC<T>(ref T[] array, Func<T, T, int> compare) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare(array[j], array[j + 1]) < 0)
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
    public static void SortDESC<T>(ref T[] array, Func<T, T, int> compare) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare(array[j], array[j + 1]) > 0)
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }
    public static void SortASC<T>(ref T[] array, CompareDelegate<T> compare) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }


    }
    public static void SortDESC<T>(ref T[] array, CompareDelegate<T> compare) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare(array[j], array[j + 1]))
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    public static void Swap<T>(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }

    public static T GetDefault<T>()
    {
        return default;
    }
}


class CloneableHelper
{
    public static void CloneableSort<T>(ref T[] array, Func<T, T, int> compare) where T : IComparable<T>
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - i - 1; j++)
            {
                if (compare(array[j], array[j + 1]) < 0)
                {
                    T Temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = Temp;
                }
            }
        }
    }

    public static T[] CloneArray<T>(ref T[] array) where T : ICloneable
    {
        T[] clonedArray = new T[array.Length];
        for (int i = 0; i < array.Length; i++)
        {
            clonedArray[i] = (T)array[i].Clone();
        }
        return clonedArray;
    }
}
