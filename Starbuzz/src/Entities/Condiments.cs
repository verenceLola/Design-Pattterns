using Starbuzz.Entities;

namespace Starbuzz.Condiments
{
    public class Mocha : CondimentDecorator
    {
        private Beverage _beverage;
        public Mocha(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description { get => _beverage.Description + ", Mocha"; }
        public override double cost()
        {
            double cost = _beverage.cost() + .20;
            return addSizeCost(_beverage.size, cost);
        }
    }
    public class Whip : CondimentDecorator
    {
        private Beverage _beverage;
        public Whip(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => _beverage.Description + ", Whip";
        public override double cost()
        {
            double cost = _beverage.cost() + .20;
            return addSizeCost(_beverage.size, cost);
        }
    }
    public class Soy : CondimentDecorator
    {
        private Beverage _beverage;
        public Soy(Beverage beverage)
        {
            _beverage = beverage;
        }
        public override string Description => _beverage.Description + ", Soy";
        public override double cost()
        {
            double cost = _beverage.cost() + .20;
            return addSizeCost(_beverage.size, cost);
        }
    }
}
