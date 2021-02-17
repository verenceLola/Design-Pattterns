using System;
using SimpleDuckAdapter.Entities;
using SimpleDuckAdapter.Interfaces;

namespace SimpleDuckAdapter
{
    class DuckDriveTest
    {
        public static void Main(string[] args)
        {
            Duck duck = new MallardDuck();
            Turkey turkey = new WildTurkey();
            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            Console.WriteLine("Turkey says ...");
            turkey.gobble();
            turkey.fly();

            Console.WriteLine("Duck says ...");
            testDuck(duck);

            Console.WriteLine("TurkeyAdapter says ...");
            testDuck(turkeyAdapter);
        }
        public static void testDuck(Duck testDuck)
        {
            testDuck.quack();
            testDuck.fly();
        }
    }
}
