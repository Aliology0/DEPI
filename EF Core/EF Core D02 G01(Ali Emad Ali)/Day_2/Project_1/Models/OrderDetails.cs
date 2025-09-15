using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.Models
{
    internal class OrderDetails
    {
        #region Attributes
        private int quantity;
        #endregion

        #region Properties

        public int? ProductId { get; set; }
        public Product Product { get; set; }
        public int? OrderId { get; set; }
        public Order Order { get; set; }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }
        #endregion

        #region Constructor
        public OrderDetails() { }
        public OrderDetails(int _orderId, int _productId, int _quantity)
        {
            OrderId = _orderId;
            ProductId = _productId;
            quantity = _quantity;
        }
        #endregion
    }
}
