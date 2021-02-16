using RemoteControlAPI.Devices;
using RemoteControlAPI.Interfaces;

namespace RemoteControlAPI.Commands
{
    public class GarageDoorOpenCommand : Command
    {
        private GarageDoor _garageDoor;
        public GarageDoorOpenCommand(GarageDoor garageDoor)
        {
            _garageDoor = garageDoor;
        }
        public void execute()
        {
            _garageDoor.up();
        }
    }
}
