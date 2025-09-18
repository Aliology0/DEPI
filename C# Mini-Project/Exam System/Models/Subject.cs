namespace Exam_System.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public Subject(string name)
        {
            Name = name;
        }
        public Subject() : this("EMPTY") { }
        public override string ToString() => $"Subject: {Name}";
    }
}
