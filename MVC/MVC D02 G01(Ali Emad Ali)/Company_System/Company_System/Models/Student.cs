﻿namespace Company_System.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }

        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; } = new List<StudentCourses>();
    }
}
