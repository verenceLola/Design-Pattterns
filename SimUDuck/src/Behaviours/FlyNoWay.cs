using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Behaviours
{
    public class FlyNoWay : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I can't fly");
        }
    }
}
