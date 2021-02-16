using System;
using PizzaStore.Ingredients.Factories;

namespace PizzaStore.Pizzas
{
    public class CheesePizza : Pizza
    {
        private PizzaIngredientFactory _pizzaIngredientFactory;
        public CheesePizza(PizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public override void prepare()
        {
            Console.WriteLine("Preparing " + name);
            dough = _pizzaIngredientFactory.createDough();
            cheese = _pizzaIngredientFactory.createCheese();
            sauce = _pizzaIngredientFactory.createSauce();
        }
    }
}
