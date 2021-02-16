using RemoteControlAPI.Interfaces;
using RemoteControlAPI.Commands;
using System.Text;
using System;

namespace RemoteControlAPI.Devices
{
    public class SimpleRemoteControl
    {
        public SimpleRemoteControl() { }
        Command slot;
        public void setCommand(Command command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.execute();
        }
    }

    public class RemoteControl
    {
        Command[] onCommands, offCommands;
        public void NoCommand()
        {
            Console.WriteLine("Slot not Configured!!");
        }
        public RemoteControl()
        {
            onCommands = new Command[7];
            offCommands = new Command[7];

            Command noCommand = new Command(NoCommand);
            for (int i = 0; i < 7; i++)
            {
                onCommands[i] = noCommand;
                offCommands[i] = noCommand;
            }
        }
        public delegate void Command();
        public void setCommand(int slot, Command onCommand, Command offCommand)
        {
            onCommands[slot] = onCommand;
            offCommands[slot] = offCommand;
        }
        public void onButtonWasPushed(int slot)
        {
            onCommands[slot].Invoke();
        }
        public void offButtonWasPushed(int slot)
        {
            offCommands[slot].Invoke();
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();

            for (int i = 0; i < onCommands.Length; i++)
            {
                stringBuilder.Append($"[slot " + i + "] " + onCommands[i].GetType().Name + "   " + offCommands[i].GetType().Name);
                stringBuilder.AppendLine();
            }

            return stringBuilder.ToString();
        }
    }
}
