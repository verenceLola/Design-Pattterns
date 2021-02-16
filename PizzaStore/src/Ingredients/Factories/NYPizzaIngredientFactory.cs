namespace PizzaStore.Ingredients.Factories
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough() => new ThinCrustDough();
        public Sauce createSauce() => new MarinaSauce();
        public Cheese createCheese() => new ReggianoCheese();
        public Veggies[] createVeggies() => new Veggies[]{
            new Garlic(),
            new Onion(),
            new Mushroom(),
            new RedPepper()
        };
        public Pepperoni createPepperoni() => new SlicedPepperoni();
        public Clams createClams() => new FreshClams();
    }
}
