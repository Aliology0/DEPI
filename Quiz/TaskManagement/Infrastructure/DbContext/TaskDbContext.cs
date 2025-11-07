using Core.Models;
using Microsoft.EntityFrameworkCore;

namespace TaskManagement.Infrastructure
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
        {
        }

        public TaskDbContext(DbContextOptions<TaskDbContext> options)
            : base(options)
        {
        }

        public DbSet<TaskItem> Tasks { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=TaskQuiz;Trusted_Connection=True;");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<TaskItem>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Title).IsRequired().HasMaxLength(100);
                entity.Property(e => e.Description).HasMaxLength(500);
                entity.Property(e => e.IsCompleted).HasDefaultValue(false);
                entity.Property(e => e.CreatedAt).IsRequired().HasDefaultValueSql("GETUTCDATE()");
                entity.Property(e => e.DueDate).IsRequired(false);
            });
        }
    }
}
