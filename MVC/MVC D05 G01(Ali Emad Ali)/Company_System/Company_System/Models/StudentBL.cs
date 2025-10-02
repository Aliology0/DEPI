using Company_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Company_System.Models
{
    public class StudentBL
    {

        private readonly CompanyDbContext context = new CompanyDbContext();

        public Student GetById(int id)
        {
            return context.Students
                          .Include(s => s.Department)
                          .FirstOrDefault(e => e.Id == id);
        }

        public List<Student> GetAll()
        {
            return context.Students
                          .Include(s => s.Department)
                          .ToList();
        }

        public void AddStudent(Student student)
        {
            context.Students.Add(student);
            context.SaveChanges();
        }
        public void EditStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }
        public void DeleteStudent(Student student)
        {
            context.Students.Remove(student);
            context.SaveChanges();
        }
    }
}
