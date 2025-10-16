using System.Collections.Generic;
using System.Linq;
using Company_System.Data;
using Company_System.Models;
using Company_System.Repositories.Interfaces;

namespace Company_System.Repositories.Implementations
{
    public class CourseRepository : ICourseRepository
    {
        private readonly CompanyDbContext _context;

        public CourseRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAll() => _context.Courses.ToList();

        public Course GetById(int id) => _context.Courses.Find(id);

        public void Add(Course course)
        {
            _context.Courses.Add(course);
        }

        public void Update(Course course)
        {
            _context.Courses.Update(course);
        }

        public void Delete(int id)
        {
            var course = _context.Courses.Find(id);
            if (course != null)
                _context.Courses.Remove(course);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
