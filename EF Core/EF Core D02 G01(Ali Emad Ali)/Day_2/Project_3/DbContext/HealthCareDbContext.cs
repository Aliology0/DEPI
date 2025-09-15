using Microsoft.EntityFrameworkCore;
using Project_3.Models;
using Project_3.Configurations;

internal class HealthCareDbContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                "Server=LocalHost\\SQLEXPRESS;Database=HealthCareDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }

    #region DbSets
    public DbSet<Patient> Patients { get; set; }
    public DbSet<Doctor> Doctors { get; set; }
    public DbSet<Appointment> Appointments { get; set; }
    #endregion

    public HealthCareDbContext() { }
    public HealthCareDbContext(DbContextOptions<HealthCareDbContext> options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Apply configurations
        builder.ApplyConfigurationsFromAssembly(typeof(HealthCareDbContext).Assembly);
    }
}