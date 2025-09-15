using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    internal class Order
    {
        #region Attributes
        private int id;
        private DateTime orderDate;
        #endregion

        #region Properties
        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public DateTime OrderDate
        {
            get { return orderDate; }
            set { orderDate = value; }
        }

        //Foreign Key
        public int? CustomerId { get; set; }

        // Navigation properties
        public Customer Customer { get; set; }
        public ICollection<OrderDetails> OrderDetails { get; set; } = new List<OrderDetails>();
        #endregion

        #region Constructor
        public Order() { }
        public Order(DateTime _orderDate, int _customerId)
        {
            orderDate = _orderDate;
            CustomerId = _customerId;
        }
        #endregion
    }
}
