using SimUDuck.Interfaces;
using SimUDuck.Ducks;

namespace SimUDuck.Adapters
{
    public class GooseAdapter : IQuackable
    {
        private Goose _goose;
        private Observable _observable;
        public GooseAdapter(Goose goose)
        {
            _goose = goose;
            _observable = new Observable(this);
        }
        public void quack()
        {
            _goose.honk();
            notifyObservers();
        }
        public void notifyObservers()
        {
            _observable.notifyObservers();
        }
        public void registerObserver(Observer observer)
        {
            _observable.registerObserver(observer);
        }
    }
}
