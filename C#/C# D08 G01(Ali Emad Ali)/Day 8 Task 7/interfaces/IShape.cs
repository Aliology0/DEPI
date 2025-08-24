using System;

namespace Day08.Interfaces
{
    public interface IShape
    {
        double Area { get; }
        void Draw();
        void PrintDetails()
        {
            Console.WriteLine($"This is a {GetType().Name} with area = {Area}");
        }
    }
}