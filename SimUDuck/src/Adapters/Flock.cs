using SimUDuck.Interfaces;
using System.Collections.Generic;

namespace SimUDuck.Adapters
{
    public class Flock : IQuackable
    {
        List<IQuackable> quackers = new List<IQuackable>();
        public void add(IQuackable quacker)
        {
            quackers.Add(quacker);
        }
        public void quack()
        {
            IEnumerator<IQuackable> itererator = quackers.GetEnumerator();
            while (itererator.MoveNext())
            {
                IQuackable quackable = itererator.Current;
                quackable.quack();
            }
        }
        public void registerObserver(Observer observer)
        {
            foreach (IQuackable quacker in quackers)
            {
                quacker.registerObserver(observer);
            }
        }
        public void notifyObservers() { }
    }
}
