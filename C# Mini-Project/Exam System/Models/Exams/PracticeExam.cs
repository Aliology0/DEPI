using System;

namespace Exam_System.Models.Exams
{
    public class PracticeExam : Exam
    {
        public PracticeExam(string subject, TimeSpan Time) : base(subject, Time) { }

        public override void DisplayExam()
        {
            Console.WriteLine("\n*** Practical Exam ***");
            base.DisplayExam();
        }
    }
}
