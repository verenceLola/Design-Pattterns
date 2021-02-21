using HouseMergePancakes.Composite;
namespace HouseMergePancakes.Composite
{
    public class Waitress
    {
        private MenuComponent _menuComponent;
        public Waitress(MenuComponent menuComponent)
        {
            _menuComponent = menuComponent;
        }
        public void printMenu()
        {
            _menuComponent.print();
        }
    }
}
