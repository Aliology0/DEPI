using System;

namespace Day_4
{
    class Program
    {
        static void Main()
        {
            #region Problem 1
            // // Array 1: new int[size]
            // int[] array1 = new int[3];
            // for (int i = 0; i < array1.Length; i++)
            //     Console.WriteLine($"array1[{i}] = {array1[i] = (i + 1) * 10}");

            // // Array 2: initializer list
            // int[] array2 = new int[] { 100, 200, 300 };
            // for (int i = 0; i < array2.Length; i++)
            //     Console.WriteLine($"array2[{i}] = {array2[i]}");

            // // Array 3: syntax sugar
            // int[] array3 = { 7, 14, 21 };
            // for (int i = 0; i < array3.Length; i++)
            //     Console.WriteLine($"array3[{i}] = {array3[i]}");

            // // IndexOutOfRangeException
            // try
            // {
            //     Console.WriteLine(array1[5]);
            // }
            // catch (IndexOutOfRangeException ex)
            // {
            //     Console.WriteLine("Exception: " + ex.Message);
            // }

            // // Question: What is the default value assigned to array elements in C#?
            // // Answer: The default value for elements in an int array is 0.
            #endregion

            #region Problem 2
            // Console.WriteLine("== Shallow Copy ==");
            // int[] arr1 = { 1, 2, 3 };
            // int[] arr2 = arr1; // Shallow copy (reference copy)

            // arr2[0] = 99; // Modify arr2

            // Console.WriteLine("arr1[0]: " + arr1[0]); // Output: 99
            // Console.WriteLine("arr2[0]: " + arr2[0]); // Output: 99

            // Console.WriteLine("\n== Deep Copy ==");
            // int[] arr3 = { 4, 5, 6 };
            // int[] arr4 = (int[])arr3.Clone(); // Deep copy

            // arr4[0] = 88; // Modify arr4

            // Console.WriteLine("arr3[0]: " + arr3[0]); // Output: 4
            // Console.WriteLine("arr4[0]: " + arr4[0]); // Output: 88

            // // Question: What is the difference between Array.Clone() and Array.Copy()?
            // // Answer: Array.Clone() creates a shallow copy of the array,
            // //         while Array.Copy() can create a deep copy if used with the appropriate parameters.
            #endregion

            #region Problem 3
            // int[,] grades = new int[3, 3];

            // // Input grades
            // for (int student = 0; student < 3; student++)
            // {
            //     Console.WriteLine($"Enter grades for Student {student + 1}:");
            //     for (int subject = 0; subject < 3; subject++)
            //     {
            //         Console.Write($"  Subject {subject + 1}: ");
            //         grades[student, subject] = int.Parse(Console.ReadLine() ?? "0");
            //     }
            // }

            // Console.WriteLine("\n== Student Grades ==");
            // // Output grades
            // for (int student = 0; student < 3; student++)
            // {
            //     Console.Write($"Student {student + 1}: ");
            //     for (int subject = 0; subject < 3; subject++)
            //     {
            //         Console.Write(grades[student, subject] + " ");
            //     }
            //     Console.WriteLine();
            // }

            // // Question: What is the difference between GetLength() and Length for multidimensional arrays?
            // // Answer: GetLength(dimension) returns the size of the specified dimension,
            // //         while Length returns the total number of elements in all dimensions.

            #endregion

            #region Problem 4
            // int[] Original = { 9, 3, 7, 1, 5 };

            // Console.WriteLine("Original array:");
            // for (int i = 0; i < Original.Length; i++)
            // {
            //     Console.Write(Original[i] + " ");
            // }
            // Console.WriteLine();

            // // 1. Sort
            // Console.WriteLine("\nApplying Array.Sort:");
            // Array.Sort(Original);
            // for (int i = 0; i < Original.Length; i++)
            // {
            //     Console.Write(Original[i] + " "); // Sorted: 1, 3, 5, 7, 9
            // }
            // Console.WriteLine();

            // // 2. Reverse
            // Console.WriteLine("\nApplying Array.Reverse:");
            // Array.Reverse(Original);
            // for (int i = 0; i < Original.Length; i++)
            // {
            //     Console.Write(Original[i] + " ");// Reversed: 9, 7, 5, 3, 1
            // }
            // Console.WriteLine();

            // // 3. IndexOf
            // Console.WriteLine("\nUsing Array.IndexOf to find 5:");
            // int index = Array.IndexOf(Original, 5);
            // Console.WriteLine($"Index of 5: {index}"); // Should be 2

            // // 4. Copy
            // Console.WriteLine("\nUsing Array.Copy to clone first 3 elements:");
            // int[] copied = new int[3];
            // Array.Copy(Original, copied, 3);
            // Console.WriteLine("Copied array:");
            // for (int i = 0; i < copied.Length; i++)
            // {
            //     Console.Write(copied[i] + " "); // Should show first 3 elements: 9, 7, 5
            // }
            // Console.WriteLine();

            // // 5. Clear
            // Console.WriteLine("\nApplying Array.Clear to clear elements at index 1 and 2:");
            // Array.Clear(Original, 1, 2);
            // for (int i = 0; i < Original.Length; i++)
            // {
            //     Console.Write(Original[i] + " "); // Elements at index 1 & 2 become 0
            // }
            // Console.WriteLine();

            // // Question: What is the difference between Array.Copy() and Array.ConstrainedCopy()?
            // // Answer: Array.Copy() allows copying elements between arrays, while Array.ConstrainedCopy()
            // //         ensures that the source and destination arrays are compatible and throws an exception if not.

            #endregion

            #region Problem 5
            // int[] Numbers = { 10, 20, 30, 40, 50 };

            // // 1. Using for loop
            // Console.WriteLine("Using for loop:");
            // for (int i = 0; i < Numbers.Length; i++)
            //     Console.WriteLine($"Element at index {i}: {Numbers[i]}");

            // // 2. Using foreach loop
            // Console.WriteLine("\nUsing foreach loop:");
            // foreach (int num in Numbers)
            //     Console.WriteLine($"Element: {num}");

            // // 3. Using while loop (reverse order)
            // Console.WriteLine("\nUsing while loop (reverse):");
            // int index = Numbers.Length - 1;
            // while (index >= 0)
            // {
            //     Console.WriteLine($"Element at index {index}: {Numbers[index]}");
            //     index--;
            // }

            // // Question: Why is foreach preferred for read-only operations on arrays?
            // // Answer: Foreach is preferred for read-only operations because it simplifies the code,
            // //         avoids index management, and is less error-prone compared to for loops.
            // //         It also provides better readability.
            #endregion

            #region Problem 6
            // int number;
            // bool isValid;

            // do
            // {
            //     Console.Write("Enter a positive odd number: ");
            //     string? input = Console.ReadLine();

            //     isValid = int.TryParse(input, out number) && number > 0 && number % 2 == 1;

            //     if (!isValid)
            //         Console.WriteLine("Invalid input. Please enter a positive odd number.");
            // }
            // while (!isValid);
            // {
            //     Console.WriteLine($"Thank you! You entered: {number}");
            // }

            // // Question: Why is input validation important when working with user inputs?
            // // Answer: Input validation is crucial to ensure that the data received from users is in the expected format,
            // //         preventing errors, security vulnerabilities, and ensuring the program behaves as intended.
            #endregion

            #region Problem 7
            // int[,] matrix =
            // {
            //     { 0, 3, -5 },
            //     { 3, 22, 6 },
            //     { 99, 6, 7 }
            // };

            // Console.WriteLine("Matrix:");

            // for (int row = 0; row < matrix.GetLength(0); row++)
            // {
            //     for (int col = 0; col < matrix.GetLength(1); col++)
            //     {
            //         Console.Write($"{matrix[row, col]}\t");
            //     }
            //     Console.WriteLine();
            // }

            // // Question: How can you format the output of a 2D array for better readability?
            // // Answer: You can format the output by aligning the columns.
            // //         In this example, we used tab characters(\t) to separate elements for better readability.
            // //         You can also use foreach to iterate through the elements.
            #endregion

            #region Problem 8
            // Console.Write("Enter a month number (1-12): ");
            // string? input = Console.ReadLine();

            // if (!int.TryParse(input, out int month) || month < 1 || month > 12)
            // {
            //     Console.WriteLine("Invalid month number.");
            //     return;
            // }

            // Console.WriteLine("\nUsing if-else:");
            // if (month == 1)
            //     Console.WriteLine("January");
            // else if (month == 2)
            //     Console.WriteLine("February");
            // else if (month == 3)
            //     Console.WriteLine("March");
            // else if (month == 4)
            //     Console.WriteLine("April");
            // else if (month == 5)
            //     Console.WriteLine("May");
            // else if (month == 6)
            //     Console.WriteLine("June");
            // else if (month == 7)
            //     Console.WriteLine("July");
            // else if (month == 8)
            //     Console.WriteLine("August");
            // else if (month == 9)
            //     Console.WriteLine("September");
            // else if (month == 10)
            //     Console.WriteLine("October");
            // else if (month == 11)
            //     Console.WriteLine("November");
            // else
            //     Console.WriteLine("December");

            // Console.WriteLine("\nUsing switch:");
            // switch (month)
            // {
            //     case 1: Console.WriteLine("January"); break;
            //     case 2: Console.WriteLine("February"); break;
            //     case 3: Console.WriteLine("March"); break;
            //     case 4: Console.WriteLine("April"); break;
            //     case 5: Console.WriteLine("May"); break;
            //     case 6: Console.WriteLine("June"); break;
            //     case 7: Console.WriteLine("July"); break;
            //     case 8: Console.WriteLine("August"); break;
            //     case 9: Console.WriteLine("September"); break;
            //     case 10: Console.WriteLine("October"); break;
            //     case 11: Console.WriteLine("November"); break;
            //     case 12: Console.WriteLine("December"); break;
            // }

            // // Question: When should you prefer a switch statement over if-else?
            // // Answer: You should prefer a switch statement over if-else when you have multiple discrete values to check against a single variable.
            // //         Switch statements are more readable and can be more efficient for many cases.
            #endregion

            #region Problem 9
            // int[] Numbers = { 5, 2, 8, 2, 9, 3, 8, 1 };

            // Console.WriteLine("Original array:");
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     Console.Write(Numbers[i] + " ");
            // }

            // // Sort the array
            // Array.Sort(Numbers);

            // Console.WriteLine("\nSorted array:");
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     Console.Write(Numbers[i] + " ");
            // }

            // // Ask the user for a value to search
            // Console.Write("\nEnter a number to search for: ");
            // string? input = Console.ReadLine();

            // if (int.TryParse(input, out int target))
            // {
            //     int firstIndex = Array.IndexOf(Numbers, target);
            //     int lastIndex = Array.LastIndexOf(Numbers, target);

            //     if (firstIndex >= 0)
            //     {
            //         Console.WriteLine($"\nFirst occurrence of {target} is at index: {firstIndex}");
            //         Console.WriteLine($"Last occurrence of {target} is at index: {lastIndex}");
            //     }
            //     else
            //     {
            //         Console.WriteLine($"\n{target} not found in the array.");
            //     }
            // }
            // else
            // {
            //     Console.WriteLine("Invalid number.");
            // }

            // // Question: What is the time complexity of Array.Sort()?
            // // Answer: The time complexity of Array.Sort() is O(n log n) on average.
            // //         Because it uses a hybrid sorting algorithm (Introsort) that combines quicksort, heapsort, and insertion sort.
            #endregion

            #region Problem 10
            // int[] numbers = { 5, 10, 15, 20, 25 };

            // // Sum using for loop
            // int sumFor = 0;
            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     sumFor += numbers[i];
            // }
            // Console.WriteLine($"Sum using for loop: {sumFor}");

            // // Sum using foreach loop
            // int sumForeach = 0;
            // foreach (int num in numbers)
            // {
            //     sumForeach += num;
            // }
            // Console.WriteLine($"Sum using foreach loop: {sumForeach}");

            // // Question: Which loop (for or foreach) is more efficient for calculating the sum of an array, and why?

            // // Answer: In most cases, foreach and for loops are equally efficient for calculating the sum of a simple array.
            // //         But the foreach loop is generally more efficient for calculating the sum of an array because it avoids the overhead of managing an index variable.
            // //         It is also more readable and less error-prone, especially for simple operations like summing elements.
            // //         However, for large arrays or performance-critical applications, the for loop may be preferred.
            #endregion

            #region enum Problem (Part 02)
            // Console.Write("Enter a number (1-7) for the day of the week: ");
            // if (int.TryParse(Console.ReadLine(), out int dayNum) && dayNum is >= 1 and <= 7)
            // {
            //     Console.WriteLine($"Day {dayNum} is {(DayOfWeek)dayNum}");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid input. Please enter a number between 1 and 7.");
            // }

            // // 3- What happens if the user enters a value outside the range of 1 to 7?
            // // Answer: In my code, this case is already handled using an if-check with int.TryParse,
            // //         so if the user enters a number less than 1 or greater than 7, they will see
            // //         an "Invalid input" message, and the program will not proceed to parse it.
            // //
            // //         However, if we skip this validation and try to cast any integer (like 0 or 8)
            // //         to the enum using Enum.Parse or direct casting, no exception will be thrown.
            // //         Instead, it will produce a value that's not defined in the enum — essentially,
            // //         a "valid" enum object holding an undefined value, which could lead to confusion.
            #endregion
        }
        enum DayOfWeek
        {
            Saturday = 1,
            Sunday = 2,
            Monday = 3,
            Tuesday = 4,
            Wednesday = 5,
            Thursday = 6,
            Friday = 7
        }
    }
}