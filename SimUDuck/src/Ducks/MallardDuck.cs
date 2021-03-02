using System;
using SimUDuck.Interfaces;
using SimUDuck.Adapters;

namespace SimUDuck.Ducks
{
    public class MallardDuck : IQuackable
    {
        Observable observable;
        public MallardDuck(){
            observable = new Observable(this);
        }
        public void quack()
        {
            Console.WriteLine("Quack");
            notifyObservers();
        }
        public void registerObserver(Observer observer){
            observable.registerObserver(observer);
        }
        public void notifyObservers(){
            observable.notifyObservers();
        }
    }
}
