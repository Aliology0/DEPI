using System;

namespace Day07
{
    class Car
    {
        #region Attributes
        private int id;
        private string brand;
        private decimal price;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        #endregion

        #region Constructors
        public Car() : this(0, "Unknown", 0.0m) { }

        public Car(int _id) : this(_id, "Unknown", 0.0m) { }
        public Car(int _id, string _brand) : this(_id, _brand, 0.0m) { }
        public Car(int _id, string _brand, decimal _price)
        {
            id = _id;
            brand = _brand;
            price = _price;
        }
        #endregion

        public override string ToString()
        {
            return $"Car ID: {id}, Brand: {brand}, Price: ${price}\n===================================";
        }
    }
}