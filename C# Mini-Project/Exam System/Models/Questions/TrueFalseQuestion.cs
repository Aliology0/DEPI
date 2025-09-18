using System;
using System.Collections.Generic;

namespace Exam_System.Models.Questions
{
    public class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string header, string body, int marks) : base(header, body, marks) { }

        public TrueFalseQuestion() : this("EMPTY", "EMPTY", 0) { }

        public override bool IsCorrect(List<int> chosenIndexes)
        {
            if (chosenIndexes.Count != 1) return false;
            int index = chosenIndexes[0];
            return Answers[index].IsCorrect;
        }
        public override void Display()
        {
            Console.WriteLine($"{Header}\n{Body} ({Marks} Marks)");
            Console.WriteLine("1. True\n2. False");
        }
    }
}
