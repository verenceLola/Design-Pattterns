using System;
using System.Collections.Generic;

namespace PizzaStore.Pizzas
{
    public abstract class Pizza
    {
        public string name { get; set; }
        protected Dough dough;
        protected Clams clam;
        protected Pepperoni pepperoni;
        protected Cheese cheese;
        protected Sauce sauce;
        protected Veggies[] veggies;
        public enum Type { CHEESE, VEGGIE, CLAM, PEPPERONI };
        public List<string> toppings = new List<string>();
        public abstract void prepare();
        // {
        //     Console.WriteLine($"Preparing  {name}");
        //     Console.WriteLine("Tossing dough...");
        //     Console.WriteLine("Adding sauce...");
        //     Console.WriteLine("Adding toppings...");

        //     foreach (string topping in toppings)
        //     {
        //         Console.WriteLine($"  {topping}");
        //     }
        // }
        public void bake()
        {
            Console.WriteLine("Bake for 25 min at 350");
        }
        public virtual void cut()
        {
            Console.WriteLine("Cutting the pizza into diagonal slices");
        }
        public void box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box");
            Console.WriteLine("<-------Done------->");
        }
    }
}
