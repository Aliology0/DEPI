using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace TaskManagement.Infrastructure.Data
{
    public class TaskDbContextFactory : IDesignTimeDbContextFactory<TaskDbContext>
    {
        public TaskDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<TaskDbContext>();
            // use the same connection string you run with
            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;Database=TaskManagementDB;Trusted_Connection=True;Encrypt=False;MultipleActiveResultSets=true");

            return new TaskDbContext(optionsBuilder.Options);
        }
    }
}
