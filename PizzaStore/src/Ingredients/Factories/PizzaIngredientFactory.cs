namespace PizzaStore.Ingredients.Factories
{
    public interface PizzaIngredientFactory
    {
        public Dough createDough();
        public Sauce createSauce();
        public Cheese createCheese();
        public Veggies[] createVeggies();
        public Pepperoni createPapperoni();
        public Clams createClams();
    }
}
