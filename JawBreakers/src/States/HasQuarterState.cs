using System;
using JawBreakers.Entities;
using JawBreakers.Interfaces;

namespace JawBreakers.States
{
    public class HasQuarterState : IState
    {
        private GumballMachine _gumballMachine;
        private Random randomWinner = new Random(DateTime.Now.Millisecond);
        public HasQuarterState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void ejectQuarter()
        {
            Console.WriteLine("Quarter returned");
            _gumballMachine.setState(_gumballMachine.NoQuarterState);
        }
        public void insertQuarter()
        {
            Console.WriteLine("You can't insert another quarter");
        }
        public void turnCrank()
        {
            Console.WriteLine("You turned ...");
            int winner = randomWinner.Next(10);

            if ((winner == 0) && (_gumballMachine.Count > 1))
            {
                _gumballMachine.setState(_gumballMachine.WinnerState);
            }
            else
            {
                _gumballMachine.setState(_gumballMachine.SoldState);
            }
        }
        public void dispense()
        {
            Console.WriteLine("No gumball dispensed");
        }
    }
}
