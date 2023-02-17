using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    class OrderItem
    {
        public static int IntanceCount { get; set; }

        private int _id;
        private int _productId;
        private double? _purchasePrice; //can be null
        private int _quantity;

        public int Id { get => _id; set => _id = value; }
        public int ProductId { get => _productId; set => _productId = value; }
        public double? PurchasePrice { get => _purchasePrice; set => _purchasePrice = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }

        public OrderItem()
        {

        }

        public OrderItem(int id)
        {
            _id = id;
        }

        public List<OrderItem> Load()
        {
            return new List<OrderItem>();
        }

        public OrderItem Load(int id) 
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var result = true;

            if (ProductId <= 0)
                result = false;
            if (Quantity <= 0)
                result = false;
            if (PurchasePrice == null)
                result = false;

            return result;
        }
    }
}
