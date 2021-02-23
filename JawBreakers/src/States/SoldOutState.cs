using System;
using JawBreakers.Interfaces;
using JawBreakers.Entities;

namespace JawBreakers.States
{
    public class SoldOutState : IState
    {
        private GumballMachine _gumballMachine;
        public SoldOutState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("You can't insert a quarter, the machine is already sold out");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("You can't eject, you haven't inserted a quarter yet");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned, but there are no gumballs");
        }
        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
