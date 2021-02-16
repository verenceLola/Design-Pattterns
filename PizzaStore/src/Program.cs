using System;
using PizzaStore.Pizzas;
using PizzaStore.Stores;

namespace PizzaStore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            PizzaStore.Stores.PizzaStore nyStore = new NYPizzaStore();
            PizzaStore.Stores.PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.orderPizza(Pizza.Type.CHEESE);
            Console.WriteLine("Ethan ordered a " + pizza.name);

            pizza = chicagoStore.orderPizza(Pizza.Type.CHEESE);
            Console.WriteLine("Joel ordered a " + pizza.name);
        }
    }
}
