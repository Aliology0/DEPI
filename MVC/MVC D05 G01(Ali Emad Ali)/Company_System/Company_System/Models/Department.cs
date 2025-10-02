using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Department name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
        [RegularExpression(@"^[a-zA-Z\s0-9]$", ErrorMessage = "Name can only contain letters, spaces and Numbers")]
        public string Name { get; set; } = string.Empty;

        [Required(ErrorMessage = "Manager Name is required")]
        [StringLength(100, ErrorMessage = "Name cannot exceed 100 characters")]
        [MinLength(3, ErrorMessage = "Name cannot be less than 3 characters")]
        [RegularExpression(@"^[a-zA-Z\s]$", ErrorMessage = "Name can only contain letters and spaces")]
        public string MgrName { get; set; } = string.Empty;

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}