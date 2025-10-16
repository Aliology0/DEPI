using Company_System.Models;
using System.Collections.Generic;

namespace Company_System.Repositories.Interfaces
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        void Update(Course course);
        void Delete(int id);
        void Save();
    }
}
