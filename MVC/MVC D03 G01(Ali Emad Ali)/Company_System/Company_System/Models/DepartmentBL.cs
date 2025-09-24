using Microsoft.EntityFrameworkCore;
using Company_System.Data;
using Company_System.Models;

namespace Company_System.Models
{
    public class DepartmentBL
    {

        private readonly CompanyDbContext context;
        public DepartmentBL(CompanyDbContext context)
        {
            this.context = context;
        }

        // 1- Get All Departments
        public List<Department> GetAll()
        {
            return context.Departments.Include(D => D.Students).ToList();
        }

        // 2- Add Department
        public void AddDept(Department Dept)
        {
            // Add to local
            context.Add(Dept);
            // Add to Database
            context.SaveChanges();
        }

        // 3- Delete Department
        public void DeleteDept(Department Dept)
        {
            // Delete to local
            context.Remove(Dept);
            // Delete to Database
            context.SaveChanges();
        }

        // 4- Get Department By Id
        public Department? GetById(int id)
        {
            return context.Departments.Include(s => s.Students)
                                      .FirstOrDefault(d => d.Id == id);
        }
    }
}
