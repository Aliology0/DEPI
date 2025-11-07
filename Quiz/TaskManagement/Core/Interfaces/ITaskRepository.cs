using Core.Models;

namespace TaskManagement.Core.Interfaces
{
    public interface ITaskRepository
    {
        Task<TaskItem> CreateAsync(TaskItem task);
        Task<TaskItem?> GetByIdAsync(int id);
        Task<IEnumerable<TaskItem>> GetAllAsync(bool? isCompleted = null, bool sortByDueDateAsc = true);
        Task<TaskItem?> UpdateAsync(TaskItem task);
        Task<bool> DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}
