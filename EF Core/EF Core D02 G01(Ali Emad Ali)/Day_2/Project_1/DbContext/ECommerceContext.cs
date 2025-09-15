using Microsoft.EntityFrameworkCore;
using Project_1.Models;
using Project_1.Configurations;

internal class ECommerceDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=LocalHost\\SQLEXPRESS;Database=ECommerceDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    #region DbSets
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<OrderDetails> OrderDetails { get; set; }
    #endregion

    public ECommerceDbContext() { }
    public ECommerceDbContext(DbContextOptions<ECommerceDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Apply configurations
        builder.ApplyConfigurationsFromAssembly(typeof(ECommerceDbContext).Assembly);
    }
}