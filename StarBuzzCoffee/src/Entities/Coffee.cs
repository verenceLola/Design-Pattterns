using System;

namespace StarBuzzCoffee.Entities
{
    public class Coffee : CaffeinBeverage
    {
        public override void brew()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Add Sugar and Milk");
        }
        public override bool customerWantsCondiments()
        {
            return false;
        }
    }
}
