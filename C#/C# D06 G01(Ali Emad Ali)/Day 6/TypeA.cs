using System;

namespace Day_6
{
    public class TypeA
    {
        private int F { get; set; }
        internal int G { get; set; }
        public int H { get; set; }

        public TypeA(int f, int g, int h)
        {
            F = f;
            G = g;
            H = h;
        }

        public override string ToString()
        {
            return $"F: {F}, G: {G}, H: {H}";
        }
    }
}