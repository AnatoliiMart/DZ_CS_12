using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ_CS_12
{
    internal class Shop : IDisposable
    {
        public string Name     { get; private set; }
        public string Adress   { get; private set; }
        public int    ShopType { get; private set; }
        private int id;

        public Shop(string name, string adress, int shopType, int Id) 
        {
            Name     = name;
            Adress   = adress;
            ShopType = shopType;
            id       = Id;
        }
        public override string ToString() 
        {
            string? type;
            switch (ShopType)
            {
                case 1:
                    type = "Grocery store";
                    break;
                case 2:
                    type = "Hardware store";
                    break;
                case 3:
                    type = "Clothing store";
                    break;
                case 4:
                    type = "Shoe shop";
                    break;
                default:
                    type = "None typed shop";
                    break;
            }
            return $"Shop name:\t{Name}\nShop adress:\t{Adress}\nShop type:\t{type}";
        }
        public void Dispose()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine($"Shop {id} was destroyed");
            Console.Beep();
        }
        ~Shop()
        {
            GC.SuppressFinalize(this);
            Console.WriteLine("Shop object was destroyed:\t" + this.id + " with destructor!");
            Console.Beep();
        }
    }
}
