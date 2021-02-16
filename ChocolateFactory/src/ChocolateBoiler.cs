using System;

namespace ChocolateFactory
{
    public sealed class ChocolateBoiler
    {
        private bool boiled;
        private bool empty;
        private ChocolateBoiler()
        {
            empty = true;
            boiled = false;
        }
        private static readonly Lazy<ChocolateBoiler> lazy = new Lazy<ChocolateBoiler>(() => new ChocolateBoiler());
        public static ChocolateBoiler INSTANCE { get => lazy.Value; }
    }
}
