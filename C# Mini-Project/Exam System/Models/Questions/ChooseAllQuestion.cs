using System;
using System.Collections.Generic;

namespace Exam_System.Models.Questions
{
    public class ChooseAllQuestion : ChooseOneQuestion
    {
        public ChooseAllQuestion(string header, string body, int marks) : base(header, body, marks) { }

        public ChooseAllQuestion() : this("EMPTY", "EMPTY", 0) { }

        public override bool IsCorrect(List<int> chosenIndexes)
        {
            // Correct if user picked ALL correct answers and NO wrong ones
            for (int i = 0; i < Answers.Count; i++)
            {
                if (Answers[i].IsCorrect && !chosenIndexes.Contains(i)) return false;
                if (!Answers[i].IsCorrect && chosenIndexes.Contains(i)) return false;
            }
            return true;
        }

        public override void Display()
        {
            Console.WriteLine($"{Header}\n{Body} ({Marks} Marks)");
            Console.WriteLine("Select more than one answer:");
            for (int i = 0; i < Answers.Count; i++)
                Console.WriteLine($"{i + 1}. {Answers[i].Text}");
        }
    }
}
