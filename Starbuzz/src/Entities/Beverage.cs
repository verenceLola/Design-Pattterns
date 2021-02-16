namespace Starbuzz.Entities
{
    public abstract class Beverage
    {
        public enum Size { TALL, GRANDE, VENTI };
        public Size size { get; set; }
        public virtual string Description { get; protected set; } = "Unknown bevarage";

        public abstract double cost();
    }

    public class Expresso : Beverage
    {
        public Expresso()
        {
            Description = "Expresso";
        }
        public override double cost() => 1.99;
    }
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            Description = "House Blend Coffee";
        }
        public override double cost() => .89;
    }
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            Description = "Dark Roast";
        }
        public override double cost() => .99;
    }
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf";
        }
        public override double cost() => 1.09;
    }
}
