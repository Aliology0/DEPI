using System;

namespace Part_2
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1: Generic Method for Reversing an Array
            // int[] nums = { 1, 2, 3, 4, 5 };
            // var reversedNums = Utility.ReverseArray(nums);
            // Console.WriteLine("Reversed array: " + string.Join(", ", reversedNums));

            // string[] words = { "apple", "banana", "cherry", "date" };
            // var reversedWords = Utility.ReverseArray(words);
            // Console.WriteLine("Reversed words: " + string.Join(", ", reversedWords));
            #endregion

            #region Problem 2: Generic Class for a Stack
            // Stack<char> stack = new Stack<char>(5);
            // stack.Push('A');
            // stack.Push('B');
            // stack.Push('C');
            // Console.WriteLine($"Peek: {stack.Peek()}"); // C
            // Console.WriteLine($"Pop: {stack.Pop()}");   // C
            // Console.WriteLine($"Pop: {stack.Pop()}");   // B
            // Console.WriteLine($"Peek: {stack.Peek()}"); // A
            #endregion

            #region Problem 3: Generic Method for Swapping Elements
            // int[] arr = { 10, 20, 30, 40 };
            // Console.WriteLine("\nBefore Swap: ");
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i] + " ");
            // }

            // Utility.Swap(ref arr, 1, 3);

            // Console.WriteLine("\nAfter Swap: ");
            // for (int i = 0; i < arr.Length; i++)
            // {
            //     Console.Write(arr[i] + " ");
            // }
            #endregion

            #region Problem 4: Generic Method for Finding Maximum Element
            // double[] values = { 2.54, 7.12, 3.35, 9.83, 4.21 };
            // double maxVal = Utility.FindMax(values);
            // Console.WriteLine("\nMaximum Value: " + maxVal);
            #endregion
        }
    }
}
