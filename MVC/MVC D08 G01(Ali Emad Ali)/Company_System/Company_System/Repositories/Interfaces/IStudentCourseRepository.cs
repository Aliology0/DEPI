using System.Collections.Generic;
using Company_System.Models;

namespace Company_System.Repositories.Interfaces
{
    public interface IStudentCourseRepository
    {
        IEnumerable<StudentCourses> GetAll();
        StudentCourses GetById(int id);
        void Add(StudentCourses studentCourse);
        void Update(StudentCourses studentCourse);
        void Delete(int id);
        void Save();
    }
}
