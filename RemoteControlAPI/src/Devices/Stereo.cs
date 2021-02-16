using System;

namespace RemoteControlAPI.Devices
{
    public class Stereo
    {

        private int _volume;
        private string _spaceName;
        public Stereo(string spaceName)
        {
            _spaceName = spaceName;
        }
        public void on()
        {
            Console.WriteLine($"{_spaceName} Stereo On");
        }
        public void off()
        {
            Console.WriteLine($"{_spaceName} Stereo Off");
        }
        public void setCD()
        {
            Console.WriteLine($"{_spaceName} Stereo CD On");
        }
        public void setVolume(int volume)
        {
            _volume = volume;
            Console.WriteLine($"{_spaceName} Stereo volume set to {volume}");
        }
    }
}
