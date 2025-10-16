using System.Collections.Generic;
using TaskManagement.Services;
using TaskManagement.Core.Models;
using TaskManagement.Core.Interfaces;

namespace TaskManagement.Services
{
    public class TaskService
    {
        private readonly ITaskRepository _context;

        public TaskService(ITaskRepository repo)
        {
            _context = repo;
        }

        public IEnumerable<TaskItem> GetAll() => _context.GetAll();

        public TaskItem GetById(int id) => _context.GetById(id);

        public TaskItem Create(TaskItem t) => _context.Add(t);

        public void Update(TaskItem t) => _context.Update(t);

        public void Delete(int id) => _context.Delete(id);

        public IEnumerable<TaskItem> FilterByCompletion(bool isCompleted) => _context.GetByCompletion(isCompleted);

        public IEnumerable<TaskItem> SortByDueDate(bool ascending) => _context.GetSortedByDueDate(ascending);
    }
}
