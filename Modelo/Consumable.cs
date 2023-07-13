using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public interface IStoreItem
    {
        string GetName();
        int GetPrice();
    }

    public class Consumable : IStoreItem
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }

        public Consumable(string name, int price, int quantity)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
        }

        public override string ToString()
        {
            return Name + ": " + Price + ", Cantidad: " + Quantity;
        }

        public string GetName()
        {
            return Name;
        }

        public int GetPrice()
        {
            return Price;
        }
    }
}
