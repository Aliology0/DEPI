using Company_System.Models;
using Company_System.Repositories.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Company_System.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly IDepartmentRepository _departmentRepo;

        public DepartmentController(IDepartmentRepository departmentRepo)
        {
            _departmentRepo = departmentRepo;
        }

        // GET: /Department
        public IActionResult ShowAll()
        {
            var departments = _departmentRepo.GetAll();
            return View(departments);
        }

        // GET: /Department/Details/5
        public IActionResult GetById(int id)
        {
            var department = _departmentRepo.GetById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        // GET: /Department/Add
        public IActionResult Add()
        {
            return View();
        }

        // POST: /Department/Add
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Add(Department department)
        {
            if (!ModelState.IsValid)
                return View(department);

            _departmentRepo.Add(department);
            _departmentRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Department/Edit/5
        public IActionResult Edit(int id)
        {
            var department = _departmentRepo.GetById(id);
            if (department == null)
                return NotFound();

            return View(department);
        }

        // POST: /Department/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Department department)
        {
            if (!ModelState.IsValid)
                return View(department);

            _departmentRepo.Update(department);
            _departmentRepo.Save();
            return RedirectToAction(nameof(Index));
        }

        // GET: /Department/Delete/5
        public IActionResult Delete(int id)
        {
            var department = _departmentRepo.GetById(id);
            if (department == null)
                return NotFound();

            _departmentRepo.Delete(id);
            _departmentRepo.Save();
            return RedirectToAction(nameof(Index));
        }
    }
}
