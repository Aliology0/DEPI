using System;

namespace Day_8_Task_8.Interfaces
{
    public class Robot : IWalkable
    {
        public void Walk()
        {
            Console.WriteLine("Robot is walking in normal mode.");
        }

        void IWalkable.Walk()
        {
            Console.WriteLine("Robot is walking in interface-controlled SAFE mode.");
        }
    }
}