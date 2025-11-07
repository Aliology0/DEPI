using Core.Models;
using Microsoft.EntityFrameworkCore;
using TaskManagement.Core.Interfaces;

namespace TaskManagement.Infrastructure.Repositories
{
    public class TaskRepository : ITaskRepository
    {
        private readonly TaskDbContext _db;

        public TaskRepository(TaskDbContext db) => _db = db;

        public async Task<TaskItem> CreateAsync(TaskItem task)
        {
            if (task == null)
                throw new ArgumentNullException(nameof(task));

            _db.Tasks.Add(task);
            await _db.SaveChangesAsync();
            return task;
        }

        public async Task<TaskItem?> GetByIdAsync(int id) =>
            await _db.Tasks.FindAsync(id);

        public async Task<IEnumerable<TaskItem>> GetAllAsync(bool? isCompleted = null, bool sortByDueDateAsc = true)
        {
            IQueryable<TaskItem> q = _db.Tasks.AsQueryable();

            if (isCompleted.HasValue)
                q = q.Where(t => t.IsCompleted == isCompleted.Value);

            q = sortByDueDateAsc ? q.OrderBy(t => t.DueDate) : q.OrderByDescending(t => t.DueDate);

            return await q.ToListAsync();
        }

        public async Task<TaskItem?> UpdateAsync(TaskItem task)
        {
            var existing = await _db.Tasks.FindAsync(task.Id);
            if (existing == null) return null;

            existing.Title = task.Title;
            existing.Description = task.Description;
            existing.IsCompleted = task.IsCompleted;
            existing.DueDate = task.DueDate;

            await _db.SaveChangesAsync();
            return existing;
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var existing = await _db.Tasks.FindAsync(id);
            if (existing == null) return false;

            _db.Tasks.Remove(existing);
            await _db.SaveChangesAsync();
            return true;
        }

        public async Task<bool> ExistsAsync(int id) =>
            await _db.Tasks.AnyAsync(t => t.Id == id);
    }
}
