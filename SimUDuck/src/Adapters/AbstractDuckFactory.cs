using SimUDuck.Interfaces;

namespace SimUDuck.Adapters
{
    public abstract class AbstractDuckFactory
    {
        public abstract IQuackable createMallardDuck();
        public abstract IQuackable createRedHeadDuck();
        public abstract IQuackable createDuckCall();
        public abstract IQuackable createRubberDuck();
        public abstract IQuackable createGoose();
    }
}
