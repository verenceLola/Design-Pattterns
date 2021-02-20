using System;
using System.Collections;
using HouseMergePancakes.Interfaces;
using HouseMergePancakes.Menus;
using System.Collections.Generic;

namespace HouseMergePancakes
{
    public class Waitress
    {
        List<Menu> menus = new List<Menu>();
        public Waitress(Menu pancakeHouseMenu, Menu dinerMenu, Menu cafeMenu)
        {
            menus.Add(cafeMenu);
            menus.Add(dinerMenu);
            menus.Add(pancakeHouseMenu);
        }
        public void printMenu()
        {
            foreach (Menu menu in menus)
            {
                printMenu(iterator: menu.createEnumerator());
            }
        }
        public void printMenu(IEnumerator iterator)
        {
            while (iterator.MoveNext())
            {
                MenuItem menuItem = (MenuItem)iterator.Current;
                Console.WriteLine(menuItem.name, ", ");
                Console.WriteLine(menuItem.price.ToString(), " -- ");
                Console.WriteLine(menuItem.decription);
            }
        }
    }
}
