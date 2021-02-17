using System;


namespace StarBuzzCoffee.Entities
{
    public class Tea : CaffeinBeverage
    {

        public override void brew()
        {
            Console.WriteLine("Steeping the tea");
        }
        public override void addCondiments()
        {
            Console.WriteLine("Adding Lemon");
        }
    }
}
