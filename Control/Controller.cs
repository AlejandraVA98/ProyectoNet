using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Control
{
    public sealed class Controller
    {
        private static Controller _instance;
        public static Controller GetInstance()
        {
            if (_instance == null)
            {
                _instance = new Controller();
            }
            return _instance;
        }

        public List<Model.Consumable> Product_List { get; private set; }

        private Controller()
        {
            Product_List = new List<Model.Consumable>();

            Product_List.Add(new Model.Consumable("pepsi", 2000, 20));
            Product_List.Add(new Model.Consumable("Coca Cola", 2000, 15));
            Product_List.Add(new Model.Consumable("papitas", 1500, 20));
            Product_List.Add(new Model.Consumable("choco ramo", 2000, 7));
        }

        public void AddProduct(Model.Consumable product)
        {
            Product_List.Add(product);
        }

        public Model.Consumable GetProduct(string name)
        {
            foreach (Model.Consumable product in Product_List)
            {
                if (product.Name == name)
                {
                    return product;
                }
            }
            return null;
        }
    }
}

