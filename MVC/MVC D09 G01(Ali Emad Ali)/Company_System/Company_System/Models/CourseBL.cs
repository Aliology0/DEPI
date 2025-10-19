using Company_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Company_System.Models
{
    public class CourseBL
    {
        private readonly CompanyDbContext _context;
        public CourseBL(CompanyDbContext context)
        {
            _context = context;
        }

        // Get all
        public List<Course> GetAll()
        {
            return _context.Courses.Include(c => c.Department)
                                  .ToList();
        }

        // Get by id
        public Course GetById(int id)
        {
            return _context.Courses.Include(c => c.Department)
                                  .FirstOrDefault(c => c.Id == id);
        }

        // Add
        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        // Update
        public void Update(Course course)
        {
            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        // Delete
        public void Delete(Course course)
        {
            _context.Courses.Remove(course);
            _context.SaveChanges();
        }
    }
}
