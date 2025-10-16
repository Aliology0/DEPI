using System.Collections.Generic;
using TaskManagement.Core.Models;

namespace TaskManagement.Core.Interfaces
{
    public interface ITaskRepository
    {
        IEnumerable<TaskItem> GetAll();
        TaskItem GetById(int id);
        TaskItem Add(TaskItem task);
        void Update(TaskItem task);
        void Delete(int id);

        IEnumerable<TaskItem> GetByCompletion(bool isCompleted);
        IEnumerable<TaskItem> GetSortedByDueDate(bool ascending);
    }
}
