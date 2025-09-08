using Day_1.Models;
using Microsoft.EntityFrameworkCore;
using Day_1.Configurations;

internal class ProjectDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer("Server=DESKTOP-T6DIIT0\\SQLEXPRESS;Database=ProjectDB;Trusted_Connection=True;");
    }

    public DbSet<Project> Projects { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new ProjectConfiguration());

        base.OnModelCreating(modelBuilder);
    }
}