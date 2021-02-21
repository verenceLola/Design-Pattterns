using System;

namespace HouseMergePancakes.Composite
{
    public abstract class MenuComponent
    {
        public virtual void add(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }
        public virtual void remove(MenuComponent menuComponent)
        {
            throw new InvalidOperationException();
        }
        public virtual MenuComponent getChild(int i)
        {
            throw new InvalidOperationException();
        }
        public virtual string getName()
        {
            throw new InvalidOperationException();
        }
        public virtual string getDescription()
        {
            throw new InvalidOperationException();
        }
        public virtual double getPrice()
        {
            throw new InvalidOperationException();
        }
        public virtual bool isVegetarian()
        {
            throw new InvalidOperationException();
        }
        public virtual void print()
        {
            throw new InvalidOperationException();
        }
    }
}
