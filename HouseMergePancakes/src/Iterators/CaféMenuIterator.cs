using System.Collections.Generic;
using HouseMergePancakes.Menus;
using System.Collections;

namespace HouseMergePancakes.Iterators
{
    public class CaféMenuIterator : IEnumerable<MenuItem>
    {
        private ICollection<MenuItem> _menuItems;
        public CaféMenuIterator(ICollection<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }
        public IEnumerator<MenuItem> GetEnumerator() => ((IEnumerable<MenuItem>)_menuItems).GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
