using HouseMergePancakes.Menus;

namespace HouseMergePancakes.Interfaces
{
    public interface Iterator
    {
        bool hasNext();
        MenuItem next();
    }
}
