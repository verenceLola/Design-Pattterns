using System;
using PizzaStore.Pizzas;
using PizzaStore.Ingredients.Factories;

namespace PizzaStore.Stores
{
    public class NYPizzaStore : PizzaStore
    {
        Pizza pizza;
        PizzaIngredientFactory pizzaIngredientFactory = new NYPizzaIngredientFactory();
        public override Pizza createPizza(Pizza.Type type)
        {
            if (type == Pizza.Type.CHEESE)
            {
                pizza = new CheesePizza(pizzaIngredientFactory);
                pizza.name = "New York Style Cheese Pizza";
            }
            else if (type == Pizza.Type.CLAM)
            {
                pizza = new ClamPizza(pizzaIngredientFactory);
                pizza.name = "New York Style Clam Pizza";
            }

            return pizza;
        }
    }
}
