using System;

namespace Exam_System.Models.Exams
{
    public class FinalExam : Exam
    {
        public FinalExam(string subject, TimeSpan Time) : base(subject, Time) { }

        public override void DisplayExam()
        {
            Console.WriteLine("\n*** Final Exam ***");
            base.DisplayExam();
        }
    }
}
