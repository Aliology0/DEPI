using Microsoft.EntityFrameworkCore;
using Project_2.Models;
using Project_2.Configurations;

internal class LibraryDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=LocalHost\\SQLEXPRESS;Database=LibraryDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    #region DbSets
    public DbSet<Book> Books { get; set; }
    public DbSet<Author> Authors { get; set; }
    public DbSet<Borrower> Borrowers { get; set; }
    public DbSet<Loan> Loans { get; set; }
    #endregion

    public LibraryDbContext() { }
    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Apply configurations
        builder.ApplyConfigurationsFromAssembly(typeof(LibraryDbContext).Assembly);
    }
}