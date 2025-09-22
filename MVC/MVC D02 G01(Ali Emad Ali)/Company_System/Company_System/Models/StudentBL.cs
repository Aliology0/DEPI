using Company_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Company_System.Models
{
    public class StudentBL
    {

        private readonly CompanyDbContext context;

        public StudentBL(CompanyDbContext context)
        {
            this.context = context;
        }

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
    }
}
