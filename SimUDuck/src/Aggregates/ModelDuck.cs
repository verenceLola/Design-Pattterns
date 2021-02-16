using System;
using SimUDuck.Entities;
using SimUDuck.Behaviours;

namespace SimUDuck.Aggregates
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehaviour = new FlyNoWay();
            quackBehaviour = new Quack();
        }
        public override void display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}
