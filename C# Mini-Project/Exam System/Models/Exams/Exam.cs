using Exam_System.Enums;
using Exam_System.Models.Questions;
using System;
using System.Collections.Generic;

namespace Exam_System.Models.Exams
{
    public class Exam : IComparable<Exam>
    {
        public Subject Subject { get; set; }
        public TimeSpan Time { get; set; }
        public Dictionary<Question, AnswerList> QA { get; set; }
        public ExamMode ExamMode { get; set; }

        public Exam(string subject, TimeSpan time)
        {
            Subject = new Subject(subject);
            Time = time;
            QA = new Dictionary<Question, AnswerList>();
            ExamMode = ExamMode.Queued;
        }

        public void TakeExam()
        {
            Console.Clear();
            Console.WriteLine($"Starting {Subject.Name} Exam...");
            int score = 0;
            int total = 0;

            foreach (var pair in QA)
            {
                Question question = pair.Key;
                question.Answers = pair.Value;

                Console.WriteLine("\n---------------------------------");
                question.Display();

                total += question.Marks;

                Console.Write("Your Answer (comma-separated for multiple): ");
                string input = Console.ReadLine();

                // Parse input
                List<int> chosenIndexes = new List<int>();
                string[] parts = input.Split(',');
                foreach (string part in parts)
                {
                    int num;
                    if (int.TryParse(part.Trim(), out num))
                    {
                        int index = num - 1;
                        if (index >= 0 && index < question.Answers.Count)
                            chosenIndexes.Add(index);
                    }
                }

                if (question.IsCorrect(chosenIndexes))
                {
                    score += question.Marks;
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine("Wrong!");
                }
            }

            Console.WriteLine("\n=================================");
            Console.WriteLine($"Exam Finished! Your Score: {score}/{total}");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }


        public virtual void DisplayExam()
        {
            Console.WriteLine($"\nExam: {Subject.Name} | Time: {Time} | Mode: {ExamMode}");
            Console.WriteLine("========================================");

            int qNum = 1;
            foreach (var pair in QA)
            {
                Console.WriteLine($"\nQ{qNum}:");
                pair.Key.Display(); // header + body + marks

                var answers = pair.Value;
                for (int i = 0; i < answers.Count; i++)
                    if (answers[i].IsCorrect)
                        Console.WriteLine($"    Correct Answer: {answers[i].Text}");

                qNum++;
            }
            Console.WriteLine("========================================\n");
            Console.WriteLine("Press any key to return to menu...");
            Console.ReadKey();
        }

        public void AddQuestion(Question question, AnswerList answers)
        {
            if (!QA.ContainsKey(question))
                QA[question] = answers;
        }

        public void RemoveQuestion(Question question)
        {
            if (QA.ContainsKey(question))
                QA.Remove(question);
        }

        public int CompareTo(Exam other) => Time.CompareTo(other.Time);
        public override string ToString() => $"Exam: {Subject}, Time: {Time}, Mode: {ExamMode}";
        public override bool Equals(object obj) =>
            obj is Exam e && Subject.Name == e.Subject.Name && Time == e.Time && QA == e.QA;
        public override int GetHashCode() => HashCode.Combine(Subject.Name, Time, QA);
    }
}
