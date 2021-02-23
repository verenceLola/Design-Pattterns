using System;
using JawBreakers.Interfaces;
using JawBreakers.Entities;

namespace JawBreakers.States
{
    public class WinnerState : IState
    {
        private GumballMachine _gumballMachine;
        public WinnerState(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void turnCrank()
        {
            throw new InvalidOperationException();
        }
        public void insertQuarter()
        {
            throw new InvalidOperationException();
        }
        public void ejectQuarter()
        {
            throw new InvalidOperationException();
        }
        public void dispense()
        {
            _gumballMachine.releaseBall();

            if (_gumballMachine.Count == 0)
            {
                _gumballMachine.setState(_gumballMachine.SoldOutState);
            }
            else
            {
                _gumballMachine.releaseBall();
                Console.WriteLine("YOU'RE A WINNER! You got two gumballs for your quarter");

                if (_gumballMachine.Count > 0)
                {
                    _gumballMachine.setState(_gumballMachine.NoQuarterState);
                }
                else
                {
                    Console.WriteLine("oops, out of gumballs");
                    _gumballMachine.setState(_gumballMachine.SoldOutState);
                }
            }
        }
    }
}
