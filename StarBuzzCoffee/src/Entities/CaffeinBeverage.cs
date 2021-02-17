using System;



namespace StarBuzzCoffee.Entities
{
    public abstract class CaffeinBeverage
    {
        sealed void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            addCondiments();
        }
        public abstract void brew();
        public abstract void addCondiments();
        public void boilWater()
        {
            Console.WriteLine("Boiling warer");
        }
        public void porInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
    }
}
