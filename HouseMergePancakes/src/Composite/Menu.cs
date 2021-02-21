using System;
using System.Collections.Generic;
using System.Linq;


namespace HouseMergePancakes.Composite
{
    public class Menu : MenuComponent
    {
        private List<MenuComponent> _menuComponents = new List<MenuComponent>();
        private string Name, Description;
        public Menu(string name, string description)
        {
            Name = name;
            Description = description;
        }
        public override void add(MenuComponent menuComponent)
        {
            _menuComponents.Add(menuComponent);
        }
        public override void remove(MenuComponent menuComponent)
        {
            _menuComponents.Remove(menuComponent);
        }
        public override MenuComponent getChild(int i) => _menuComponents.ElementAt<MenuComponent>(index: i);
        public override string getName() => Name;
        public override string getDescription() => Description;
        public override void print()
        {
            Console.Write($"\n{getName()}");
            Console.WriteLine($",  {getDescription()}");
            Console.WriteLine("------------");

            foreach (MenuComponent menuComponent in _menuComponents)
            {
                menuComponent.print();
            }
        }
    }
}
