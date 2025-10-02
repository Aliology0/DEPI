using Company_System.Models;
using Microsoft.AspNetCore.Mvc;
using Company_System.ViewModel;

namespace Company_System.Controllers
{
    public class DepartmentController : Controller
    {
        private StudentBL studentBL = new StudentBL();
        private DepartmentBL departmentBL = new DepartmentBL();

        // /Department/ShowAll
        public IActionResult ShowAll()
        {
            var departments = departmentBL.GetAll();
            return View(departments);
        }

        // GET: Department/ShowDetailsById
        public IActionResult ShowDetailsById(int id)
        {
            var department = departmentBL.GetById(id);
            if (department == null)
                return NotFound();

            var studentsAbove25 = department.Students
                                            .Where(s => s.Age > 25)
                                            .ToList();

            var state = department.Students.Count > 50 ? "Main" : "Branch";

            var departmentVM = new DepartmentViewModel
            {
                DepartmentName = department.Name,
                StudentsAbove25 = studentsAbove25,
                DepartmentState = state
            };

            return View(departmentVM);
        }

        #region Add Department
        // GET: /Department/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Department/Add
        [HttpPost]
        public IActionResult Add(Department department)
        {
            if (!ModelState.IsValid)
            {
                return View(department);
            }

            departmentBL.AddDept(department);
            return RedirectToAction("ShowAll");
        }
        #endregion

        #region Edit Department (Unfinished)
        // GET: /Department/Edit
        public IActionResult Edit()
        {
            return View();
        }

        // POST: /Department/Edit
        [HttpPost]
        public IActionResult Edit(Department department)
        {
            if (!ModelState.IsValid)
            {
                return View(department);
            }

            departmentBL.EditDept(department);
            return RedirectToAction("ShowAll");
        }
        #endregion

        #region Delete (Unfinished)
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var dept = departmentBL.GetById(id);
            if (dept == null)
                return NotFound();

            departmentBL.DeleteDept(dept);
            return RedirectToAction("ShowAll");
            //return View("ConfirmDelete", dept);
        }
        #endregion

        #region Delete Confirmation (Unfinished)
        [HttpPost]
        public IActionResult ConfirmDelete(int id)
        {
            var dept = departmentBL.GetById(id);

            if (dept == null)
                return NotFound();

            departmentBL.DeleteDept(dept);
            return RedirectToAction("ShowAll");
        }
        #endregion

        #region Add Student to Department (Unfinished)
        public IActionResult AddStudent(int id)
        {
            var dept = departmentBL.GetById(id);
            if (dept == null)
                return NotFound();

            ViewBag.DepartmentId = id;
            return View();
        }


        // POST: Department/AddStudent
        [HttpPost]
        public IActionResult AddStudent(Student student, int departmentId)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.DepartmentId = departmentId;
                return View(student);
            }

            student.DepartmentId = departmentId;
            studentBL.AddStudent(student);

            return RedirectToAction("ShowAll");
        }
        #endregion
    }
}

