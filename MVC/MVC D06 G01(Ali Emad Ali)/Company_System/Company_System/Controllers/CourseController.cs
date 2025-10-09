using Company_System.Data;
using Company_System.Models;
using Company_System.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace Company_System.Controllers
{
    public class CourseController : Controller
    {
        CourseBL courseBL = new CourseBL();
        CompanyDbContext context = new CompanyDbContext();

        // Show All
        public IActionResult Index()
        {
            var courses = courseBL.GetAll();
            return View(courses);
        }

        // GET: Add
        public IActionResult Add()
        {
            ViewBag.Departments = new SelectList(context.Departments, "Id", "Name");
            return View();
        }

        // POST: Add
        [HttpPost]
        public IActionResult Add(Course course)
        {
            if (ModelState.IsValid)
            {
                courseBL.Add(course);
                return RedirectToAction("Index");
            }

            ViewBag.Departments = new SelectList(context.Departments, "Id", "Name");
            return View(course);
        }

        // GET: Edit
        public IActionResult Edit(int id)
        {
            var course = courseBL.GetById(id);
            if (course == null)
                return NotFound();

            ViewBag.Departments = new SelectList(context.Departments, "Id", "Name", course.DepartmentId);
            return View(course);
        }

        // POST: Edit
        [HttpPost]
        public IActionResult Edit(Course course)
        {
            if (ModelState.IsValid)
            {
                courseBL.Update(course);
                return RedirectToAction("Index");
            }

            ViewBag.Departments = new SelectList(context.Departments, "Id", "Name", course.DepartmentId);
            return View(course);
        }

        // Details
        public IActionResult Details(int id)
        {
            var course = courseBL.GetById(id);
            if (course == null)
                return NotFound();

            return View(course);
        }

        // Delete
        public IActionResult Delete(int id)
        {
            var course = courseBL.GetById(id);
            if (course == null)
                return NotFound();

            courseBL.Delete(course);
            return RedirectToAction("Index");
        }

        public IActionResult ShowDegree(int studentId, int courseId)
        {
            var record = context.StudentCourses
                .Include(sc => sc.Student)
                .Include(sc => sc.Course)
                .FirstOrDefault(sc => sc.StudentId == studentId && sc.CourseId == courseId);

            if (record == null)
                return NotFound();

            var viewModel = new StudentCourseViewModel
            {
                StudentName = record.Student.Name,
                CourseName = record.Course.Name,
                Degree = record.Grade,
                MinDegree = record.Course.MinDegree
            };

            return View(viewModel);
        }

    }
}
