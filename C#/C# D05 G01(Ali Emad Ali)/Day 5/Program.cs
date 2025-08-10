using System;

namespace Day_5
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Part 01

            #region Problem 1
            // try
            // {
            //     Console.Write("Enter the first integer: ");
            //     int Num1 = Convert.ToInt32(Console.ReadLine());

            //     Console.Write("Enter the second integer: ");
            //     int Num2 = Convert.ToInt32(Console.ReadLine());

            //     int result = Num1 / Num2;
            //     Console.WriteLine("Result: " + result);
            // }
            // catch (DivideByZeroException)
            // {
            //     Console.WriteLine("Error: Cannot divide by zero.");
            // }
            // finally
            // {
            //     Console.WriteLine("Operation complete");
            // }

            // // Question: What is the purpose of the finally block?
            // // Answer: The finally block is used to execute code after the try and catch blocks,
            // //         regardless of whether an exception was thrown or not. 
            // //         It is typically used for cleanup code, such as closing files or releasing resources.
            #endregion

            #region Problem 2
            // static void TestDefensiveCode()
            // {
            //     int X, Y, Z;
            //     do
            //         Console.WriteLine("Enter First Number");
            //     while (!int.TryParse(Console.ReadLine(), out X) || X < 0);
            //     do
            //         Console.WriteLine("Enter Second Number");
            //     while (!int.TryParse(Console.ReadLine(), out Y) || Y <= 1);
            //     Y = int.Parse(Console.ReadLine());
            //     Z = X / Y;
            // }

            // // Question: How does int.TryParse() improve program robustness compared to int.Parse()?
            // // Answer: int.TryParse() improves robustness by not throwing an exception for invalid input.
            // //         Instead, it returns false, allowing the program to handle the error gracefully.
            #endregion

            #region Problem 3

            // int? x = null;
            // int y = x ?? 10;
            // Console.WriteLine($"Value of y (using ??): {y}");

            // // HasValue
            // if (x.HasValue)
            // {
            //     Console.WriteLine($"x has value: {x.Value}");
            // }
            // else
            // {
            //     Console.WriteLine("x is null (HasValue is false)");
            // }

            // x = 5;
            // if (x.HasValue)
            // {
            //     Console.WriteLine($"x has value: {x.Value}");
            // }
            // else
            // {
            //     Console.WriteLine("x is still null (HasValue is false)");
            // }

            // // Question: What exception occurs when trying to access Value on a null Nullable<T>?
            // // Answer: Accessing the Value property on a null Nullable<T> will throw an InvalidOperationException.

            #endregion

            #region Problem 4
            // int[] arr = { 1, 2, 3, 4, 5 };

            // try
            // {
            //     Console.WriteLine(arr[20]);
            // }
            // catch (IndexOutOfRangeException)
            // {
            //     Console.WriteLine("Error: Index is out of range.");
            // }
            // finally
            // {
            //     Console.WriteLine("Array access attempt complete.");
            // }

            // // Question: Why is it necessary to check array bounds before accessing elements?
            // // Answer: It is necessary to check array bounds to prevent runtime errors and
            // //         ensure that the program does not attempt to access memory outside the allocated array space.

            #endregion

            #region Problem 5

            // int[,] matrix =
            // {
            //     {10 , 20 , 30 },
            //     {40 , 50 , 60 },
            //     {70 , 80 , 90 }
            // };

            // // for (int row = 0; row < 3; row++)
            // // {
            // //     for (int col = 0; col < 3; col++)
            // //     {
            // //         try
            // //         {
            // //             Console.Write($"Enter value for matrix[{row},{col}]: ");
            // //             matrix[row, col] = Convert.ToInt32(Console.ReadLine());
            // //         }
            // //         catch (FormatException)
            // //         {
            // //             Console.WriteLine("Invalid input. Please enter an integer.");
            // //             col--;
            // //         }
            // //     }
            // // }

            // for (int row = 0; row < matrix.GetLength(0); row++)
            // {
            //     int RowSum = 0, ColSum = 0;
            //     for (int col = 0; col < matrix.GetLength(1); col++)
            //     {
            //         RowSum += matrix[row, col];
            //         ColSum += matrix[col, row];
            //     }
            //     Console.WriteLine($"Sum of elements in row {row}: {RowSum}");
            //     Console.WriteLine($"Sum of elements in column {row}: {ColSum}");
            // }

            // // Question: How is the GetLength(dimension) method used in multi-dimensional arrays?
            // // Answer: The GetLength(dimension) method is used to obtain the size of a specific dimension in a multi-dimensional array.
            // //         matrix.GetLength(0) returns the Number of rows, and matrix.GetLength(1) returns the Number of columns as I used them in the code above.

            #endregion

            #region Problem 6
            // int RowOneSize, RowTwoSize, RowThreeSize;
            // while (true)
            // {
            //     Console.Write("Enter size for Row 1: ");
            //     if (int.TryParse(Console.ReadLine(), out RowOneSize) && RowOneSize > 0)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a positive integer.");
            // }

            // while (true)
            // {
            //     Console.Write("Enter size for Row 2: ");
            //     if (int.TryParse(Console.ReadLine(), out RowTwoSize) && RowTwoSize > 0)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a positive integer.");
            // }

            // while (true)
            // {
            //     Console.Write("Enter size for Row 3: ");
            //     if (int.TryParse(Console.ReadLine(), out RowThreeSize) && RowThreeSize > 0)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a positive integer.");
            // }

            // int[][] jaggedArray = new int[3][];
            // jaggedArray[0] = new int[RowOneSize];
            // jaggedArray[1] = new int[RowTwoSize];
            // jaggedArray[2] = new int[RowThreeSize];

            // for (int i = 0; i < jaggedArray.Length; i++)
            // {
            //     for (int j = 0; j < jaggedArray[i].Length; j++)
            //     {
            //         Console.Write($"Enter value for jaggedArray[{i}][{j}]: ");
            //         if (int.TryParse(Console.ReadLine(), out int value))
            //         {
            //             jaggedArray[i][j] = value;
            //         }
            //         else
            //         {
            //             Console.WriteLine("Invalid input. Please enter an integer.");
            //             j--;
            //         }
            //     }
            // }

            // foreach (var row in jaggedArray)
            // {
            //     foreach (var item in row)
            //     {
            //         Console.Write(item + " ");
            //     }
            //     Console.WriteLine();
            // }

            // // Question: How does the memory allocation differ between jagged arrays and rectangular arrays?
            // // Answer: In jagged arrays, each row can have a different Number of elements, and the rows are essentially arrays themselves.
            // //         This means that the memory allocation for each row is done separately, allowing for more flexibility.
            // //         In contrast, rectangular arrays have a fixed Number of rows and columns, and the memory is allocated in a contiguous block.
            #endregion

            #region Problem 7
            // string? UserInput = null;

            // // Console.Write("Please enter text: ");
            // // UserInput = Console.ReadLine();

            // Console.WriteLine($"You entered: {UserInput!.Length}");

            // // Question: What is the purpose of nullable reference types in C#?
            // // Answer: Nullable reference types in C# are used to indicate that a reference type variable can hold a null value.
            // //         This helps developers to avoid null reference exceptions by making it explicit when a variable can be null.
            #endregion

            #region Problem 8
            // try
            // {
            //     // Boxing
            //     int Number = 42;
            //     object BoxedNumber = Number;
            //     Console.WriteLine($"Boxed Value: {BoxedNumber}");

            //     // Unboxing
            //     double DoubleNumber = 321.144241;
            //     int UnboxedNumber = (int)DoubleNumber;
            //     Console.WriteLine($"Unboxed Value: {UnboxedNumber}");

            //     // (will throw InvalidCastException)
            //     object Str = "Hello";
            //     int InvalidUnbox = (int)Str; // 💥 This will fail
            //     Console.WriteLine($"Invalid Unbox Result: {InvalidUnbox}");
            // }
            // catch (InvalidCastException Exception)
            // {
            //     Console.WriteLine($"Error: {Exception.Message}");
            // }

            // // Question: What is the performance impact of boxing and unboxing in C#?
            // // Answer: Boxing and unboxing can have a significant performance impact in C#.
            // //         Boxing involves allocating memory on the heap for the value type,
            // //         while unboxing requires a type check and a potential copy of the value.
            // //         This can lead to increased memory usage and slower performance,
            // //         especially in scenarios with frequent boxing/unboxing operations.

            #endregion

            #region Problem 9
            // static void SumAndMultiply(int Num1, int Num2, out int Sum, out int Product)
            // {
            //     Sum = Num1 + Num2;
            //     Product = Num1 * Num2;
            // }

            // Console.Write("Enter First Integer: ");
            // int First = Convert.ToInt32(Console.ReadLine());

            // Console.Write("Enter Second Integer: ");
            // int Second = Convert.ToInt32(Console.ReadLine());

            // int SumResult, ProductResult;

            // SumAndMultiply(First, Second, out SumResult, out ProductResult);

            // // Print results
            // Console.WriteLine($"Sum: {SumResult}");
            // Console.WriteLine($"Product: {ProductResult}");

            // // Question: Why must out parameters be initialized inside the method?
            // // Answer: Out parameters must be initialized inside the method because they are intended to be used as output parameters.
            // //         The caller expects these parameters to have valid values after the method call,
            // //         and failing to initialize them could lead to undefined behavior.

            #endregion

            #region Problem 10

            // static void PrintMultipleTimes(string Message, int Count = 5)
            // {
            //     for (int i = 0; i < Count; i++)
            //     {
            //         Console.WriteLine(Message);
            //     }
            // }

            // // Named parameters example (Mixed Positions)
            // PrintMultipleTimes(Count: 10, Message: "Ali Emad");

            // Console.WriteLine();

            // // Using default value for Count
            // PrintMultipleTimes(Message: "Default Count Example");

            // // Question: Why must optional parameters always appear at the end of a method's parameter list?
            // // Answer: Optional parameters must appear at the end of a method's parameter list because the compiler needs to know which arguments are being passed.
            // //         If optional parameters were allowed at the beginning or middle, it would create ambiguity in method calls.
            #endregion

            #region Problem 11

            // int[]? Numbers = null;

            // Console.WriteLine($"Array length: {Numbers?.Length}");

            // Numbers = new int[] { 50, 20, 30 };

            // Console.WriteLine($"Array length: {Numbers?.Length}");

            // // Using null propagation with indexing
            // Console.WriteLine($"First element: {Numbers?[0]}");

            // // Question: How does the null propagation operator prevent NullReferenceException?
            // // Answer: The null propagation operator (?.) prevents NullReferenceException by returning null
            // //         instead of throwing an exception when trying to access a member of a null object.
            // //         This allows for safer code when dealing with potentially null references.
            #endregion

            #region Problem 12
            // int Day;

            // while (true)
            // {
            //     Console.Write("Enter a day of the week (1-7): ");
            //     if (int.TryParse(Console.ReadLine(), out Day) && Day >= 1 && Day <= 7)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a Number between 1 and 7.");
            // }

            // switch (Day)
            // {
            //     case 1: Console.WriteLine("Monday"); break;
            //     case 2: Console.WriteLine("Tuesday"); break;
            //     case 3: Console.WriteLine("Wednesday"); break;
            //     case 4: Console.WriteLine("Thursday"); break;
            //     case 5: Console.WriteLine("Friday"); break;
            //     case 6: Console.WriteLine("Saturday"); break;
            //     case 7: Console.WriteLine("Sunday"); break;
            // }

            // // Question: When is a switch expression preferred over a traditional if statement?
            // // Answer: You should prefer a switch statement over if-else when you have multiple discrete values to check against a single variable.
            // //         Switch statements are more readable and can be more efficient for many cases.

            #endregion

            #region Problem 13

            // static int SumArray(params int[] Numbers)
            // {
            //     int Sum = 0;
            //     foreach (int Num in Numbers)
            //     {
            //         Sum += Num;
            //     }
            //     return Sum;
            // }


            // // Calling with individual values
            // int g3bs = 18;
            // int x = 24;
            // int y = 30;
            // int z = 36;
            // int h = 42;
            // int Result1 = SumArray(g3bs, x, y, z, h);
            // Console.WriteLine($"Sum (Individual Values): {Result1}");

            // // Calling with an array
            // int[] Nums = { 10, 20, 30 };
            // int Result2 = SumArray(Nums);
            // Console.WriteLine($"Sum (Array): {Result2}");

            // // Question: What are the limitations of the params keyword in method definitions?
            // // Answer: The params keyword allows a method to accept a variable number of arguments,
            // //         but it must be the last parameter in the method signature. Additionally,
            // //         you can only use one params keyword in a method.

            #endregion

            #endregion

            #region Part 02

            #region Program to Print Numbers in a Range
            // int UserInput;
            // while (true)
            // {
            //     Console.Write("Enter a Number: ");
            //     if (int.TryParse(Console.ReadLine(), out UserInput) && UserInput > 1)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a Number greater than 1.");
            // }
            // for (int i = 1; i <= UserInput; i++)
            // {
            //     Console.Write($"{i} ");
            // }

            #endregion

            #region Program to Display Multiplication Table
            // int UserInput;
            // while (true)
            // {
            //     Console.Write("Enter a Number: ");
            //     if (int.TryParse(Console.ReadLine(), out UserInput))
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Number.");
            // }
            // for (int i = 0; i < 12; i++)
            // {
            //     Console.Write($"{UserInput * (i + 1)} ");
            // }
            #endregion

            #region Program to List Even Numbers
            // int UserInput;
            // while (true)
            // {
            //     Console.Write("Enter a Number: ");
            //     if (int.TryParse(Console.ReadLine(), out UserInput))
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Number.");
            // }
            // for (int i = 1; i <= UserInput; i++)
            // {
            //     if (i % 2 == 0)
            //         Console.Write($"{i} ");
            // }
            #endregion

            #region Program to Compute Exponentiation
            // int Num1 = 0, Num2 = 0;
            // while (true)
            // {
            //     Console.Write("Enter a Number 1: ");
            //     if (int.TryParse(Console.ReadLine(), out Num1) && Num1 > 0)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Number.");
            // }
            // while (true)
            // {
            //     Console.Write("Enter a Number 2: ");
            //     if (int.TryParse(Console.ReadLine(), out Num2) && Num2 > 0)
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Number.");
            // }
            // int Result = 1;
            // for (int i = 1; i <= Num2; i++)
            // {
            //     Result *= Num1;
            // }
            // Console.WriteLine($"{Num1} Power {Num2} = {Result}");

            #endregion

            #region Program to Reverse a Text String

            // string Str;

            // while (true)
            // {
            //     Console.Write("Enter a Text String: ");
            //     Str = Console.ReadLine();
            //     if (!string.IsNullOrWhiteSpace(Str))
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Text String.");
            // }
            // for (int i = Str.Length - 1; i >= 0; i--)
            // {
            //     Console.Write(Str[i]);
            // }
            // Console.WriteLine();

            #endregion

            #region Program to Reverse an Integer Value

            // string Str;
            // int Integers = 0;

            // while (true)
            // {
            //     Console.Write("Enter an Integer: ");
            //     if (int.TryParse(Console.ReadLine(), out Integers))
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Integer.");
            // }
            // Str = Integers.ToString();
            // for (int i = Str.Length - 1; i >= 0; i--)
            // {
            //     Console.Write(Str[i]);
            // }
            // Console.WriteLine();

            #endregion

            #region Program to Find Longest Distance Between Matching Elements
            // int[] Numbers = { 1, 2, 3, 4, 5, 1, 2, 3, 4, 5 };
            // int MaxDistance = 0, element = Numbers[0];
            // for (int i = 0; i < Numbers.Length; i++)
            // {
            //     for (int j = i + 1; j < Numbers.Length; j++)
            //     {
            //         if (Numbers[i] == Numbers[j])
            //         {
            //             int Distance = j - i - 1;
            //             if (Distance > MaxDistance)
            //             {
            //                 MaxDistance = Distance;
            //                 element = Numbers[i];
            //             }

            //         }
            //     }
            // }
            // Console.WriteLine($"Longest Distance Between Matching Element({element}) is {MaxDistance} elements.");
            #endregion

            #region Program to Reverse Words in a Sentence
            // string Str;
            // while (true)
            // {
            //     Console.Write("Enter a Sentence: ");
            //     Str = Console.ReadLine();
            //     if (!string.IsNullOrWhiteSpace(Str))
            //         break;
            //     Console.WriteLine("Invalid input. Please enter a valid Sentence.");
            // }
            // string[] Words = Str.Split(' ');
            // Array.Reverse(Words);
            // foreach (string Word in Words)
            // {
            //     Console.Write(Word + " ");
            // }
            // Console.WriteLine();
            #endregion

            #endregion
        }
    }
}