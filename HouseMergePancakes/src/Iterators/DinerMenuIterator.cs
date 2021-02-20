using System.Collections;
using System.Collections.Generic;
using HouseMergePancakes.Menus;


namespace HouseMergePancakes.Iterators
{
    public class DinerMenuIterator : IEnumerable<MenuItem>
    {
        private MenuItem[] _menuItems;
        public DinerMenuIterator(MenuItem[] menuItems)
        {
            _menuItems = menuItems;
        }
        public IEnumerator<MenuItem> GetEnumerator() => ((IEnumerable<MenuItem>)_menuItems).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
