using System;

class Helper
{
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) >= 0 ? a : b;
    }
}

class Helper2<T>
{
    public static int SearchArray(T[] array, T value)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(value))
                return i;
        }
        return -1;
    }

    public static void ReplaceArray(T[] array, T oldValue, T newValue)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i].Equals(oldValue))
            {
                array[i] = newValue;
            }
        }
    }
}