using System;

namespace Exam_System.Models
{
    public static class SafeInputReader
    {
        public static int SafeReadInt(string Message, int min = int.MinValue, int max = int.MaxValue)
        {
            int value;
            while (true)
            {
                Console.Write(Message);
                string input = Console.ReadLine();
                if (int.TryParse(input, out value) && value >= min && value <= max)
                    return value;

                Console.WriteLine("Invalid number. Please try again.");
            }
        }

        public static string SafeReadString(string Message, bool AllowNull = false)
        {
            while (true)
            {
                Console.Write(Message);
                string input = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(input) || AllowNull)
                    return input;

                Console.WriteLine("Invalid input. Please try again.");
            }
        }
    }
}
