using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Course name is required")]
        [StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [Range(0, 100, ErrorMessage = "Degree must be between 0 and 100")]
        public decimal Degree { get; set; }

        [Range(0, 100, ErrorMessage = "Min Degree must be between 0 and 100")]
        public decimal MinDegree { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; } = new List<StudentCourses>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}
