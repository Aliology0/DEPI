using System;

namespace Day07
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Problem 1
            // // Default Constructor
            // Car car1 = new Car();
            // Console.WriteLine(car1);

            // // Constructor with ID
            // car1 = new Car(1);
            // Console.WriteLine(car1);

            // // Constructor with ID and Brand
            // car1 = new Car(634, "Toyota");
            // Console.WriteLine(car1);

            // // Constructor with ID, Brand, and Price
            // car1 = new Car(1343, "BMW", 30000);
            // Console.WriteLine(car1);

            // // Question: Why does defining a custom constructor suppress the default constructor in C#?
            // // Answer: If the compiler always added a default constructor, 
            // //         you might unintentionally allow object creation in a state you didn’t plan for.
            #endregion

            #region Problem 2
            // Calculator calc = new Calculator();

            // // Add two integers
            // int result1 = calc.Sum(10, 20);
            // Console.WriteLine(result1);

            // // Add three integers
            // int result2 = calc.Sum(5, 15, 25);
            // Console.WriteLine(result2);

            // // Add two doubles
            // double result3 = calc.Sum(12.5, 7.8);
            // Console.WriteLine(result3);

            // // Question: How does method overloading improve code readability and reusability?
            // // Answer: Method overloading allows multiple methods with the same name to coexist, 
            // //         each with different parameters. This improves code readability by providing a clear
            // //         and concise way to perform similar operations without needing to remember different method names.
            #endregion

            #region Problem 3
            // Child child = new Child(10, 20, 30);
            // Console.WriteLine(child);

            // // Question: What is the purpose of constructor chaining in inheritance?
            // // Answer: Constructor chaining in inheritance allows a derived class to call a base class constructor,
            // //         ensuring that the base class is initialized properly before the derived class adds its own
            // //         initialization logic. This promotes code reuse and helps maintain a clear initialization order.
            #endregion

            #region Problem 4
            // Console.WriteLine("Using 'new' keyword (method hiding)");
            // Parent p1 = new NewChild(2, 3, 4);
            // Console.WriteLine("Called via Parent reference: " + p1.Product());
            // NewChild c1 = new NewChild(2, 3, 4);
            // Console.WriteLine("Called via Child reference: " + c1.Product());

            // Console.WriteLine("\nUsing 'override' keyword (true overriding)");
            // Parent p2 = new OverrideChild(2, 3, 4);
            // Console.WriteLine("Called via Parent reference: " + p2.Product());
            // OverrideChild c2 = new OverrideChild(2, 3, 4);
            // Console.WriteLine("Called via Child reference: " + c2.Product());

            // // Question: How does new differ from override in method overriding?
            // // Answer: The 'new' keyword hides the base class method, while 'override' replaces it.
            #endregion

            #region Problem 5
            // Parent parent = new Parent(10, 20);
            // Child child = new Child(1, 2, 3);

            // Parent polytest = new Child(5, 6, 7);

            // Console.WriteLine("Parent object: " + parent);
            // Console.WriteLine("Child object: " + child);
            // Console.WriteLine("Polymorphic reference: " + polytest);

            // // Question: Why is ToString() often overridden in custom classes?
            // // Answer: Because in custom classes, the default implementation of ToString() may not provide meaningful information.
            // //         Overriding ToString() allows developers to provide a string representation that is more informative
            // //         and relevant to the specific class, making it easier to understand the object's state when debugging
            // //         or logging.
            #endregion

        }
    }
}