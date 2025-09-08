using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Day_1.Models;

namespace Day_1.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects");

            builder.HasKey(p => p.Id);

            builder.Property(p => p.Id)
                   .UseIdentityColumn(seed: 10, increment: 10);

            builder.Property(p => p.Name)
                   .HasColumnType("nvarchar(50)")
                   .HasDefaultValue("OurProject")
                   .IsRequired();

            builder.Property(p => p.Cost)
                   .HasColumnType("money");
            builder.HasCheckConstraint("CK_Project_Cost_Range", "[Cost] BETWEEN 500000 AND 3500000");
        }
    }
}
