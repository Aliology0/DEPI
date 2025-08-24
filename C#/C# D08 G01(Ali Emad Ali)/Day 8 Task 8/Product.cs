using System;

namespace Day_8_Task_8
{
    class Product : IComparable<Product>
    {
        private int id;
        private string name;
        private decimal price;

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

        public Product(int _id, string _name, decimal _price)
        {
            id = _id;
            name = _name;
            price = _price;
        }
        public int CompareTo(Product? product)
        {
            if (product == null)
            {
                return 1;
            }
            return price.CompareTo(product.price);
        }

        public override string ToString()
        {
            return $"Product ID: {id}, Name: {name}, Price: {price:C}";
        }
    }
}