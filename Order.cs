using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaStore
{
    class Order
    {
       
        public double TotalPrice { get; set; }
        public int OrderId { get; set; }

        public BindingList<Product> Products { get; set; } = new BindingList<Product>();
        

        public Order(double totalPrice, int orderId, BindingList<Product> products)
        {
            TotalPrice = totalPrice;
            OrderId = orderId;
          Products = products;
           
        }
    }
}
