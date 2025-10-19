using System.Collections.Generic;
using System.Linq;
using Company_System.Data;
using Company_System.Models;
using Company_System.Repositories.Interfaces;

namespace Company_System.Repositories.Implementations
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly CompanyDbContext _context;

        public DepartmentRepository(CompanyDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Department> GetAll() => _context.Departments.ToList();

        public Department GetById(int id) => _context.Departments.Find(id);

        public void Add(Department department)
        {
            _context.Departments.Add(department);
        }

        public void Update(Department department)
        {
            _context.Departments.Update(department);
        }

        public void Delete(int id)
        {
            var department = _context.Departments.Find(id);
            if (department != null)
                _context.Departments.Remove(department);
        }

        public void Save()
        {
            _context.SaveChanges();
        }
    }
}
