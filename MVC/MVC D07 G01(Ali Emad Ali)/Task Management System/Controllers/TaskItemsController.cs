using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskManagement.Core.Interfaces;
using TaskManagement.Core.Models;
using Microsoft.AspNetCore.Mvc;




namespace TaskManagement.Controllers
{
    public class TaskItemsController : Controller
    {
        ITaskRepository _context;
        public TaskItemsController(ITaskRepository taskRepository)
        {
            _context = taskRepository;
        }

        // GET: Taskitems
        public IActionResult Index()
        {
            return View(_context.GetAll());
        }

        // GET: Taskitems/Details/5
        public IActionResult Details(int id)
        {
            var taskitem = _context.GetById(id);
            if (taskitem == null)
            {
                return NotFound();
            }

            return View(taskitem);
        }

        // GET: Taskitems/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Taskitems/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Title,Description,IsCompleted,CreatedAt")] TaskItem taskitem)
        {
            if (ModelState.IsValid)
            {
                _context.Add(taskitem);
                return RedirectToAction(nameof(Index));
            }
            return View(taskitem);
        }

        // GET: Taskitems/Edit/5
        public IActionResult Edit(int id)
        {
            var taskitem = _context.GetById(id);
            if (taskitem == null)
            {
                return NotFound();
            }
            return View(taskitem);
        }

        // POST: Taskitems/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("Id,Title,Description,IsCompleted,CreatedAt")] TaskItem taskitem)
        {
            if (id != taskitem.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {

                _context.Update(taskitem);

                return RedirectToAction(nameof(Index));
            }
            return View(taskitem);
        }

        // GET: Taskitems/Delete/5
        public IActionResult Delete(int id)
        {

            var taskitem = _context.GetById(id);
            if (taskitem == null)
            {
                return NotFound();
            }

            return View(taskitem);
        }

        // POST: Taskitems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            var taskitem = _context.GetById(id);
            if (taskitem != null)
            {
                _context.Delete(taskitem.Id);
            }
            return RedirectToAction(nameof(Index));
        }
    }
}
