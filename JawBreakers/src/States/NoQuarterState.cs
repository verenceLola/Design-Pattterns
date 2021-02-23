using System;
using JawBreakers.Interfaces;
using JawBreakers.Entities;

namespace JawBreakers.States
{
    public class NoQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        public NoQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("You inserted a quarter");
            _gumballMachine.setState(_gumballMachine.HasQuarterState);
        }
        public void ejectQuarter()
        {
            Console.WriteLine("You haven't inserted a quarter");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned, but there's no quarter");
        }
        public void dispense()
        {
            Console.WriteLine("You need to pay first");
        }
    }
}
