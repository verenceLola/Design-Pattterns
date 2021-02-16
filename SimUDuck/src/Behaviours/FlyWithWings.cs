using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Behaviours
{
    public class FlyWithWings : IFlyBehaviour
    {
        public void fly()
        {
            Console.WriteLine("I'm flying");
        }
    }
}
