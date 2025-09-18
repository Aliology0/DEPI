using System;
using System.Collections.Generic;

namespace Exam_System.Models.Questions
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Marks { get; set; }
        public AnswerList Answers { get; set; }

        public Question(string header, string body, int marks)
        {
            Header = header;
            Body = body;
            Marks = marks;
            Answers = new AnswerList();
        }

        public Question() : this("EMPTY", "EMPTY", 0) { }

        public abstract bool IsCorrect(List<int> chosenIndexes);

        public virtual void Display()
        {
            Console.WriteLine($"{Header}\n{Body} ({Marks} Marks)");
            for (int i = 0; i < Answers.Count; i++)
                Console.WriteLine($"{i + 1}. {Answers[i].Text}");
        }
    }
}
