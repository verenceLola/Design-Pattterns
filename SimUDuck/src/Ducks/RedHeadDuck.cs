using System;
using SimUDuck.Interfaces;
using SimUDuck.Adapters;

namespace SimUDuck.Ducks
{
    public class RedHeadDuck : IQuackable
    {
        private Observable _observable;
        public RedHeadDuck()
        {
            _observable = new Observable(this);
        }
        public void quack()
        {
            Console.WriteLine("Quack");
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
