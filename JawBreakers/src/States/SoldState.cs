using System;
using JawBreakers.Interfaces;
using JawBreakers.Entities;

namespace JawBreakers.States
{
    public class SoldState : IState
    {
        private GumballMachine _gumballMachine;
        public SoldState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void insertQuarter()
        {
            Console.WriteLine("Please wait, we're already giving you a gumball");
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Sorry, you already turned the crunk");
        }
        public void turnCrank()
        {
            Console.WriteLine("Turning twice doesn't get you another gumball");
        }
        public void dispense()
        {
            _gumballMachine.releaseBall();

            if (_gumballMachine.Count > 0)
            {
                _gumballMachine.setState(_gumballMachine.NoQuarterState);
            }
            else
            {
                Console.WriteLine("Oops, out of gumballs");
                _gumballMachine.setState(_gumballMachine.SoldOutState);
            }
        }
    }
}
