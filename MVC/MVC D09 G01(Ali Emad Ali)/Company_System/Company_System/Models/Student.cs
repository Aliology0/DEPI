using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class Student
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, ErrorMessage = "Name cannot exceed 50 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
        [RegularExpression(@"^[a-zA-Z\s]$", ErrorMessage = "Name can only contain letters and spaces")]
        public string Name { get; set; } = string.Empty;

        [Range(14, 100, ErrorMessage = "Age must be between 14 and 100")]
        public int Age { get; set; }

        [Required(ErrorMessage = "Department is required")]
        public int DepartmentId { get; set; }
        public Department? Department { get; set; }

        public ICollection<StudentCourses> StudentCourses { get; set; } = new List<StudentCourses>();
    }
}
