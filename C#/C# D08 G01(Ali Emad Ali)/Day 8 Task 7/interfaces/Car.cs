using System;

namespace Day08.Interfaces
{
    public class Car : IMovable
    {
        public void Move()
        {
            Console.WriteLine("The car is moving.");
        }
    }
}
