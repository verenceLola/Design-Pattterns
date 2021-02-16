using System;
using Starbuzz.Entities;
using Starbuzz.Condiments;

namespace Starbuzz
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Beverage beverage = new Expresso();
            beverage.size = Beverage.Size.GRANDE;
            Console.WriteLine(beverage.Description + " $" + beverage.cost());

            Beverage beverage1 = new DarkRoast();
            beverage1.size = Beverage.Size.TALL;
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine(beverage1.Description + " $" + beverage1.cost());

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine(beverage2.Description + " $" + beverage2.cost());
        }
    }
}
