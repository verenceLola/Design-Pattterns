using System;
using StarBuzzCoffee.Entities;

namespace StarBuzzCoffee
{
    class MakeBeverage
    {
        public static void Main(string[] args)
        {
            CaffeinBeverage tea = new Tea();
            CaffeinBeverage coffee = new Coffee();

            tea.prepareRecipe();
            Console.WriteLine();
            coffee.prepareRecipe();
        }
    }
}
