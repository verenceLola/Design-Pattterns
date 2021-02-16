namespace PizzaStore.Ingredients.Factories
{
    class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough createDough() => new ThickCrustDough();
        public Sauce createSauce() => new PlumTomatoSauce();
        public Pepperoni createPepperoni() => new SlicedPepperoni();
        public Cheese createCheese() => new MozzarellaCheese();
        public Veggies[] createVeggies() => new Veggies[] {
            new EggPlant(),
            new Spinach(),
            new BlackOlives(),
        };
        public Clams createClams() => new FrozenClams();
    }
}
