using System;

namespace Day_8_Task_8.Interfaces
{
    public interface ILogger
    {
        void Log(string message)
        {
            Console.WriteLine($"Original Logger: {message}");
        }
    }
}