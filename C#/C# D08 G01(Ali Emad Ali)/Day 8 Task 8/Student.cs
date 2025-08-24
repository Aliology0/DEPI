using System;

namespace Day_8_Task_8
{
    class Student
    {
        private int id;
        private string name = "unknown";
        private decimal grade = 0.0m;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public decimal Grade
        {
            get { return grade; }
            set { grade = value; }
        }

        public Student(int _id, string _name, decimal _grade)
        {
            id = _id;
            name = _name;
            grade = _grade;
        }
        public Student(Student? copy)
        {
            if (copy != null)
            {
                id = copy.id;
                name = copy.name;
                grade = copy.grade;
            }
        }

        public override string ToString()
        {
            return $"Student ID: {id}, Name: {name}, Grade: {grade:F2}";
        }
    }
}