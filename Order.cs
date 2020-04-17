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
      //  static int idCount = 0;
        public double TotalPrice { get; set; }
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public string Products { get; set; }
       // public List<int> Products { get; set; } = new List<int>();
        

        public Order(double totalPrice, string products, int orderId, DateTime date)
        {
            
            Date = date;
            TotalPrice = totalPrice;
            OrderId = orderId;
          Products = products;
           
        }
    }
}
