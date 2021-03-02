using System;
using SimUDuck.Interfaces;
using SimUDuck.Adapters;

namespace SimUDuck.Ducks
{
    public class RubberDuck : IQuackable
    {
        private Observable _observable;
        public RubberDuck()
        {
            _observable = new Observable(this);
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
            Console.WriteLine("Squack");
            notifyObservers();
        }
    }
}
