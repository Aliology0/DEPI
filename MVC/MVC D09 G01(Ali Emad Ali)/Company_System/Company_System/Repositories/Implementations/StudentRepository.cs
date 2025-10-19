using System.Collections.Generic;
using System.Linq;
using Company_System.Data;
using Company_System.Models;
using Company_System.Repositories.Interfaces;

namespace Company_System.Repositories.Implementations
{
    public class StudentRepository : IStudentRepository
    {
        private readonly CompanyDbContext _context;

        public StudentRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAll() => _context.Students.ToList();

        public Student GetById(int id) => _context.Students.Find(id);

        public void Add(Student student)
        {
            _context.Students.Add(student);
        }

        public void Update(Student student)
        {
            _context.Students.Update(student);
        }

        public void Delete(int id)
        {
            var student = _context.Students.Find(id);
            if (student != null)
                _context.Students.Remove(student);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
