using System;
using HouseMergePancakes.Iterators;
using HouseMergePancakes.Interfaces;
using System.Collections.Generic;
using System.Linq;


namespace HouseMergePancakes.Menus
{
    public class DinerMenu : Menu
    {
        public static readonly int MAX_ITEMS = 6;
        public int numberOfItems = 0;
        public MenuItem[] menuItems { get; }

        public DinerMenu()
        {
            menuItems = new MenuItem[MAX_ITEMS];
            addItem("Vegeterial BLT", "(Fakin) Bacon with lettuce & tomato on whole wheat", true, 2.99); ;
            addItem("BLT", "Bacon with lettuce & tomato on whole wheat", false, 2.99);
            addItem("Soupe of the day", "Soup of the day, with a side of potato salad", false, 3.29);
            addItem("Hottdog", "A hot dog with sauerkraut, relish, onions, topped with cheese", false, 3.05);
        }
        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, price, vegetarian, description);
            if (numberOfItems >= MAX_ITEMS)
            {
                throw new InvalidOperationException("Sorry Menu full!, Can't add item to menu");
            }
            else
            {
                menuItems[numberOfItems] = menuItem;
                numberOfItems += 1;
            }
        }
        public IEnumerator<MenuItem> createEnumerator()
        {
            DinerMenuIterator dinerIterator = new DinerMenuIterator(menuItems.Where<MenuItem>(item => item != null).ToArray<MenuItem>());

            return dinerIterator.GetEnumerator();
        }

    }
}
