using System;



namespace Day02
{

    class Person
    {
        public string Name;
    }
    class Program
    {
        static void Main()
        {
            #region Problem 1
            // int x = 10; //Store x variable as integer and Initialize it to 10
            // int y = 20; //Store y variable as integer and Initialize it to 20
            // int sum = x + y; // Store the sum of x and y in the sum variable
            // Console.WriteLine(sum); //Print the sum

            // /*
            // Problem 1: Create a program that declares two integer variables,
            // initializes them with values, and prints their sum.

            // Question: What is the shortcut to comment and uncomment a selected block of code in Visual Studio?
            // Answer: Commenting : 'Ctrl + K + C' || Uncommenting : 'Ctrl + K + U'.
            // */
            #endregion

            #region Problem 2
            // int x = 10;
            // Console.WriteLine(x);

            // // Question: Explain the difference between a runtime error and a logical error with examples.

            // // Answer: A runtime error occurs during the execution of a program, causing it to crash
            // int[] numbers = { 1, 2, 3 };
            // Console.WriteLine(numbers[5]); // Runtime error: trying to access an index that does not exist

            // // A logical error is a mistake in the program's logic that produces incorrect results
            // int x = 10;
            // int y = 20;
            // int sum = x - y; // This will not crash the program, but it will give an incorrect result.
            // Console.WriteLine(sum); // Print the sum (Logical error: should be x + y)

            #endregion

            #region Problem 3
            // string FullName;
            // int Age;
            // float MonthlySalary;
            // bool IsStudent;

            // // Question: Why is it important to follow naming conventions such as PascalCase in C#?

            // // Answer: Following naming conventions like PascalCase improves code readability and maintainability.
            #endregion

            #region Problem 4
            // Person person1 = new Person();
            // person1.Name = "Ali";

            // Person person2 = person1;
            // person2.Name = "Emad";

            // Console.WriteLine(person1.Name);
            // Console.WriteLine(person2.Name);
            // // Question: Explain the difference between value types and reference types in terms of memory allocation.
            // // Answer: Value types store their data directly in memory, while reference types store a reference to the data's memory location.
            // // In this case, both person1 and person2 reference the same object in memory, so changes made through one reference are reflected in the other.
            #endregion

            #region Problem 5
            // Console.WriteLine("1) Add");
            // Console.WriteLine("2) Subtract");
            // Console.WriteLine("3) Multiply");
            // Console.WriteLine("4) Divide");
            // Console.WriteLine("5) Remainder");
            // Console.WriteLine("6) Exit");
            // Console.WriteLine("Please Choose the operation you want to perform:");
            // int choice = Convert.ToInt32(Console.ReadLine());

            // int x, y, result;
            // Console.Write("Please enter the first number:");
            // x = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Please enter the second number:");
            // y = Convert.ToInt32(Console.ReadLine());

            // switch (choice)
            // {
            //     case 1:
            //         result = x + y;
            //         Console.WriteLine($"Result: {x} + {y} = {result}");
            //         break;
            //     case 2:
            //         if (x < y)
            //         {
            //             Console.WriteLine("Warning: The first number is less than the second number.");
            //             break;
            //         }
            //         else
            //         {
            //             result = x - y;
            //             Console.WriteLine($"Result: {x} - {y} = {result}");
            //             break;
            //         }

            //     case 3:
            //         result = x * y;
            //         Console.WriteLine($"Result: {x} * {y} = {result}");
            //         break;
            //     case 4:
            //         if (y != 0)
            //         {
            //             result = x / y;
            //             Console.WriteLine($"Result: {x} / {y} = {result}");
            //         }
            //         else
            //         {
            //             Console.WriteLine("Error: Division by zero is not allowed.");
            //         }
            //         break;
            //     case 5:
            //         result = x % y;
            //         Console.WriteLine($"Result: {x} % {y} = {result}");
            //         break;
            //     case 6:
            //         Console.WriteLine("Exiting the program.");
            //         break;
            //     default:
            //         Console.WriteLine("Invalid choice. Please select a valid operation.");
            //         break;
            // }
            // // Question: What will be the output of the following code? Explain why
            // // int a = 2, b = 7;
            // // Console.WriteLine(a % b);
            // // Answer: The output will be 2, the 2 contains no 7 in it because 2 is less than 7, so the remainder is 2.
            #endregion

            #region Problem 6
            // Console.Write("Enter a number: ");
            // int number = Convert.ToInt32(Console.ReadLine());

            // if (number > 10 && number % 2 == 0)
            // {
            //     Console.WriteLine("The number is greater than 10 and even.");
            // }
            // else
            // {
            //     Console.WriteLine("The number does not meet both conditions.");
            // }

            // // Question: How does the && (logical AND) operator differ from the & (bitwise AND) operator?
            // // Answer: The && operator evaluates to true only if both conditions are true, while the & operator performs a bitwise AND operation on two numbers.
            #endregion

            #region Problem 7
            // Console.Write("Enter a double value: ");
            // double doubleValue = Convert.ToDouble(Console.ReadLine());

            // // Implicit casting (from int to double)
            // int ValueImplicit = 10;
            // double doubleImplicit = ValueImplicit;
            // Console.WriteLine($"Implicit casting (int to double): {doubleImplicit}");

            // // Explicit casting (from double to int)
            // int ValueExplicit = (int)doubleValue;
            // Console.WriteLine($"Explicit casting (double to int): {ValueExplicit}");

            // // Question: Why is explicit casting required when converting a double to an int?
            // // Answer: Explicit casting is required when converting a double to an int because a double can hold decimal values,
            // // and converting it to an int would result in the loss of the fractional part. The programmer must indicate
            // // that they are aware of this potential data loss and are intentionally making the conversion.
            #endregion

            #region Problem 8
            // Console.Write("Enter your age: ");
            // string? ageInput = Console.ReadLine();
            // int? age = int.Parse(ageInput);

            // if (age > 0 && age < 120) // Assuming a reasonable age range
            // {
            //     Console.WriteLine("Valid age entered.");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid age. Age must be greater than 0 and less than 120.");
            // }
            // // Question: What exception might occur if the input is invalid and how can you handle it
            // // Answer: If the input is invalid (non-numeric), a FormatException might occur when trying to parse the input.
            // // You can handle it using a try-catch block or a try-parse method to catch the exception and provide a meaningful error message.
            #endregion

            #region Problem 9
            // int x = 5;
            // Console.WriteLine($"Initial value of x: {x}"); // Output: 5

            // Console.WriteLine($"Prefix increment (++x): {++x}"); // x is incremented before use
            // Console.WriteLine($"Value of x after prefix increment: {x}");

            // Console.WriteLine($"Postfix increment (x++): {x++}"); // x is used before increment
            // Console.WriteLine($"Value of x after postfix increment: {x}");

            // // Question: Given the code below, what is the value of x after execution? Explain why
            // // int x = 5;
            // // int y = ++x + x++;
            // // Answer: The value of x after execution will be 7.

            // // 1. `++x` increments x to 6 and returns 6.
            // // 2. `x++` returns 6 (the current value of x) and then increments x to 7.
            // // 3. The final value of x is 7.
            // // 4. The value of y will be 12 (6 + 6).
            #endregion
        }
    }
}