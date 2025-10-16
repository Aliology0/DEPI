using Company_System.Models;
using Company_System.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company_System.Controllers
{
    public class StudentController : Controller
    {
        private readonly IStudentRepository _studentRepo;

        public StudentController(IStudentRepository studentRepo)
        {
            _studentRepo = studentRepo;
        }

        // GET: /Student
        public IActionResult ShowAll()
        {
            var students = _studentRepo.GetAll();
            return View(students);
        }

        // GET: /Student/Details/5
        public IActionResult GetById(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // GET: /Student/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Student/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            _studentRepo.Add(student);
            _studentRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Student/Edit/5
        public IActionResult Edit(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null)
                return NotFound();

            return View(student);
        }

        // POST: /Student/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
                return View(student);

            _studentRepo.Update(student);
            _studentRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Student/Delete/5
        public IActionResult Delete(int id)
        {
            var student = _studentRepo.GetById(id);
            if (student == null)
                return NotFound();

            _studentRepo.Delete(id);
            _studentRepo.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
