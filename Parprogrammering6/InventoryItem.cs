using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parprogrammering6
{
    public class InventoryItem
    {
        public string Name {  get; set; }
        public int Quantity { get; set; }
        public double Price { get; set; }

        public InventoryItem(string name, int quantity, double price)
        {
            Name = name;    
            Quantity = quantity;
            Price = price;
        }
    }
}
