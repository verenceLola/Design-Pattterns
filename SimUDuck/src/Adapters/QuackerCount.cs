using SimUDuck.Interfaces;

namespace SimUDuck.Adapters
{
    public class QuackCounter : IQuackable
    {
        private IQuackable _duck;
        private Observable _observable;
        public static int numberOfQuacks { get; private set; }
        public QuackCounter(IQuackable duck)
        {
            _duck = duck;
            _observable = new Observable(duck);
        }
        public void notifyObservers()
        {
            _observable.notifyObservers();
        }
        public void registerObserver(Observer observer)
        {
            _observable.registerObserver(observer);
        }
        public void quack()
        {
            _duck.quack();
            numberOfQuacks++;
            notifyObservers();
        }
    }
}
