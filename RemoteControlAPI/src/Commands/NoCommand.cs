using System;
using RemoteControlAPI.Interfaces;

namespace RemoteControlAPI.Commands
{
    public class NoCommand : Command
    {
        public void execute()
        {
            Console.WriteLine("Slot not configured!");
        }
    }
}
