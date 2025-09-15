using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    internal class Customer
    {
        #region Attributes
        private int id;
        private string name;
        private string email = "Unknown";
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

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        // Navigation property (One-to-Many)
        public ICollection<Order> Orders { get; set; } = new List<Order>();
        #endregion

        #region Constructors
        public Customer() { }
        public Customer(string _name, string _email)
        {
            name = _name;
            email = _email;
        }
        #endregion
    }
}
