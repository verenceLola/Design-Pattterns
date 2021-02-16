using System;
using SimUDuck.Behaviours;

namespace SimUDuck.Entities
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehaviour = new Quack();
            flyBehaviour = new FlyWithWings();
        }

        public override void display()
        {
            Console.WriteLine("I'm a real Mallard duck");
        }
    }
}
