using RemoteControlAPI.Devices;
using RemoteControlAPI.Interfaces;

namespace RemoteControlAPI.Commands
{
    public class StereoOnWithCDCommand : Command
    {
        private Stereo _stereo;
        public StereoOnWithCDCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void execute()
        {
            _stereo.on();
            _stereo.setCD();
            _stereo.setVolume(11);
        }
    }
    public class StereoOffCommand : Command
    {
        private Stereo _stereo;
        public StereoOffCommand(Stereo stereo)
        {
            _stereo = stereo;
        }
        public void execute()
        {
            _stereo.off();
        }
    }
}
