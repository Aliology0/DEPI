using System;
using System.ComponentModel.DataAnnotations;

namespace TaskManagement.Core.Models
{
    public class TaskItem
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; }

        [MaxLength(500)]
        public string Description { get; set; } = string.Empty;

        public bool IsCompleted { get; set; }

        public DateTime CreatedAt { get; set; }

        public DateTime? DueDate { get; set; }

        public TaskItem()
        {
            CreatedAt = DateTime.UtcNow;
        }
    }
}
