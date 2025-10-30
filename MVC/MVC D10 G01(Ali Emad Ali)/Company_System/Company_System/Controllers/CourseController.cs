using Company_System.Models;
using Company_System.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Company_System.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepo;
        private readonly IDepartmentRepository _departmentRepo;

        public CourseController(ICourseRepository courseRepo, IDepartmentRepository departmentRepo)
        {
            _courseRepo = courseRepo;
            _departmentRepo = departmentRepo;
        }

        // GET: /Course
        public IActionResult Index()
        {
            var courses = _courseRepo.GetAll();
            return View(courses);
        }

        // GET: /Course/Details/5
        public IActionResult ShowDegree(int courseId, int studentId)
        {
            var course = _courseRepo.GetById(courseId);
            if (course == null)
                return NotFound();

            ViewBag.StudentId = studentId;
            return View(course);
        }

        // GET: /Course/Add
        public IActionResult Add()
        {
            ViewBag.Departments = new SelectList(_departmentRepo.GetAll(), "Id", "Name");
            return View();
        }

        // POST: /Course/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Course course)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(_departmentRepo.GetAll(), "Id", "Name");
                return View(course);
            }

            _courseRepo.Add(course);
            _courseRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Course/Edit/5
        public IActionResult Edit(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null)
                return NotFound();

            ViewBag.Departments = new SelectList(_departmentRepo.GetAll(), "Id", "Name", course.DepartmentId);
            return View(course);
        }

        // POST: /Course/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Course course)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(_departmentRepo.GetAll(), "Id", "Name", course.DepartmentId);
                return View(course);
            }

            _courseRepo.Update(course);
            _courseRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // POST: /Course/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null)
                return NotFound();

            _courseRepo.Delete(id);
            _courseRepo.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
