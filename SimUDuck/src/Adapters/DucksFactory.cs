using SimUDuck.Interfaces;
using SimUDuck.Ducks;

namespace SimUDuck.Adapters
{
    public class DuckFactory : AbstractDuckFactory
    {
        public override IQuackable createMallardDuck() => new MallardDuck();
        public override IQuackable createDuckCall() => new DuckCall();
        public override IQuackable createRedHeadDuck() => new RedHeadDuck();
        public override IQuackable createRubberDuck() => new RubberDuck();
        public override IQuackable createGoose() => new GooseAdapter(new Goose());
    }
}
