using System;

namespace Day07
{
    class Parent
    {
        public int X { get; set; }
        public int Y { get; set; }

        // Base class constructor
        public Parent(int x, int y)
        {
            X = x;
            Y = y;
            Console.WriteLine("Parent constructor called");
        }

        public virtual int Product()
        {
            return X * Y;
        }

        public override string ToString()
        {
            return $"Parent X: {X}, Y: {Y}";
        }
    }
}