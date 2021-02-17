using SimpleDuckAdapter.Interfaces;
using System;

namespace SimpleDuckAdapter.Entities
{
    public class DuckAdapter : Turkey
    {
        private Duck _duck;
        private Random rand;
        public DuckAdapter(Duck duck)
        {
            _duck = duck;
            rand = new Random();
        }
        public void gobble()
        {
            _duck.quack();
        }
        public void fly()
        {
            if (rand.Next(5) == 0)
            {
                _duck.fly();
            }
        }
    }
}
