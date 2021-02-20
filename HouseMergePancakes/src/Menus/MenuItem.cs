using System;
using System.Collections.Generic;

namespace HouseMergePancakes.Menus
{
    public class MenuItem
    {
        public string name { get; private set; }
        public string decription { get; }
        public bool vegetarian { get; }
        public double price { get; }
        public MenuItem(string _name, double _price, bool _vegetarian, string _description)
        {
            vegetarian = _vegetarian;
            price = _price;
            name = _name;
            decription = _description;
        }
    }
}
