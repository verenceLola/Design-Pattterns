using RemoteControlAPI.Devices;
using RemoteControlAPI.Interfaces;


namespace RemoteControlAPI.Commands
{
    public class CeilingFanOnCommand : Command
    {
        private CeilingFan _ceilingFan;
        public CeilingFanOnCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void execute()
        {
            _ceilingFan.on();
        }
    }
    public class CeilingFanOffCommand : Command
    {
        private CeilingFan _ceilingFan;
        public CeilingFanOffCommand(CeilingFan ceilingFan)
        {
            _ceilingFan = ceilingFan;
        }
        public void execute()
        {
            _ceilingFan.off();
        }
    }
}
