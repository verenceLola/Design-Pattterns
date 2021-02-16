using System;
using PizzaStore.Ingredients.Factories;

namespace PizzaStore.Pizzas
{
    public class ClamPizza : Pizza
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;
        public ClamPizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _pizzaIngredientFactory.createDough();
            sauce = _pizzaIngredientFactory.createSauce();
            cheese = _pizzaIngredientFactory.createCheese();
            clam = _pizzaIngredientFactory.createClams();
        }
    }
}
