using HouseMergePancakes.Menus;
using System.Collections.Generic;
using System.Collections;

namespace HouseMergePancakes.Iterators
{
    public class PancakeHouseMenuIterator : IEnumerable<MenuItem>
    {
        private int _position = 0;
        private List<MenuItem> _menuItems;
        public PancakeHouseMenuIterator(List<MenuItem> menuItems)
        {
            _menuItems = menuItems;
        }
        public IEnumerator<MenuItem> GetEnumerator() => _menuItems.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
