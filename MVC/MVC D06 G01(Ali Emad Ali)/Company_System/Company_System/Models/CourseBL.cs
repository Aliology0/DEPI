using Company_System.Data;
using Microsoft.EntityFrameworkCore;

namespace Company_System.Models
{
    public class CourseBL
    {
        CompanyDbContext context = new CompanyDbContext();

        // Get all
        public List<Course> GetAll()
        {
            return context.Courses.Include(c => c.Department)
                                  .ToList();
        }

        // Get by id
        public Course GetById(int id)
        {
            return context.Courses.Include(c => c.Department)
                                  .FirstOrDefault(c => c.Id == id);
        }

        // Add
        public void Add(Course course)
        {
            context.Courses.Add(course);
            context.SaveChanges();
        }

        // Update
        public void Update(Course course)
        {
            context.Courses.Update(course);
            context.SaveChanges();
        }

        // Delete
        public void Delete(Course course)
        {
            context.Courses.Remove(course);
            context.SaveChanges();
        }
    }
}
