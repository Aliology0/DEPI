using Company_System.Models;
using Company_System.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company_System.Controllers
{
    public class CourseController : Controller
    {
        private readonly ICourseRepository _courseRepo;

        public CourseController(ICourseRepository courseRepo)
        {
            _courseRepo = courseRepo;
        }

        // GET: /Course
        public IActionResult Index()
        {
            var courses = _courseRepo.GetAll();
            return View(courses);
        }

        // GET: /Course/Details/5
        public IActionResult ShowDegree(int id)
        {
            var course = _courseRepo.GetById(id);
            if (course == null)
                return NotFound();

            return View(course);
        }

        // GET: /Course/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Course/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Course course)
        {
            if (!ModelState.IsValid)
                return View(course);

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

            return View(course);
        }

        // POST: /Course/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Course course)
        {
            if (!ModelState.IsValid)
                return View(course);

            _courseRepo.Update(course);
            _courseRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Course/Delete/5
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
