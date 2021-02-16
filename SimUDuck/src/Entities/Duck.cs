using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Entities
{
    public abstract class Duck
    {
        public IQuackBehaviour quackBehaviour;
        public IFlyBehaviour flyBehaviour;
        public abstract void display();
        public void performFly()
        {
            flyBehaviour.fly();
        }
        public void performQuack()
        {
            quackBehaviour.quack();
        }
        public void swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
        public Duck() { }
        public void setFlyBehaviour(IFlyBehaviour fb)
        {
            flyBehaviour = fb;
        }
        public void setQuackBehaviour(IQuackBehaviour qb)
        {
            quackBehaviour = qb;
        }
    }
}
