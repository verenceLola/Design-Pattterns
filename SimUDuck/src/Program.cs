using System;
using SimUDuck.Ducks;
using SimUDuck.Interfaces;
using SimUDuck.Adapters;

namespace SimUDuck
{
    class DuckSimulator
    {
        public static void Main(string[] args)
        {
            DuckSimulator simulator = new DuckSimulator();
            AbstractDuckFactory duckFactory = new CountingDuckFactory();

            simulator.simulate(duckFactory);
        }
        void simulate(AbstractDuckFactory duckFactory)
        {
            IQuackable mallardDuck = duckFactory.createMallardDuck();
            IQuackable redHeadDuck = duckFactory.createRedHeadDuck();
            IQuackable duckCall = duckFactory.createDuckCall();
            IQuackable rubberDuck = duckFactory.createRubberDuck();
            IQuackable gooseDuck = duckFactory.createGoose();

            Console.WriteLine("Duck Simulator: With composite -Flocks");

            Flock flockOfDucks = new Flock();
            flockOfDucks.add(redHeadDuck);
            flockOfDucks.add(duckCall);
            flockOfDucks.add(rubberDuck);
            flockOfDucks.add(gooseDuck);

            Flock flockOfMallard = new Flock();

            IQuackable mallardOne = duckFactory.createMallardDuck();
            IQuackable mallardTwo = duckFactory.createMallardDuck();
            IQuackable mallardThree = duckFactory.createMallardDuck();
            IQuackable mallardFour = duckFactory.createMallardDuck();

            flockOfMallard.add(mallardOne);
            flockOfMallard.add(mallardTwo);
            flockOfMallard.add(mallardThree);
            flockOfMallard.add(mallardFour);

            flockOfDucks.add(flockOfMallard);

            Console.WriteLine("Duck simulator: Whole Flock Simulation");

            Console.WriteLine("Duck Simulator: Mallard Flock Simulation");
            simulate(flockOfMallard);

            Console.WriteLine("Duck Simulator: With Oserver");
            Quackologist quackologist = new Quackologist();
            flockOfDucks.registerObserver(quackologist);
            simulate(flockOfDucks);

            Console.WriteLine($"The ducks quacked {QuackCounter.numberOfQuacks}");
        }
        void simulate(IQuackable duck)
        {
            duck.quack();
        }
    }
}
