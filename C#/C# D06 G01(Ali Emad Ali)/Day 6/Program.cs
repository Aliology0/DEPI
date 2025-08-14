using System;
using System.Security.Cryptography;

namespace Day_6
{
    class Program
    {


        // Method for struct (value type) : Problem 6
        static void ModifyStruct(Point point)
        {
            point.X = 99;
            point.Y = 88;
            Console.WriteLine("Inside ModifyStruct: \n" + point);
        }

        // Method for class (reference type) : Problem 6
        static void ModifyClass(Employee emp)
        {
            emp.SetName("Mohamed");
            emp.SetSalary(6000);
            Console.WriteLine("Inside ModifyClass: \n" + emp);
        }
        static void Main(string[] args)
        {
            #region Problem 1
            // Point point1 = new Point(3, 4);
            // Point point2 = new Point();
            // Console.WriteLine(point1);
            // Console.WriteLine(point2);

            // // Question: Why can't a struct inherit from another struct or class in C#?
            // // Answer: Because structs are value types and do not support inheritance like reference types do.
            #endregion

            #region Problem 2
            // TypeA typeA1 = new TypeA(5, 12, 354);

            // Console.WriteLine(typeA1);
            // // Console.WriteLine(typeA1.F); // Private: Does not access
            // Console.WriteLine(typeA1.G); // internal: Does access Because it is in the same assembly
            // Console.WriteLine(typeA1.H); // Public: Does access

            // // Question: How do access modifiers impact the scope and visibility of a class member?
            // // Answer: Access modifiers determine the accessibility of class members.
            // //         Private members are only accessible within the same class,
            // //         internal members are accessible within the same assembly,
            // //         and public members are accessible from any other code.
            #endregion

            #region Problem 3
            // Employee employee1 = new Employee(1, "John Doe", 50000);
            // Employee employee2 = new Employee(2, "Jane Smith", 60000);
            // Console.WriteLine(employee1);
            // Console.WriteLine(employee2);

            // // Question: Why is encapsulation critical in software design?
            // // Answer: Encapsulation is critical because it helps to protect the internal state of an object
            // //         and only exposes a controlled interface for interaction. This reduces complexity
            // //         and increases maintainability by preventing external code from depending on the
            // //         internal implementation details of a class.
            #endregion

            #region Problem 4
            // Point p1 = new Point(5);
            // Console.WriteLine(p1);

            // Point p2 = new Point(10, 20);
            // Console.WriteLine(p2);

            // // Question: what is constructors in structs?
            // // Answer: Constructors in structs are special methods that are called when an instance of the struct is created.
            // //         They can be used to initialize the fields of the struct and can have parameters to allow for different ways of creating the struct.
            #endregion

            #region Problem 5
            // Point p1 = new Point(523);
            // Point p2 = new Point(10, 20);
            // Point p3 = new Point(-3, 7);
            // Point p4 = new Point(32, -47);

            // Console.WriteLine(p1);
            // Console.WriteLine(p2);
            // Console.WriteLine(p3);
            // Console.WriteLine(p4);

            // // Question: How does overriding methods like ToString() improve code readability?
            // // Answer: Overriding methods like ToString() improves code readability by providing a clear and concise string representation of an object.
            // //         This allows developers to easily understand the object's state and behavior when debugging or logging information.

            #endregion

            #region Problem 6 (Bonus)
            // // ===== Value type test (struct) =====
            // Point p = new Point(10, 20);
            // Console.WriteLine("Before ModifyStruct: \n" + p);

            // ModifyStruct(p); // Passing a value type (copy)
            // Console.WriteLine("After ModifyStruct:  \n" + p);

            // Console.WriteLine();

            // // ===== Reference type test (class) =====
            // Employee e = new Employee(1, "Ali", 5000);
            // Console.WriteLine("Before ModifyClass: \n" + e);

            // ModifyClass(e); // Passing a reference type (same object)
            // Console.WriteLine("After ModifyClass:  \n" + e);

            // // Question: How does memory allocation differ for structs and classes in C#?
            // // Answer: In C#, structs are value types and are allocated on the stack,
            // //         while classes are reference types and are allocated on the heap.
            // //         This means that structs are copied by value, whereas classes are copied by reference.
            #endregion


        }
    }
}