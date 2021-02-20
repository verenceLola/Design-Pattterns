using System.Collections.Generic;
using HouseMergePancakes.Menus;

namespace HouseMergePancakes.Interfaces
{
    public interface Menu
    {
        IEnumerator<MenuItem> createEnumerator();
    }
}
