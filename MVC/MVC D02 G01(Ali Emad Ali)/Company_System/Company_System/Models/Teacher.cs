﻿namespace Company_System.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Salary { get; set; }
        public string Address { get; set; } = string.Empty;

        public int CourseId { get; set; }
        public int DepartmentId { get; set; }
        public Course Course { get; set; }
        public Department Department { get; set; }
    }
}
