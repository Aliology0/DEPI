using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    internal class Category
    {
        #region Attributes
        private int id;
        private string name;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        // Navigation property (One-to-Many)
        public ICollection<Product> Products { get; set; } = new List<Product>();
        #endregion

        #region Constructors
        public Category() { }
        public Category(string _name)
        {
            name = _name;
        }

        #endregion
    }
}
