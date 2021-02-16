using System;

namespace Starbuzz.Entities
{
    public abstract class CondimentDecorator : Beverage
    {
        public abstract override string Description { get; }
        public double addSizeCost(Size size, double cost) =>
            size switch
            {
                Size.TALL => cost + .10,
                Size.GRANDE => cost + .15,
                Size.VENTI => cost + .20,
                _ => throw new ArgumentException(message: "Invalid size"),
            };
    }
}
