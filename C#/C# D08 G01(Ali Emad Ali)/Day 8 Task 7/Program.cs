using System;
using Day_8.interfaces;

namespace Day_8_Task_7
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Problem 6
            // Rectangle rect = new Rectangle(20, 5);
            // IShape shape = rect;

            // shape.PrintDetails();
            // shape.Draw();

            // // Question: Why can't you create an instance of an interface directly?
            // // Answer: Because an interface is a contract that defines a set of methods and properties
            // //         that a class must implement. It does not provide any implementation itself, so you cannot
            // //         create an instance of it. Instead, you create an instance of a class that implements the interface.
            #endregion

            #region Problem 7
            // Circle circle = new Circle(10);
            // IShape shape = circle;

            // shape.PrintDetails();
            // shape.Draw();

            // // Question: What are the benefits of default implementations in interfaces introduced in C# 8.0?
            // // Answer: Default implementations allow you to provide a default behavior for methods in an interface,
            // //         so that classes implementing the interface can use the default behavior without having to provide
            // //         their own implementation. This can help reduce code duplication and make it easier to evolve interfaces
            // //         over time without breaking existing implementations.
            #endregion

            #region Problem 8
            // IMovable car = new Car();
            // car.Move();

            // // Question: Why is it useful to use an interface reference to access implementing class methods?
            // // Answer: Using an interface reference allows for more flexible and decoupled code. It enables you to write
            // //         code that can work with any class that implements the interface, without needing to know the
            // //         specific details of the class. This promotes code reusability and makes it easier to swap out
            // //         implementations if needed.
            #endregion

            #region Problem 9
            // File file = new File();
            // file.Read();
            // file.Write();

            // // Question: How does C# overcome the limitation of single inheritance with interfaces?
            // // Answer: C# allows a class to implement multiple interfaces, thus overcoming the limitation of single inheritance.
            // //         This means a class can inherit behaviors from multiple sources, promoting code reusability and flexibility.
            #endregion

            #region Problem 10
            // Shape rect = new AbstractRectangle(60, 20);

            // rect.Draw();
            // Console.WriteLine($"Area: {rect.CalculateArea()}");

            // // Question: What is the difference between a virtual method and an abstract method in C#?
            // // Answer: A virtual method provides a default implementation that can be overridden in derived classes,
            // //         while an abstract method does not provide any implementation and must be implemented in derived classes.

            #endregion
        }
    }
}