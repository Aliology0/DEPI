using System;

namespace Day_8_Task_8.Abstract
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public void Display()
        {
            Console.WriteLine($"Area: {GetArea()}");
        }
    }




}