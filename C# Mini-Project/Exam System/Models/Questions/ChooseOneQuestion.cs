using System.Collections.Generic;

namespace Exam_System.Models.Questions
{
    public class ChooseOneQuestion : Question
    {
        public ChooseOneQuestion(string header, string body, int marks) : base(header, body, marks) { }

        public ChooseOneQuestion() : this("EMPTY", "EMPTY", 0) { }

        public override bool IsCorrect(List<int> chosenIndexes)
        {
            if (chosenIndexes.Count != 1) return false;
            int index = chosenIndexes[0];
            return Answers[index].IsCorrect;
        }

        public override void Display()
        {
            base.Display();
        }
    }
}
