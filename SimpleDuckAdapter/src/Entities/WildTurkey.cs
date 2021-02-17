using System;
using SimpleDuckAdapter.Interfaces;

namespace SimpleDuckAdapter.Entities
{
    public class WildTurkey : Turkey
    {
        public void fly()
        {
            Console.WriteLine("I'm flying a short distance");
        }
        public void gobble()
        {
            Console.WriteLine("Gobble gobble");
        }
    }
}
