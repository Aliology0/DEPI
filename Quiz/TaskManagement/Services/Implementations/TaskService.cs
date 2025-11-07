using Core.Models;
using TaskManagement.Core.Interfaces;
using TaskManagement.Service.Interfaces;

namespace TaskManagement.Service.Implementations
{
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository _repo;

        public TaskService(ITaskRepository repo)
        {
            _repo = repo;
        }

        public async Task<IEnumerable<TaskItem>> GetAllAsync(bool? isCompleted = null, bool sortByDueDateAsc = true)
        {
            return await _repo.GetAllAsync(isCompleted, sortByDueDateAsc);
        }

        public async Task<TaskItem?> GetByIdAsync(int id)
        {
            return await _repo.GetByIdAsync(id);
        }

        public async Task<TaskItem> CreateAsync(TaskItem task)
        {
            if (task.DueDate.HasValue && task.DueDate.Value < DateTime.UtcNow)
                throw new ArgumentException("Due date must be in the future.");

            return await _repo.CreateAsync(task);
        }

        public async Task<TaskItem?> UpdateAsync(TaskItem task)
        {
            if (task.DueDate.HasValue && task.DueDate.Value < DateTime.UtcNow)
                throw new ArgumentException("Due date must be in the future.");

            var exists = await _repo.ExistsAsync(task.Id);
            if (!exists) return null;

            return await _repo.UpdateAsync(task);
        }

        public async Task<bool> DeleteAsync(int id)
        {
            var exists = await _repo.ExistsAsync(id);
            if (!exists) return false;

            return await _repo.DeleteAsync(id);
        }
    }
}
