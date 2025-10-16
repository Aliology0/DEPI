using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Core.Interfaces;
using TaskManagement.Core.Models;
using TaskManagement.Infrastructure.Data;

namespace TaskManagement.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _context;

        public TaskRepository(TaskDbContext context)
        {
            _context = context;
        }

        public IEnumerable<TaskItem> GetAll()
        {
            return _context.Tasks.ToList();
        }

        public TaskItem GetById(int id)
        {
            return _context.Tasks.FirstOrDefault(t => t.Id == id);
        }

        public TaskItem Add(TaskItem task)
        {
            var entry = _context.Tasks.Add(task);
            _context.SaveChanges();
            return entry.Entity;
        }

        public void Update(TaskItem task)
        {
            var existing = _context.Tasks.Find(task.Id);
            if (existing == null) return;

            existing.Title = task.Title;
            existing.Description = task.Description;
            existing.IsCompleted = task.IsCompleted;
            existing.DueDate = task.DueDate;

            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var existing = _context.Tasks.Find(id);
            if (existing == null) return;

            _context.Tasks.Remove(existing);
            _context.SaveChanges();
        }

        public IEnumerable<TaskItem> GetByCompletion(bool isCompleted)
        {
            return _context.Tasks.Where(t => t.IsCompleted == isCompleted).ToList();
        }

        public IEnumerable<TaskItem> GetSortedByDueDate(bool ascending)
        {
            var q = _context.Tasks.Where(t => t.DueDate.HasValue);
            q = ascending ? q.OrderBy(t => t.DueDate) : q.OrderByDescending(t => t.DueDate);
            return q.ToList();
        }
    }
}
