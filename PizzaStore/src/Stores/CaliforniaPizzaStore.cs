using System;
using PizzaStore.Pizzas;

namespace PizzaStore.Stores
{
    public class CaliforniaPizzaStore : PizzaStore
    {
        public override Pizza createPizza(Pizza.Type type) =>
        type switch
        {
            Pizza.Type.CHEESE => new CaliforniaStyleCheesePizza(),
            Pizza.Type.VEGGIE => new CaliforniaStyleVeggiePizza(),
            Pizza.Type.CLAM => new CaliforniaStyleClamPizza(),
            Pizza.Type.PEPPERONI => new CaliforniaStylePepperoniPizza(),
            _ => throw new ArgumentException("Invalid Pizza Type")
        };
    }
}
