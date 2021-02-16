using System;
using PizzaStore.Pizzas;

namespace PizzaStore.Stores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public override Pizza createPizza(Pizza.Type type) =>
        type switch
        {
            Pizza.Type.CHEESE => new ChicagoStyleCheesePizza(),
            Pizza.Type.VEGGIE => new ChicagoStyleVeggiePizza(),
            Pizza.Type.CLAM => new ChicagoStyleClamPizza(),
            Pizza.Type.PEPPERONI => new ChicagoStylePepperoniPizza(),
            _ => throw new ArgumentException("Invalid Pizza Type")
        };
    }
}
