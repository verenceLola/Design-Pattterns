using System;
using SimUDuck.Interfaces;

namespace SimUDuck.Behaviours
{
    public class MuteQuack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("<<silence>>");
        }
    }
}
