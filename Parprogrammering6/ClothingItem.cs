using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering6
{
     class ClothingItem : InventoryItem, ISellable
    {
        public string Size { get; set; }
        public string Color { get; set; }

        public ClothingItem(string name, int quantity, double price, string size, string color) : base(name, quantity, price)
        {
            Size = size;
            Color = color;
        }

        public double CalculatePrice()
        {
            return Price * Quantity;
        }
    }
}
