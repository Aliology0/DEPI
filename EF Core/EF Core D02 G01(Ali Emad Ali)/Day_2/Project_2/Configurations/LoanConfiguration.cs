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
    internal class LoanConfiguration : IEntityTypeConfiguration<Loan>
    {
        public void Configure(EntityTypeBuilder<Loan> builder)
        {
            builder.HasKey(l => new { l.BookId, l.BorrowerId });

            builder.HasOne(l => l.Book)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(l => l.BookId);

            builder.HasOne(l => l.Borrower)
                   .WithMany(b => b.Loans)
                   .HasForeignKey(l => l.BorrowerId);
        }
    }
}
