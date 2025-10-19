using Company_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Company_System.Models
{
    public class StudentBL
    {

        private readonly CompanyDbContext _context;

        public StudentBL(CompanyDbContext context)
        {
            _context = context;
        }

        public Student GetById(int id)
        {
            return _context.Students
                          .Include(s => s.Department)
                          .FirstOrDefault(e => e.Id == id);
        }

        public List<Student> GetAll()
        {
            return _context.Students
                          .Include(s => s.Department)
                          .ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
        public void EditStudent(Student student)
        {
            _context.Students.Update(student);
            _context.SaveChanges();
        }
        public void DeleteStudent(Student student)
        {
            _context.Students.Remove(student);
            _context.SaveChanges();
        }
    }
}
