using System;

namespace Day08.interfaces
{
    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Drawing a shape.");
        }

        public abstract double CalculateArea();
    }
}