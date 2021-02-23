using System;
using System.Text;
using JawBreakers.Interfaces;
using JawBreakers.States;

namespace JawBreakers.Entities
{
    public class GumballMachine
    {
        public IState SoldOutState { get; private set; }
        public IState NoQuarterState { get; private set; }
        public IState HasQuarterState { get; private set; }
        public IState SoldState { get; private set; }
        public IState WinnerState { get; private set; }

        public IState State { get; private set; } 
        public int Count { get; private set; } = 0;
        public GumballMachine(int numberGumballs)
        {
            Count = numberGumballs;
            SoldOutState = new SoldOutState(this);
            NoQuarterState = new NoQuarterState(this);
            HasQuarterState = new HasQuarterState(this);
            SoldState = new SoldState(this);
            WinnerState = new WinnerState(this);
            State = SoldOutState;
        }
        public void insertQuarter()
        {
            State.insertQuarter();
        }
        public void ejectQuarter()
        {
            State.ejectQuarter();
        }
        public void turnCrank()
        {
            State.turnCrank();
            State.dispense();
        }
        public void setState(IState state)
        {
            State = state;
        }
        public void releaseBall()
        {
            Console.WriteLine("A gumball comes rolling out the slot ...");

            if (Count > 0)
            {
                Count = -1;
            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Mighty Gumball, Inc.");
            stringBuilder.AppendLine();
            stringBuilder.Append("C#-enabled Standing Gumball Model #2021");
            stringBuilder.AppendLine();
            stringBuilder.Append($"Inventory: {Count} gumballs");
            stringBuilder.AppendLine();
            stringBuilder.Append("Machine is waiting for quarter");
            stringBuilder.AppendLine();

            if (State == SoldOutState)
            {
                stringBuilder.Append("Machine is sold out");
            }

            return stringBuilder.ToString();
        }
    }
}
