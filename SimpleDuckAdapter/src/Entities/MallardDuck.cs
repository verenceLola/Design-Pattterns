using System;
using SimpleDuckAdapter.Interfaces;

namespace SimpleDuckAdapter.Entities
{
    public class MallardDuck : Duck
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
        public void fly()
        {
            Console.WriteLine("i'm flying");
        }
    }
}
