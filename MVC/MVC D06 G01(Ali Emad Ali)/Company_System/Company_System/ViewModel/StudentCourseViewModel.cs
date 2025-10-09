namespace Company_System.ViewModel
{
    public class StudentCourseViewModel
    {

        public string StudentName { get; set; }
        public string CourseName { get; set; }
        public decimal Degree { get; set; }
        public decimal MinDegree { get; set; }

        public string Color => Degree >= 50 ? "green" : "red";
    }
}
