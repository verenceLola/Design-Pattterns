using RemoteControlAPI.Interfaces;
using RemoteControlAPI.Devices;

namespace RemoteControlAPI.Commands
{
    public class LightOnCommand : Command
    {
        private Light _light;
        public LightOnCommand(Light light)
        {
            _light = light;
        }
        public void execute() => _light.on();
    }
    public class LightOffCommand : Command
    {
        private Light _light;
        public LightOffCommand(Light light)
        {
            _light = light;
        }
        public void execute() => _light.off();
    }
}
