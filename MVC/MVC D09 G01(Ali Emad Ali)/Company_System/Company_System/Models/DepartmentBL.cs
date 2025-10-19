using Microsoft.EntityFrameworkCore;
using Company_System.Data;
using Company_System.Models;

namespace Company_System.Models
{
    public class DepartmentBL
    {

        private readonly CompanyDbContext _context;

        public DepartmentBL(CompanyDbContext context)
        {
            _context = context;
        }


        // 1- Get All Departments
        public List<Department> GetAll()
        {
            return _context.Departments.Include(D => D.Students).ToList();
        }

        // 2- Add Department
        public void AddDept(Department Dept)
        {
            // Add to local
            _context.Add(Dept);
            // Add to Database
            _context.SaveChanges();
        }

        // 3- Delete Department
        public void DeleteDept(Department Dept)
        {
            // Delete to local
            _context.Remove(Dept);
            // Delete to Database
            _context.SaveChanges();
        }
        public void EditDept(Department Dept)
        {
            // Edit to local
            _context.Update(Dept);
            // Edit to Database
            _context.SaveChanges();
        }

        // 4- Get Department By Id
        public Department? GetById(int id)
        {
            return _context.Departments.Include(s => s.Students)
                                      .FirstOrDefault(d => d.Id == id);
        }
    }
}
