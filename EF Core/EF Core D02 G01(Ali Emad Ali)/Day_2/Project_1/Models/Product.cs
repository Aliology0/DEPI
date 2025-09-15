using System.Collections.Generic;

namespace Project_1.Models
{

    internal class Product
    {
        #region Atrributes
        private int id;
        private string name;
        private decimal price;
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
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }

        public int? CategoryId { get; set; }

        // Navigation property (Many-to-One)
        public Category Category { get; set; }
        // Navigation property (Many-to-Many)
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
        #endregion

        public Product() { }
        public Product(string _name, decimal _price)
        {
            name = _name;
            price = _price;
        }



    }
}
