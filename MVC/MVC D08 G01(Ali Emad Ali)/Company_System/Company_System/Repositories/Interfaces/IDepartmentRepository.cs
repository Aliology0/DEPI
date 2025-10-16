using System.Collections.Generic;
using Company_System.Models;

namespace Company_System.Repositories.Interfaces
{
    public interface IDepartmentRepository
    {
        IEnumerable<Department> GetAll();
        Department GetById(int id);
        void Add(Department department);
        void Update(Department department);
        void Delete(int id);
        void Save();
    }
}
