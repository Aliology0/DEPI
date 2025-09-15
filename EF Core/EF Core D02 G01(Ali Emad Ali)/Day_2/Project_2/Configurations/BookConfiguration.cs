using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_2.Models;

namespace Project_2.Configurations
{
    internal class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(c => c.Id);

            builder.Property(c => c.Title)
                   .IsRequired()
                   .HasColumnType("varchar(200)");

            builder.Property(c => c.ISBN)
                   .IsRequired()
                   .HasColumnType("varchar(100)");

            builder.HasOne(a => a.Author)
                   .WithMany(b => b.Books)
                   .HasForeignKey(b => b.AuthorId);
        }
    }
}
