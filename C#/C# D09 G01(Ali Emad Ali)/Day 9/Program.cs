using System;

namespace Day_9
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            // for (int i = 1; i <= 7; i++)
            // {
            //     Console.WriteLine($"Day {i}: {(Weekdays)i}");
            // }

            // // Question: Why is it recommended to explicitly assign values to enum members in some cases?
            // // Answer: It is recommended to explicitly assign values to enum members 
            // //         to avoid unexpected changes if the order of enum members is modified later. 
            // //         Explicit values also improve readability, ensure consistency across different systems,
            // //         and are especially useful when enums are used for bitwise operations or external mappings (database values).
            #endregion

            #region Problem 2
            // for (int i = -1; i <= 3; i++)
            // {
            //     Console.WriteLine($"Grade {i}: {(Grades)i}");
            // }

            // // Question: What happens if you assign a value to an enum member that exceeds the underlying type's range?
            // // Answer: If you assign a value to an enum member that exceeds the underlying type's range, 
            // //         the compiler will produce an error. For example, if the underlying type is short (range -32768 to 32767) 
            // //         and you try to assign 40000, the code will not compile.
            #endregion

            #region Problem 3
            // Person person1 = new Person { Name = "Ali", Age = 20, Department = "IT" };
            // Person person2 = new Person { Name = "Abeer", Age = 24, Department = "HR" };

            // Console.WriteLine(person1);
            // Console.WriteLine(person2);

            // // Question: What is the purpose of the virtual keyword when used with properties?
            // // Answer: The virtual keyword allows a property in a base class to be overridden 
            // //         in a derived class using the override keyword. This enables polymorphism, 
            // //         letting derived classes provide their own implementation for the property.
            #endregion

            #region Problem 4
            // Child child = new Child { Salary = 5000 };
            // child.DisplaySalary();

            // // Question: Why can’t you override a sealed property or method?
            // // Answer: A sealed property or method cannot be overridden because the sealed keyword 
            // //         explicitly prevents further inheritance of that member. This ensures that 
            // //         once it is sealed, no derived class can modify its implementation.
            #endregion

            #region Problem 5
            // Console.WriteLine($"Perimeter of Rectangle: {Utility.CalculatePerimeter(10, 5)}");

            // // Question: What is the key difference between static and object members?
            // // Answer: Static members belong to the class itself and are shared across all instances, 
            // //         while object members belong to individual instances of a class. 
            // //         Static members are accessed using the class name, whereas object members 
            // //         require creating an instance of the class.
            #endregion

            #region Problem 6
            // ComplexNumber num1 = new ComplexNumber(3, 2);
            // ComplexNumber num2 = new ComplexNumber(1, 7);

            // ComplexNumber result = num1 * num2;
            // Console.WriteLine($"({num1}) * ({num2}) = {result}");

            // // Question: Can you overload all operators in C#? Explain why or why not.
            // // Answer: No, not all operators can be overloaded in C#. Only a subset of operators 
            // //         (like +, -, *, /, ==, !=, etc.) can be overloaded. Some operators such as 
            // //         member access (.), conditional (?:), and assignment (=) cannot be overloaded 
            // //         because they are fundamental to the language’s behavior and structure.
            #endregion

            #region Problem 7
            // Console.WriteLine($"Size of Genderint (int): {sizeof(GenderDefault)} bytes");
            // Console.WriteLine($"Size of Genderbyte (byte): {sizeof(GenderByte)} bytes");

            // // Question: When should you consider changing the underlying type of an enum?
            // // Answer: You should consider changing the underlying type of an enum when memory 
            // //         optimization is important (large collections of enums), when the 
            // //         values fit within a smaller type (like byte or short).
            #endregion

            #region Problem 8
            // double celsius = 43;
            // double fahrenheit = Utility.CelsiusToFahrenheit(celsius);
            // Console.WriteLine($"{celsius}°C = {fahrenheit}°F");

            // fahrenheit = 77;
            // celsius = Utility.FahrenheitToCelsius(fahrenheit);
            // Console.WriteLine($"{fahrenheit}°F = {celsius}°C");

            // // Question: Why can't a static class have instance constructors?
            // // Answer: A static class cannot have instance constructors because it cannot be 
            // //         instantiated. Static classes are designed to hold only static members 
            // //         and provide global functionality, so creating objects of them has no meaning.
            #endregion

            #region Problem 9
            // Console.Write("Enter a grade (A, B, C, D, F): ");
            // string input = Console.ReadLine();

            // if (Enum.TryParse(input, true, out Grades grade))
            // {
            //     Console.WriteLine($"Successfully parsed: {grade} = {(int)grade}");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid grade entered.");
            // }

            // // Question: What are the advantages of using Enum.TryParse over direct parsing with int.Parse?
            // // Answer: Enum.TryParse provides a safe way to convert strings to enum values without 
            // //         throwing exceptions on invalid input. Unlike int.Parse (which only works with numbers 
            // //         and throws exceptions on failure), TryParse returns a boolean indicating success or failure, 
            // //         making it more efficient and user-friendly for handling invalid or unexpected input.
            #endregion

            #region Problem 10
            // Employee[] employees = new Employee[]
            // {
            //     new Employee { Id = 1, Name = "Ali" },
            //     new Employee { Id = 2, Name = "Abeer" },
            //     new Employee { Id = 3, Name = "Nadia" }
            // };

            // Employee searchEmployee = new Employee { Id = 2, Name = "Abeer" };

            // int index = Helper2<Employee>.SearchArray(employees, searchEmployee);

            // if (index != -1)
            //     Console.WriteLine($"Employee found at index {index}");
            // else
            //     Console.WriteLine("Employee not found.");

            // // Question: What is the difference between overriding Equals and == for object comparison in C# struct and class ?
            // // Answer: Overriding Equals allows you to define value-based comparison logic for objects, 
            // //         while == by default compares references for classes (reference types) and values 
            // //         for structs (value types). If you want == to behave like Equals for classes, you 
            // //         must overload the == operator explicitly. Structs already compare by value using == 
            // //         (unless overridden).

            // // Question: Why is overriding ToString beneficial when working with custom classes?
            // // Answer: Overriding ToString is beneficial because it provides a meaningful string 
            // //         representation of an object instead of the default type name. This makes 
            // //         debugging, logging, and displaying object data more readable and user-friendly, 
            // //         especially when working with collections or printing objects directly.
            #endregion

            #region Problem 11
            // int maxInt = Helper.Max(10, 20);
            // Console.WriteLine($"Max of 10 and 20 = {maxInt}");

            // double maxDouble = Helper.Max(12.5, 7.8);
            // Console.WriteLine($"Max of 12.5 and 7.8 = {maxDouble}");

            // string maxString = Helper.Max("Apple", "Banana");
            // Console.WriteLine($"Max of 'Apple' and 'Banana' = {maxString}");

            // // Question: Can generics be constrained to specific types in C#? Provide an example.
            // // Answer: Yes, generics can be constrained to specific types using constraints. 
            // //         For example, you can require that a generic type implements an interface, 
            // //         inherits from a class, or has a parameterless constructor:
            // //
            //         class Repository<T> where T : IEntity, new()
            //         {
            //             public T CreateInstance()
            //             {
            //                 return new T();
            //             }
            //         }
            // //
            // //         Here, T must implement IEntity and have a public parameterless constructor.
            #endregion

            #region Problem 12
            // int[] numbers = { 1, 2, 3, 2, 4, 2 };
            // Helper2<int>.ReplaceArray(numbers, 2, 9);
            // Console.WriteLine("integer array after replacement: ");
            // foreach (var number in numbers)
            // {
            //     Console.WriteLine(number);
            // }

            // string[] words = { "apple", "banana", "apple", "cherry" };
            // Helper2<string>.ReplaceArray(words, "apple", "orange");
            // Console.WriteLine("String array after replacement: ");
            // foreach (var word in words)
            // {
            //     Console.WriteLine(word);
            // }

            // // Question: What are the key differences between generic methods and generic classes?
            // // Answer: A generic class allows the entire class to be parameterized with a type, 
            // //         meaning all its members can use that type. A generic method, on the other hand, 
            // //         defines its own type parameter(s) independent of the class. 
            // //         This means you can have generic methods inside both generic and non-generic classes, 
            // //         giving more flexibility when you only need generic behavior for a single method.

            #endregion

            #region Problem 13
            // Rectangle rect1 = new Rectangle(10, 5);
            // Rectangle rect2 = new Rectangle(20, 15);

            // Console.WriteLine("Before Swap:");
            // Console.WriteLine($"Rectangle 1: {rect1}");
            // Console.WriteLine($"Rectangle 2: {rect2}");

            // Swap(ref rect1, ref rect2);

            // Console.WriteLine("\nAfter Swap:");
            // Console.WriteLine($"Rectangle 1: {rect1}");
            // Console.WriteLine($"Rectangle 2: {rect2}");

            // // Question: Why might using a generic swap method be preferable to implementing custom methods for each type?
            // // Answer: A generic swap method is preferable because it can work with any data type, 
            // //         avoiding code duplication and making the code more reusable and maintainable. 
            // //         Writing a custom swap method for every type would be inefficient and harder to maintain.
            #endregion

            #region Problem 14
            // Department ds = new Department { DeptId = 1, DeptName = "DS" };
            // Department it = new Department { DeptId = 2, DeptName = "IT" };
            // Department hr = new Department { DeptId = 3, DeptName = "HR" };

            // Employee2[] employees = new Employee2[]
            // {
            // new Employee2 { Id = 1, Name = "Ali", Department = ds },
            // new Employee2 { Id = 2, Name = "Abeer", Department = hr },
            // new Employee2 { Id = 3, Name = "Nadia", Department = it }
            // };

            // // Search for employees in the IT department
            // Console.WriteLine("Searching for employees in IT department:");
            // for (int i = 0; i < employees.Length; i++)
            // {
            //     if (employees[i].Department.Equals(it))
            //     {
            //         Console.WriteLine(employees[i]);
            //     }
            // }

            // // Question: How can overriding Equals for the Department class improve the accuracy of searches?
            // // Answer: Overriding Equals in the Department class ensures that two department objects 
            // //         with the same DeptId and DeptName are treated as equal, even if they are different 
            // //         object instances. Without this, searches would only compare references, leading to 
            // //         inaccurate results when matching logically identical departments.
            #endregion

            #region Problem 15
            // // Struct comparison
            // CircleStruct s1 = new CircleStruct(5, "Red");
            // CircleStruct s2 = new CircleStruct(5, "Red");

            // Console.WriteLine("Struct comparison:");
            // Console.WriteLine($"s1.Equals(s2): {s1.Equals(s2)}");   // True (value-based)
            // // Console.WriteLine(s1 == s2); //Not allowed by default for structs

            // // Class comparison
            // CircleClass c1 = new CircleClass(5, "Red");
            // CircleClass c2 = new CircleClass(5, "Red");

            // Console.WriteLine("\nClass comparison:");
            // Console.WriteLine($"c1.Equals(c2): {c1.Equals(c2)}");   // True (overridden Equals)
            // Console.WriteLine($"c1 == c2: {c1 == c2}");             // False (reference comparison)

            // // Question: Why is == not implemented by default for structs?
            // // Answer: == is not implemented by default for structs because structs are value types 
            // //         and the default == operator works only for built-in primitive types. 
            // //         Automatically generating == for all structs could lead to performance costs 
            // //         and ambiguity, so C# requires developers to explicitly overload == if needed.
            #endregion
        }

        public static void Swap(ref Rectangle r1, ref Rectangle r2)
        {
            Rectangle temp = r1;
            r1 = r2;
            r2 = temp;
        }
    }
}
