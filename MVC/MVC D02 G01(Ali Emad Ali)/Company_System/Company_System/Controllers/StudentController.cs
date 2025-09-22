using Company_System.Data;
using Company_System.Models;
using Microsoft.AspNetCore.Mvc;

namespace Company_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly CompanyDbContext _context;

        public StudentController(CompanyDbContext context)
        {
            _context = context;
        }

        // /Student/ShowAll
        public IActionResult ShowAll()
        {
            var studentBL = new StudentBL(_context);
            List<Student> studentList = studentBL.GetAll();
            return View(studentList);
        }

        // /Student/ShowDetails
        public IActionResult ShowDetails(int id)
        {
            StudentBL studentBL = new StudentBL(_context);
            Student student = studentBL.GetById(id);

            if (student == null)
                return NotFound();


            return View("GetById", student);
        }
    }
}