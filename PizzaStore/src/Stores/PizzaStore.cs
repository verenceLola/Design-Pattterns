using PizzaStore.Pizzas;

namespace PizzaStore.Stores
{
    public abstract class PizzaStore
    {
        public abstract Pizza createPizza(Pizza.Type type);
        public Pizza orderPizza(Pizza.Type type)
        {
            Pizza pizza = createPizza(type: type);
            pizza.prepare();
            pizza.bake();
            pizza.cut();
            pizza.box();

            return pizza;
        }
    }
}
