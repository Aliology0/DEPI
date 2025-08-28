using System;
using System.Collections.Generic;
using System.Linq;

namespace Day_10
{

    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            // Employee[] employees = new Employee[]
            // {
            //     new Employee("Ali", 5000),
            //     new Employee("Abeer", 8000),
            //     new Employee("Ahmed", 2000),
            //     new Employee("Omar", 7000),
            //     new Employee("Abdelrahman", 3000),
            //     new Employee("Manar", 4000),
            //     new Employee("Nadia", 10000)
            // };

            // Console.WriteLine("Before Sorting:");
            // for (int i = 0; i < employees.Length; i++)
            // {
            //     Console.WriteLine(employees[i]);
            // }

            // Console.WriteLine();
            // Helper.SortASC<Employee>(ref employees, (a, b) => b.CompareTo(a));

            // Console.WriteLine("After Sorting:");
            // for (int i = 0; i < employees.Length; i++)
            // {
            //     Console.WriteLine(employees[i]);
            // }

            // // Question: What are the benefits of using a generic sorting algorithm over a non-generic one?
            // // Answer: The benefit of using a generic sorting algorithm is that it can work 
            // //         with any data type that implements IComparable<T>, not just a single type.
            // //         This avoids code duplication, improves reusability, and provides type safety 
            // //         compared to non-generic algorithms that rely on casting or object.

            #endregion

            #region Problem 2
            // int[] numbers = { 5, 2, 9, 1, 7 };

            // Console.WriteLine("Before Sorting:");
            // Console.WriteLine(string.Join(", ", numbers));

            // Helper.SortDESC<int>(ref numbers, (a, b) => b.CompareTo(a));

            // Console.WriteLine("\nAfter Sorting (Descending):");
            // Console.WriteLine(string.Join(", ", numbers));

            // // Question: How do lambda expressions improve the readability and flexibility of sorting methods?
            // // Answer: Lambda expressions allow us to define custom sorting logic inline, 
            // //         making the code more concise and easier to read. They remove the 
            // //         need to create separate comparison classes or methods, and allow 
            // //         developers to quickly change sorting criteria (e.g., ascending, 
            // //         descending, by property) without rewriting the sort method itself.
            #endregion

            #region Problem 3
            // string[] Words = { "apple", "kiwi", "banana", "pear", "grape" };

            // Console.WriteLine("Before Sorting:");
            // Console.WriteLine(string.Join(", ", Words));

            // Helper.SortASC<string>(ref Words, (a, b) => b.Length.CompareTo(a.Length));

            // Console.WriteLine("\nAfter Sorting (By Length Ascending):");
            // Console.WriteLine(string.Join(", ", Words));

            // // Question: Why is it important to use a dynamic comparer function when sorting objects of various data types?
            // // Answer: A dynamic comparer function allows sorting logic to be customized 
            // //         for different data types or properties without rewriting the sorting algorithm. 
            // //         This provides flexibility, reusability, and type safety — making it possible 
            // //         to sort by different criteria (e.g., numeric value, string length, object property) 
            // //         with the same generic method.
            #endregion

            #region Problem 4
            // Manager[] managers =
            // {
            //     new Manager("Ali", 9000),
            //     new Manager("Mona", 12000),
            //     new Manager("Khaled", 7500),
            //     new Manager("Sara", 15000)
            // };

            // Console.WriteLine("Before Sorting:");
            // for (int i = 0; i < managers.Length; i++)
            //     Console.WriteLine(managers[i]);

            // Helper.SortASC<Manager>(ref managers, (a, b) => b.CompareTo(a));

            // Console.WriteLine("\nAfter Sorting (By Salary Ascending):");
            // for (int i = 0; i < managers.Length; i++)
            //     Console.WriteLine(managers[i]);

            // // Question: How does implementing IComparable<T> in derived classes enable custom sorting?
            // // Answer: By implementing IComparable<T> in a derived class, we define a specific comparison rule 
            // //         for objects of that class (e.g., Managers by Salary). This enables generic sorting 
            // //         algorithms to work directly on the derived class without extra comparers, providing 
            // //         flexibility and encapsulating sorting logic within the class itself.
            #endregion

            #region Problem 5
            // Employee[] employees = new Employee[]
            // {
            //     new Employee("Ali", 5000),
            //     new Employee("Abeer", 8000),
            //     new Employee("Ahmed", 2000),
            //     new Employee("Omar", 7000),
            //     new Employee("Abdelrahman", 3000),
            //     new Employee("Manar", 4000),
            //     new Employee("Nadia", 10000)
            // };

            // Helper.CompareDelegate<Employee> comparerASC = (a, b) => a.Name.Length > b.Name.Length;
            // Helper.CompareDelegate<Employee> comparerDESC = (a, b) => a.Name.Length < b.Name.Length;

            // Console.WriteLine("Original Array:");
            // foreach (var emp in employees)
            //     Console.WriteLine(emp);

            // // Sort ascending
            // Helper.SortASC(ref employees, comparerASC);
            // Console.WriteLine("\nSorted ASC:");
            // foreach (var emp in employees)
            //     Console.WriteLine(emp);

            // // Sort descending
            // Helper.SortDESC(ref employees, comparerDESC);
            // Console.WriteLine("\nSorted DESC:");
            // foreach (var emp in employees)
            //     Console.WriteLine(emp);

            // // Question: What is the advantage of using built-in delegates like Func<T, T, TResult> in generic programming?
            // // Answer: Built-in delegates like Func<T, T, TResult> eliminate the need to define custom delegate types.
            // //         They make code shorter, reusable, and flexible by allowing developers to pass existing methods 
            // //         or lambdas without creating extra delegate definitions.
            #endregion

            #region Problem 6
            // int[] numbers = { 5, 2, 9, 1, 7, 4, 22, 38, 15, 10 };

            // Console.WriteLine("Original Array:");
            // foreach (var num in numbers)
            //     Console.Write(num + " ");

            // // --- Using Anonymous Function ---
            // Helper.SortASC(ref numbers, delegate (int a, int b)
            // {
            //     return a.CompareTo(b);
            // });

            // Console.WriteLine("\nSorted ASC (Anonymous Function):");
            // foreach (var num in numbers)
            //     Console.Write(num + " ");

            // // Reset array
            // numbers = new int[] { 5, 2, 9, 1, 7, 4, 22, 38, 15, 10 };

            // // --- Using Lambda Expression ---
            // Helper.SortASC(ref numbers, (a, b) => a.CompareTo(b));

            // Console.WriteLine("\nSorted ASC (Lambda Expression):");
            // foreach (var num in numbers)
            //     Console.Write(num + " ");

            // Console.WriteLine();

            // // Question: How does the usage of anonymous functions differ from lambda expressions in terms of readability and efficiency?

            // // Answer: Anonymous functions let us define inline methods without names,
            // //         but they are more verbose. Lambda expressions are more concise and
            // //         improve readability while achieving the same functionality.
            // //         Both compile to delegates, so performance is the same, but lambdas
            // //         are cleaner and more maintainable.
            #endregion

            #region Problem 7
            // int[] numbers = { 10, 20, 30, 40 };

            // Console.WriteLine("Original Array:");
            // foreach (var num in numbers)
            //     Console.Write(num + " ");

            // Helper.Swap(ref numbers[0], ref numbers[3]);

            // Console.WriteLine("\nAfter Swapping first and last:");
            // foreach (var num in numbers)
            //     Console.Write(num + " ");

            // // Question: Why is the use of generic methods beneficial when creating utility functions like Swap?
            // // Answer: Generic methods like Swap<T> are beneficial because they work with any data type
            // //         without rewriting the same logic for each type. This improves reusability,
            // //         reduces code duplication, and ensures type safety by avoiding casting.
            #endregion

            #region Problem 8
            // Employee[] employees =
            // {
            //     new Employee("Ali", 5000),
            //     new Employee("Abdullah", 7000),
            //     new Employee("Abeer", 5000),
            //     new Employee("Mona", 9000)
            // };

            // Helper.SortASC<Employee>(ref employees, (a, b) =>
            // {
            //     int salaryComparison = b.Salary.CompareTo(a.Salary);
            //     if (salaryComparison == 0)
            //     {
            //         return a.Name.CompareTo(b.Name);
            //     }
            //     return salaryComparison;
            // });

            // Console.WriteLine("Sorted Employees (ASC):");
            // foreach (var emp in employees)
            // {
            //     Console.WriteLine(emp);
            // }

            // // Question: What are the challenges and benefits of implementing multi-criteria sorting logic in generic methods?

            // // Answer: The challenge is handling complex comparison logic cleanly, ensuring tie-breakers 
            // //         are applied consistently, and avoiding verbose code. 
            // //         The benefit is that multi-criteria sorting makes algorithms more flexible and reusable 
            // //         across different object types, allowing developers to define custom priorities 
            // //         (like Salary then Name) without rewriting the sorting algorithm itself.
            #endregion

            #region Problem 9
            // int Int = Helper.GetDefault<int>();        // value type
            // string String = Helper.GetDefault<string>(); // reference type
            // bool Bool = Helper.GetDefault<bool>();     // value type
            // object Object = Helper.GetDefault<object>(); // reference type

            // Console.WriteLine($"Default int: {Int}");                 // 0
            // Console.WriteLine($"Default string: {String == null}");   // True
            // Console.WriteLine($"Default bool: {Bool}");               // False
            // Console.WriteLine($"Default object: {Object == null}");   // True

            // // Question: Why is the default(T) keyword crucial in generic programming, and how does it handle value and reference types differently?

            // // Answer:   The default(T) keyword is crucial because in generic code, we don’t know 
            // //           whether T will be a value type or a reference type.
            // //           - For value types: default(T) returns their zero-equivalent (0 for int, false for bool, etc.).
            // //           - For reference types: default(T) returns null.
            // //           This ensures that generic methods and classes can safely initialize variables 
            // //           of any type without knowing the actual type at compile time.
            #endregion

            #region Problem 10
            // Employee[] employees =
            // {
            //     new Employee("Ali", 5000),
            //     new Employee("Abeer", 3000),
            //     new Employee("Hana", 7000)
            // };

            // Console.WriteLine("Original Employees:");
            // foreach (var emp in employees)
            //     Console.WriteLine(emp);

            // // Clone before sorting
            // Employee[] clonedEmployees = CloneableHelper.CloneArray(ref employees);

            // Helper.SortASC(ref employees, (a, b) =>
            // {
            //     int salaryComparison = b.Salary.CompareTo(a.Salary);
            //     if (salaryComparison == 0)
            //     {
            //         return a.Name.CompareTo(b.Name);
            //     }
            //     return salaryComparison;
            // });

            // Console.WriteLine("\nCloned & Sorted Employees:");
            // foreach (var emp in clonedEmployees)
            //     Console.WriteLine(emp);

            // Console.WriteLine("\nOriginal Employees remain unchanged:");
            // foreach (var emp in employees)
            //     Console.WriteLine(emp);

            // // Question: How do constraints in generic programming ensure type safety and improve the reliability of generic methods?

            // // Answer:   Constraints ensure that only types meeting specific requirements 
            // //           (like ICloneable or IComparable<T>) can be used with the generic class or method.  
            // //           This provides compile-time safety, avoids runtime errors, and guarantees that 
            // //           required functionality (like cloning or comparison) is always available.  
            // //           As a result, generic methods become more reliable, reusable, and easier to maintain.
            #endregion

            #region Problem 11
            // List<string> names = new List<string> { "Ali", "Abeer", "Hana" };

            // Console.WriteLine("Original List:");
            // names.ForEach(Console.WriteLine);

            // // Convert to uppercase
            // var upperCaseList = TransformList(names, s => new string(s.ToUpper().ToArray()));
            // Console.WriteLine("\nUppercase:");
            // upperCaseList.ForEach(Console.WriteLine);

            // // Reverse the strings
            // var reversedList = TransformList(names, s => new string(s.Reverse().ToArray()));
            // Console.WriteLine("\nReversed:");
            // reversedList.ForEach(Console.WriteLine);

            // // Question: What are the benefits of using delegates for string transformations in a functional programming style?

            // // Answer:   Delegates allow developers to pass transformation logic as parameters, 
            // //           making the code more flexible and reusable. 
            // //           This supports a functional programming style by treating functions as "first-class citizens," 
            // //           enabling cleaner separation of concerns, easier testing, and the ability to 
            // //           quickly swap or combine different transformations without modifying the core logic.
            #endregion

            #region Problem 12 & 18
            // // Using anonymous methods
            // MathOperation Add = delegate (int a, int b) { return a + b; };
            // MathOperation Subtract = delegate (int a, int b) { return a - b; };

            // // Using lambda expressions
            // MathOperation Multiply = (a, b) => a * b;
            // MathOperation Divide = (a, b) => a / b;

            // Console.WriteLine("Addition: " + PerformOperation(10, 5, Add));
            // Console.WriteLine("Subtraction: " + PerformOperation(10, 5, Subtract));
            // Console.WriteLine("Multiplication: " + PerformOperation(10, 5, Multiply));
            // Console.WriteLine("Division: " + PerformOperation(10, 5, Divide));

            // // Question: How does the use of delegates promote code reusability and flexibility in implementing mathematical operations?

            // // Answer:   Delegates allow passing different operations (addition, subtraction, etc.)
            // //           as parameters to a single function, avoiding code duplication.
            // //           This promotes reusability since the same PerformOperation method can handle 
            // //           any mathematical logic. It also improves flexibility, making it easy 
            // //           to extend the program by adding new operations without modifying existing code.
            #endregion

            #region Problem 13 & 14
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };

            // // Transformation: int -> string
            // List<string> stringList = TransformList(numbers, delegate (int n) { return n.ToString(); });
            // Console.WriteLine("Numbers as strings: " + string.Join(", ", stringList));

            // // Transformation: int -> double
            // List<double> squares = TransformList(numbers, n => Math.Pow(n, 2.5));
            // Console.WriteLine("Squares: " + string.Join(", ", squares));

            // // Transformation: int -> bool (even check)
            // List<bool> isEven = TransformList(numbers, n => n % 2 == 0);
            // Console.WriteLine("Is Even: " + string.Join(", ", isEven));

            // // Question: What are the advantages of using generic delegates in transforming data structures?
            // // Answer:   Generic delegates make the transformation function reusable for any type,
            // //           without rewriting code for each conversion. 
            // //           They improve flexibility since the same TransformList can handle int→string, 
            // //           int→double, or even complex type conversions.
            // //           This reduces redundancy, improves readability, and makes code easier to extend.

            // // Question: How does Func simplify the creation and usage of delegates in C#?
            // // Answer:   Func provides a built-in, generic way to define delegates without 
            // //           manually declaring custom delegate types. 
            // //           It simplifies code, improves readability, and reduces boilerplate 
            // //           since developers can use Func<T, TResult> directly instead of 
            // //           creating new delegate definitions for each case.
            #endregion

            #region Problem 15
            // List<string> messages = new List<string> { "Hello", "World", "C#", "Delegates", "Ali" };

            // // Using Action<string> to define the print action
            // Action<string> printAction = s => Console.Write(s + " ");

            // // Apply the action
            // ApplyAction(messages, printAction);

            // // Question: Why is Action preferred for operations that do not return values?
            //
            // // Answer:   Action is designed specifically for methods that perform an operation 
            // //           but don’t return a result. It improves code readability by clearly 
            // //           indicating no return value is expected, avoids unnecessary boilerplate, 
            // //           and makes delegate usage simpler for side-effect operations like printing.
            #endregion

            #region Problem 16
            // List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40 };

            // // Predicate to check if number is even
            // Predicate<int> isEven = n => n % 2 == 0;

            // // Filtering even numbers
            // List<int> evens = Filter(numbers, isEven);

            // Console.WriteLine("Even Numbers:");
            // foreach (var num in evens)
            // {
            //     Console.WriteLine(num);
            // }

            // // Question: What role do predicates play in functional programming, and how do they enhance code clarity?
            // // Answer:   Predicates encapsulate boolean conditions, making the code more declarative 
            // //           and expressive. Instead of scattering conditional logic throughout the code, 
            // //           predicates centralize it into reusable functions. This improves readability, 
            // //           reduces duplication, and makes intent clearer when filtering, searching, 
            // //           or validating data.
            #endregion

            #region Problem 17
            // List<string> names = new List<string> { "Ali", "Ahmed", "Sara", "Amr", "Mona", "Hana" };

            // // strings starting with 'A'
            // List<string> startsWithA = Filter(names, delegate (string s) { return s.StartsWith('A'); });

            // Console.WriteLine("Strings starting with A:");
            // foreach (var name in startsWithA)
            //     Console.WriteLine(name);

            // // strings containing "a"
            // List<string> containsA = Filter(names, delegate (string s) { return s.Contains('a'); });

            // Console.WriteLine("\nStrings containing 'a':");
            // foreach (var name in containsA)
            //     Console.WriteLine(name);

            // // Question: How do anonymous functions improve code modularity and customization?
            // // Answer:   Anonymous functions allow defining custom logic inline without 
            // //           creating separate named methods. This improves modularity by keeping 
            // //           related code close together and enhances customization by letting 
            // //           developers easily swap or adapt conditions for filtering, searching, 
            // //           or transformations without extra boilerplate.
            #endregion

            #region Problem 18
            // Using anonymous methods for mathematical operations
            // MathOperation mod = delegate (int a, int b) { return a % b; };
            // MathOperation power = delegate (int a, int b) { return (int)Math.Pow(a, b); };

            // Console.WriteLine("Modulus: " + PerformOperation(10, 3, mod));
            // Console.WriteLine("Power: " + PerformOperation(2, 5, power));

            // // Question: When should you prefer anonymous functions over named methods in implementing mathematical operations?
            // // Answer:   Anonymous functions are preferred when the operation is short-lived, 
            // //           specific to the current context, and does not need to be reused elsewhere. 
            // //           This keeps the code concise and avoids cluttering the class with extra 
            // //           named methods that are only used once.
            #endregion

            #region Problem 19
            // List<string> Words = new List<string> { "hi", "hello", "hey", "world", "C#", "Ali", "Ahmed", "Abeer" };

            // // Strings with length > 3
            // var LongWords = Filter(Words, s => s.Length > 3);
            // Console.WriteLine("Strings with length > 3: " + string.Join(", ", LongWords));

            // // Strings that contain 'e'
            // var WordsWithE = Filter(Words, s => s.Contains("e"));
            // Console.WriteLine("Strings containing 'e': " + string.Join(", ", WordsWithE));

            // // Question: What makes lambda expressions an essential feature in modern C# programming?
            //
            // // Answer:   Lambda expressions provide a concise and readable way to write inline 
            // //           logic without the need for separate named methods. They integrate 
            // //           seamlessly with LINQ and delegates, making code more expressive, 
            // //           functional in style, and easier to maintain.
            #endregion

            #region Problem 20
            // double x = 10, y = 2.723;

            // double division = Calculate(x, y, (a, b) => a / b);
            // Console.WriteLine($"{x} / {y} = {division}");

            // double exponent = Calculate(x, y, (a, b) => Math.Pow(a, b));
            // Console.WriteLine($"{x} ^ {y} = {exponent}");

            // // Question: How do lambda expressions enhance the expressiveness of mathematical computations in C#?
            // // Answer:   Lambda expressions allow mathematical logic to be written inline, 
            // //           making code more concise, readable, and flexible. 
            // //           Instead of defining multiple named methods for each operation, 
            // //           developers can quickly plug in custom operations like division 
            // //           or exponentiation directly at the point of use.
            #endregion
        }
        public delegate string StringTransformer(string input);
        public static List<string> TransformList(List<string> inputList, StringTransformer transformer)
        {
            List<string> result = new List<string>();
            foreach (var item in inputList)
            {
                result.Add(transformer(item));
            }
            return result;
        }

        public delegate int MathOperation(int a, int b);
        public static int PerformOperation(int x, int y, MathOperation operation)
        {
            return operation(x, y);
        }

        public delegate R Transformer<T, R>(T item);
        public static List<R> TransformList<T, R>(List<T> input, Transformer<T, R> transformer)
        {
            List<R> result = new List<R>();
            foreach (var item in input)
            {
                result.Add(transformer(item));
            }
            return result;
        }

        public static void ApplyAction(List<string> input, Action<string> action)
        {
            foreach (var item in input)
            {
                action(item);
            }
        }

        public static List<T> Filter<T>(List<T> numbers, Predicate<T> predicate)
        {
            List<T> result = new List<T>();
            foreach (var num in numbers)
            {
                if (predicate(num))
                    result.Add(num);
            }
            return result;
        }

        public static double Calculate(double a, double b, Func<double, double, double> operation)
        {
            return operation(a, b);
        }
    }
}