using Company_System.Models;

namespace Company_System.ViewModel
{
    public class DepartmentViewModel
    {
        public string DepartmentName { get; set; } = string.Empty;
        public List<Student> StudentsAbove25 { get; set; } = new List<Student>();
        public string DepartmentState { get; set; } = string.Empty;
    }
}
