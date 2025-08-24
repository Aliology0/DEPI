using System;

namespace Day08.Interfaces
{
    public class Circle : IShape
    {
        private double radius;

        public Circle(double _radius)
        {
            radius = _radius;
        }

        public double Area
        {
            get { return Math.PI * radius * radius; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Circle...");
        }
    }
}