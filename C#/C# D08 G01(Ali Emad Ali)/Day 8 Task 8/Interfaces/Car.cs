using System;

namespace Day_8_Task_8.Interfaces
{
    public class Car : IVehicle
    {
        public void StartEngine()
        {
            Console.WriteLine("Car engine started.");
        }

        public void StopEngine()
        {
            Console.WriteLine("Car engine stopped.");
        }
    }
}