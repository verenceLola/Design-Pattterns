using System;


namespace HouseMergePancakes.Composite
{
    public class MenuItem : MenuComponent
    {
        private string Name;
        private string Description;
        private bool Vegetarian;
        private double Price;
        public MenuItem(string name, string description, double price, bool vegetarian)
        {
            Name = name;
            Vegetarian = vegetarian;
            Price = price;
            Description = description;
        }
        public override string getName() => Name;
        public override string getDescription() => Description;
        public override bool isVegetarian() => Vegetarian;
        public override double getPrice() => Price;
        public override void print()
        {
            Console.Write($"  {getName()}");
            if (isVegetarian())
            {
                Console.Write("(v)");
            }
            Console.WriteLine($",  {getPrice()}");
            Console.WriteLine($"   --  {getDescription()}");
        }
    }
}
