using HouseMergePancakes.Iterators;
using System.Collections.Generic;
using HouseMergePancakes.Interfaces;



namespace HouseMergePancakes.Menus
{
    public class PancakeHouseMenu : Menu
    {
        List<MenuItem> menuItems { get; }

        public PancakeHouseMenu()
        {
            menuItems = new List<MenuItem>();
            addItem("K&B's Pancake Breakfast", "Pancake with scrambled eggs and toast", true, 2.99);
            addItem("Pancakes with scrambled eggs and toast", "Pancake with fried eggs, sausage", false, 2.99);
            addItem("Blueberry Pancakes", "PancakeHouseMenu made with fresh blueberries", true, 3.59);
            addItem("Waffles", "Waffles ith your choice of blueberry or strawberries", true, 5.59);
        }
        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, price, vegetarian, description);
            menuItems.Add(menuItem);
        }
        public IEnumerator<MenuItem> createEnumerator()
        {
            PancakeHouseMenuIterator menuIterator = new PancakeHouseMenuIterator(menuItems);

            return menuIterator.GetEnumerator();
        }
    }
}
