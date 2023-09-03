using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Cart
{
    public class Product
    {
        public string name { get;}
        public decimal price { get;}
        public Product(string _name, decimal _price)
        {
            name = _name;
            price = _price;
        }
    }
}
