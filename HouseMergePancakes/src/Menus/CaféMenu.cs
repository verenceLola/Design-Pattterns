using HouseMergePancakes.Interfaces;
using System.Collections.Generic;
using HouseMergePancakes.Iterators;


namespace HouseMergePancakes.Menus
{
    public class CaféMenu : Menu
    {
        private Dictionary<string, MenuItem> _menuItem = new Dictionary<string, MenuItem>();
        public CaféMenu()
        {
            addItem("Veggie Burger and Air Fries", "Veggie burger on a whole wheat bun, lettuce, tomato, and fries", true, 3.99);
            addItem("Soup of the day", "A cup of the soup of the day, with a side salad", false, 3.69);
            addItem("Burrito", "A large burrito, with whole pinto beans, salsa, guacamole", true, 4.29);
        }
        public void addItem(string name, string description, bool vegetarian, double price)
        {
            MenuItem menuItem = new MenuItem(name, price, vegetarian, description);
            _menuItem.Add(name, menuItem);
        }
        public IEnumerator<MenuItem> createEnumerator()
        {
            CaféMenuIterator iterator = new CaféMenuIterator(_menuItem.Values);

            return iterator.GetEnumerator();
        }
    }
}
