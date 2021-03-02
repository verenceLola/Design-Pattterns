using SimUDuck.Interfaces;
using System.Collections.Generic;

namespace SimUDuck.Adapters
{
    public class Observable : QuackObseravable
    {
        private List<Observer> observers = new List<Observer>();
        private QuackObseravable _duck;
        public Observable(QuackObseravable duck)
        {
            _duck = duck;
        }
        public void registerObserver(Observer observer)
        {
            observers.Add(observer);
        }
        public void notifyObservers()
        {
            IEnumerator<Observer> iterator = observers.GetEnumerator();

            while (iterator.MoveNext())
            {
                Observer observer = iterator.Current;
                observer.update(_duck);
            }
        }
    }
}
