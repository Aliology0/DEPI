using System.Collections.Generic;
using System.Linq;
using Company_System.Data;
using Company_System.Models;
using Company_System.Repositories.Interfaces;

namespace Company_System.Repositories.Implementations
{
    public class StudentCourseRepository : IStudentCourseRepository
    {
        private readonly CompanyDbContext _context;

        public StudentCourseRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<StudentCourses> GetAll() => _context.StudentCourses.ToList();

        public StudentCourses GetById(int id) => _context.StudentCourses.Find(id);

        public void Add(StudentCourses studentCourse)
        {
            _context.StudentCourses.Add(studentCourse);
        }

        public void Update(StudentCourses studentCourse)
        {
            _context.StudentCourses.Update(studentCourse);
        }

        public void Delete(int id)
        {
            var record = _context.StudentCourses.Find(id);
            if (record != null)
                _context.StudentCourses.Remove(record);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
