using System;

namespace Day07
{
    class Child : Parent
    {
        public int Z { get; set; }

        // Child class constructor
        public Child(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Child constructor called");
        }

        public override string ToString()
        {
            return $"Child X: {X}, Y: {Y}, Z: {Z}";
        }
    }
    class NewChild : Parent
    {
        public int Z { get; set; }

        // Child class constructor
        public NewChild(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("New Child constructor called");
        }

        public new int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"Child X: {X}, Y: {Y}, Z: {Z}";
        }
    }
    class OverrideChild : Parent
    {
        public int Z { get; set; }

        // Child class constructor
        public OverrideChild(int x, int y, int z) : base(x, y)
        {
            Z = z;
            Console.WriteLine("Override Child constructor called");
        }

        public override int Product()
        {
            return X * Y * Z;
        }

        public override string ToString()
        {
            return $"Child X: {X}, Y: {Y}, Z: {Z}";
        }
    }
}