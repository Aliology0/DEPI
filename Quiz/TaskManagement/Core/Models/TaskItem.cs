using System.ComponentModel.DataAnnotations;

namespace Core.Models
{
    public class TaskItem
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Title { get; set; } = null!;

        [MaxLength(500)]
        public string? Description { get; set; }
        public bool IsCompleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime? DueDate { get; set; } = DateTime.Today;
    }
}
