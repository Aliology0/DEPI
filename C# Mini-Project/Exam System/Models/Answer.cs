using System.Collections.Generic;

namespace Exam_System.Models
{
    public class Answer
    {
        public string Text { get; set; }
        public bool IsCorrect { get; set; }

        public Answer(string text, bool isCorrect)
        {
            Text = text;
            IsCorrect = isCorrect;
        }
        public Answer() : this("Empty", false) { }

        public override string ToString() => $"{Text} {(IsCorrect ? "(Correct)" : "(False)")}";
    }

    public class AnswerList : List<Answer>
    {
        public AnswerList() : base() { }
        public void Add(string text, bool isCorrect) => Add(new Answer(text, isCorrect));
        public void RemoveAtIndex(int index) => base.RemoveAt(index);
    }
}
