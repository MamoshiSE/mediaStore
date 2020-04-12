using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mediaStore
{
    class Product
    {
        public string Name { get; set; }
        private double Price { get; set; }
        public int ProductId { get; set; }
        public string Media { get; set; }
        public int Quantity { get; set; }

        public Product(string name, double price, int productId, string media, int quantity)
        {
            Name = name;
            Price = price;
            ProductId = productId;
            Media = media;
            Quantity = quantity;
        }
    }
}
