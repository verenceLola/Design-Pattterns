using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Behaviours
{
    public class Quack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
