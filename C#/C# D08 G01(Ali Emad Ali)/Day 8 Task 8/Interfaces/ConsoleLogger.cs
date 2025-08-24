using System;

namespace Day_8_Task_8.Interfaces
{
    public class ConsoleLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Console Logger: {message}");
        }
    }
    public class DefaultLogger : ILogger { }
}