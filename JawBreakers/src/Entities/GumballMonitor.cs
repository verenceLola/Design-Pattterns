using System;


namespace JawBreakers.Entities
{
    public class GumballMonitor
    {
        private GumballMachine _gumballMachine;
        public GumballMonitor(GumballMachine gumballMachine)
        {
            _gumballMachine = gumballMachine;
        }
        public void report()
        {
            Console.WriteLine("Gumball Machine: " + _gumballMachine.Location);
            Console.WriteLine($"Current inventory:  {_gumballMachine.Count} gumballs");
            Console.WriteLine($"Current state: {_gumballMachine.State}");
        }
    }
}
