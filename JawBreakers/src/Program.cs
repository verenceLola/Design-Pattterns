using System;
using JawBreakers.Entities;

namespace JawBreakers
{
    class GumballMachineTestDrive
    {
        public static void Main(string[] args)
        {
            GumballMachine gumballMachine = new GumballMachine(numberGumballs: 5);
            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);

            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();
            gumballMachine.insertQuarter();
            gumballMachine.turnCrank();

            Console.WriteLine(gumballMachine);
        }
    }
}
