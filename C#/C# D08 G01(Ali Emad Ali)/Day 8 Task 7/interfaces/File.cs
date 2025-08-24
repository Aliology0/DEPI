using System;

namespace Day08.Interfaces
{
    public class File : IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Reading from the file.");
        }

        public void Write()
        {
            Console.WriteLine("Writing to the file.");
        }
    }
}
