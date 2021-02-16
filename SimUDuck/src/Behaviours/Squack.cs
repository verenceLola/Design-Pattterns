﻿using System;
using SimUDuck.Interfaces;


namespace SimUDuck.Behaviours
{
    public class Squack : IQuackBehaviour
    {
        public void quack()
        {
            Console.WriteLine("Squack");
        }
    }
}
