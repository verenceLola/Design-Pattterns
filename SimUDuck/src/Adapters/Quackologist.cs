using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Adapters
{
    public class Quackologist : Observer
    {
        public void update(QuackObseravable duck)
        {
            Console.WriteLine($"Quackologist:  {duck.GetType().Name} just quacked");
        }
    }
}
