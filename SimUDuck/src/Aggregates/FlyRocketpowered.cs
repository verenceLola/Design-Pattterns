using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Aggregates
{
    public class FlyRocketPowered : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("i'm flying with a rocket!");
        }
    }
}
