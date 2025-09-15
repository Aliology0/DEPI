using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2.Models
{
    internal class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; } = DateTime.Now;

        public ICollection<Book> Books { get; set; } = new List<Book>();

        public Author() { }
    }
}
