using Day01.Models;
using Microsoft.EntityFrameworkCore;

namespace Day01.Models
{
    public class CourseContext : DbContext
    {
        public CourseContext(DbContextOptions<CourseContext> options) : base(options) { }

        public DbSet<Course> Courses { get; set; }
    }
}
