using System.ComponentModel.DataAnnotations;

namespace Company_System.Models
{
    public class Department
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [RegularExpression(@"^[A-Za-z0-9\s]+$", ErrorMessage = "Name can only contain letters, spaces and numbers")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Manager name is required")]
        [Display(Name = "Manager Name")]
        [RegularExpression(@"^[A-Za-z\s]+$", ErrorMessage = "Name can only contain letters and spaces")]
        public string MgrName { get; set; }

        public ICollection<Course> Courses { get; set; } = new List<Course>();
        public ICollection<Student> Students { get; set; } = new List<Student>();
        public ICollection<Teacher> Teachers { get; set; } = new List<Teacher>();
    }
}