using System;



namespace StarBuzzCoffee.Entities
{
    public abstract class CaffeinBeverage
    {
        public void prepareRecipe()
        {
            boilWater();
            brew();
            pourInCup();
            if (customerWantsCondiments())
            {
                addCondiments();
            }
        }
        public abstract void brew();
        public abstract void addCondiments();
        public void boilWater()
        {
            Console.WriteLine("Boiling warer");
        }
        public void pourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }
        public virtual bool customerWantsCondiments() => true;
    }
}
