using System;

namespace Day08.Interfaces
{
    public class Rectangle : IShape
    {
        private double width;
        private double height;

        public Rectangle(double _width, double _height)
        {
            width = _width;
            height = _height;
        }

        public double Area
        {
            get { return width * height; }
        }

        public void Draw()
        {
            Console.WriteLine("Drawing a Rectangle...");
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        public void PrintDetails()
        {
            Console.WriteLine($"Rectangle: Width = {width}, Height = {height}, Area = {Area}");
        }
    }
}