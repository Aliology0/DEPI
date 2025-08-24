using System;

namespace Day08.interfaces
{
    public class AbstractRectangle : Shape
    {
        private double width;
        private double height;

        public AbstractRectangle(double _width, double _height)
        {
            width = _width;
            height = _height;
        }

        public override void Draw()
        {
            Console.WriteLine("Drawing a Rectangle.");
        }

        public override double CalculateArea()
        {
            return width * height;
        }
    }
}