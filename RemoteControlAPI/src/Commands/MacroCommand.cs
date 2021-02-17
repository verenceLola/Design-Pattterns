using System.Collections.Generic;
using RemoteControlAPI.Interfaces;
using System.Linq;


namespace RemoteControlAPI.Commands
{
    class MacroCommand : Command
    {
        private Command[] _commands;
        public MacroCommand(Command[] commands)
        {
            _commands = commands;
        }
        public void execute()
        {
            foreach (Command command in _commands)
            {
                command.execute();
            }
        }
    }
}
