using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Models
{
    internal class Loan
    {
        public DateTime LoanDate { get; set; } = DateTime.Now;
        public DateTime ReturnDate { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
        public int BorrowerId { get; set; }
        public Borrower Borrower { get; set; }
    }
}
