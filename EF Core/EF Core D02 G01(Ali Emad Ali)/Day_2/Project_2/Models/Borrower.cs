using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Models
{
    internal class Borrower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime MembershipDate { get; set; } = DateTime.Now;

        //Navigation property
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
    }
}
