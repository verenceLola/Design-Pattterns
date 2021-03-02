using SimUDuck.Ducks;
using SimUDuck.Interfaces;

namespace SimUDuck.Adapters
{
    public class CountingDuckFactory : AbstractDuckFactory
    {
        public override IQuackable createDuckCall() => new QuackCounter(new DuckCall());
        public override IQuackable createMallardDuck() => new QuackCounter(new MallardDuck());
        public override IQuackable createRedHeadDuck() => new QuackCounter(new RedHeadDuck());
        public override IQuackable createRubberDuck() => new QuackCounter(new RubberDuck());
        public override IQuackable createGoose() => new QuackCounter(new GooseAdapter(new Goose()));
    }
}
