using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Models
{
    internal class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }

        // Foreign Key
        public int? AuthorId { get; set; }
        // Navigation property
        public Author Author { get; set; } = null;
        public ICollection<Loan> Loans { get; set; } = new List<Loan>();
        public Book() { }
    }
}
