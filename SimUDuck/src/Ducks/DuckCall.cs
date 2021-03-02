using System;
using SimUDuck.Interfaces;
using SimUDuck.Adapters;

namespace SimUDuck.Ducks
{
    public class DuckCall : IQuackable
    {
        private Observable _observable;
        public DuckCall()
        {
            _observable = new Observable(this);
        }
        public void quack()
        {
            Console.WriteLine("Kwak");
            notifyObservers();
        }
        public void registerObserver(Observer observer)
        {
            _observable.registerObserver(observer);
        }
        public void notifyObservers()
        {
            _observable.notifyObservers();
        }
    }
}
