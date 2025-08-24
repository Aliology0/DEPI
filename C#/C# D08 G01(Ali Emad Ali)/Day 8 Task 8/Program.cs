using System;
using Day_8_Task_8.Interfaces;
using Day_8_Task_8.Abstract;

namespace Day_8_Task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            // Car car = new Car();
            // IVehicle vehicle = car;
            // vehicle.StartEngine();
            // vehicle.StopEngine();

            // Bike bike = new Bike();
            // vehicle = bike;
            // vehicle.StartEngine();
            // vehicle.StopEngine();

            // // Question: Why is it better to code against an interface rather than a concrete class?
            // // Answer: Coding against an interface allows for greater flexibility and easier maintenance.
            // //         It enables the use of different implementations without changing the code that uses the interface.
            #endregion

            #region Problem 2
            // Shape rect = new Rectangle(20, 5);
            // Shape circ = new Circle(10);
            // rect.Display();
            // circ.Display();

            // // Question: When should you prefer an abstract class over an interface?
            // // Answer: You should prefer an abstract class over an interface when you want to provide a common base class with default behavior
            // //         that can be shared among derived classes. Abstract classes allow you to define some methods with implementation,
            // //         while interfaces can only define method signatures.
            #endregion

            #region Problem 3
            // Product p1 = new Product(1, "Product 1", 10.99m);
            // Product p2 = new Product(2, "Product 2", 5.99m);
            // Product p3 = new Product(3, "Product 3", 15.99m);
            // Product p4 = new Product(4, "Product 4", 12.99m);
            // Product p5 = new Product(5, "Product 5", 8.99m);
            // Product p6 = new Product(6, "Product 6", 20.99m);

            // Product[] products = { p1, p2, p3, p4, p5, p6 };
            // Console.WriteLine("=== Before Sorting ===");
            // foreach (var p in products)
            //     Console.WriteLine(p);

            // for (int i = 0; i < products.Length - 1; i++)
            // {
            //     for (int j = i + 1; j < products.Length; j++)
            //     {
            //         if (products[i].CompareTo(products[j]) > 0)
            //         {
            //             Product temp = products[i];
            //             products[i] = products[j];
            //             products[j] = temp;
            //         }
            //     }
            // }

            // Console.WriteLine("\n=== After Sorting ===");
            // foreach (var p in products)
            //     Console.WriteLine(p);

            // // Question: How does implementing IComparable improve flexibility in sorting?
            // // Answer: Implementing IComparable allows objects to be compared based on their natural ordering,
            // //         making it easier to sort collections without needing to specify custom comparison logic.
            #endregion

            #region Problem 4
            // Student s1 = new Student(1, "Ali", 90.5m);

            // // Shallow Copy
            // Student s2 = s1;

            // s2.Name = "Abeer";
            // s2.Grade = 75.4m;

            // Console.WriteLine("=== Shallow Copy ===");
            // Console.WriteLine(s1);
            // Console.WriteLine(s2);
            // Console.WriteLine(s1.GetHashCode());
            // Console.WriteLine(s2.GetHashCode());

            // // Deep Copy
            // Student s3 = new Student(1, "Ali", 90.5m);
            // Student s4 = new Student(s3);
            // Console.WriteLine("=== Deep Copy ===");
            // Console.WriteLine(s3);
            // Console.WriteLine(s4);
            // Console.WriteLine(s3.GetHashCode());
            // Console.WriteLine(s4.GetHashCode());

            // // Question: What is the primary purpose of a copy constructor in C#?
            // // Answer: The primary purpose of a copy constructor in C# is to create a new instance of a class
            // //         by copying the values of an existing instance. This is useful for creating deep copies
            // //         of objects, ensuring that the new object is independent of the original.
            #endregion

            #region Problem 5
            // Robot r = new Robot();

            // r.Walk();

            // IWalkable walker = r;
            // walker.Walk();

            // ((IWalkable)r).Walk();

            // // Question: How does explicit interface implementation help in resolving naming conflicts?
            // // Answer: Explicit interface implementation allows a class to implement members of an interface
            // //         in a way that avoids naming conflicts with other members of the class. This is useful
            // //         when a class implements multiple interfaces that may have members with the same name.
            #endregion

            #region Problem 6
            // // Create account using constructor
            // Account acc1 = new Account(101, "Ali", 5000m);
            // Console.WriteLine(acc1);

            // // Create account without constructor (using properties)
            // Account acc2;
            // acc2 = new Account();
            // acc2.AccountId = 102;
            // acc2.AccountHolder = "Abeer";
            // acc2.Balance = 3000m;
            // Console.WriteLine(acc2);

            // // Test validation
            // acc2.Balance = -100;
            // Console.WriteLine(acc2);

            // // Question: What is the key difference between encapsulation in structs and classes?
            // // Answer: The key difference is that structs are value types and are copied on assignment,
            // //         while classes are reference types and are accessed via references. This affects
            // //         how encapsulation is implemented and how data is shared between instances.

            // // Question: what is abstraction as a guideline, what’s its relation with encapsulation?
            // // Answer: Abstraction is the concept of hiding the complex implementation details and showing only the essential features of the object.
            // //         It is closely related to encapsulation, as both aim to reduce complexity and increase efficiency.
            // //         While encapsulation restricts access to certain details, abstraction focuses on exposing only the necessary parts of an object.
            #endregion

            #region Problem 7
            // ILogger logger = new ConsoleLogger();
            // logger.Log("This is a log message.");

            // ILogger defaultLogger = new DefaultLogger();
            // defaultLogger.Log("This is a log message.");

            // // Question: How do default interface implementations affect backward compatibility in C#?
            // // Answer: Default interface implementations allow developers to add new methods to interfaces without breaking existing implementations.
            // //         This means that older classes implementing the interface do not need to be modified to adapt to the new methods, maintaining backward compatibility.
            #endregion

            #region Problem 8
            // // Using default constructor
            // Book b1 = new Book();
            // Console.WriteLine(b1);

            // // Using constructor with only Title
            // Book b2 = new Book("A song of ice and fire");
            // Console.WriteLine(b2);

            // // Using constructor with Title and Author
            // Book b3 = new Book("C# in a nutshell", "Joseph Albahari");
            // Console.WriteLine(b3);

            // // Question: How does constructor overloading improve class usability?
            // // Answer: Constructor overloading allows a class to be instantiated in different ways, providing flexibility
            // //         and making it easier for users to create objects with varying levels of detail.
            #endregion
        }
    }
}