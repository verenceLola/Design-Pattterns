using System;
using SimUDuck.Entities;
using SimUDuck.Aggregates;

namespace SimUDuck
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.performQuack();
            mallard.performFly();

            Duck model = new ModelDuck();
            model.performFly();
            model.setFlyBehaviour(new FlyRocketPowered());
            model.performFly();
        }
    }
}
