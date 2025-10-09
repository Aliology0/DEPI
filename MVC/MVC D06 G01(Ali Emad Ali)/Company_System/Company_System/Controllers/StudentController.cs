using Company_System.Data;
using Company_System.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Company_System.Controllers
{
    public class StudentController : Controller
    {
        StudentBL studentBL = new StudentBL();
        DepartmentBL departmentBL = new DepartmentBL();

        // /Student/ShowAll
        public IActionResult ShowAll()
        {
            List<Student> studentList = studentBL.GetAll();
            return View(studentList);
        }

        // /Student/ShowDetails
        public IActionResult ShowDetails(int id)
        {
            Student student = studentBL.GetById(id);

            if (student == null)
                return NotFound();

            return View("GetByID", student);
        }

        #region Add Student
        // GET: Student/Add
        public IActionResult Add()
        {
            ViewBag.Departments = new SelectList(departmentBL.GetAll(), "Id", "Name");
            return View();
        }

        // POST: Student/Add
        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(departmentBL.GetAll(), "Id", "Name", student.DepartmentId);
                return View(student);
            }

            studentBL.AddStudent(student);
            return RedirectToAction("ShowAll");
        }
        #endregion

        #region Edit Student
        // GET: Student/Edit/13
        public IActionResult Edit(int id)
        {
            var student = studentBL.GetById(id);
            if (student == null)
                return NotFound();

            ViewBag.Departments = new SelectList(departmentBL.GetAll(), "Id", "Name", student.DepartmentId);
            return View(student);
        }

        // POST: Student/Edit
        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Departments = new SelectList(departmentBL.GetAll(), "Id", "Name", student.DepartmentId);
                return View(student);
            }

            studentBL.EditStudent(student);
            return RedirectToAction("ShowAll");
        }
        #endregion

        #region Delete Student
        // GET: Student/Delete
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var student = studentBL.GetById(id);
            if (student == null)
                return NotFound();

            return View("ConfirmDelete", student);
        }

        // POST: Student/ConfirmDelete
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            var student = studentBL.GetById(id);
            if (student == null)
                return NotFound();

            studentBL.DeleteStudent(student);
            return RedirectToAction("ShowAll");
        }
        #endregion
    }
}