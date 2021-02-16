using System;

namespace RemoteControlAPI.Devices
{
    public class Light
    {
        private string _spaceName;
        public Light(string spaceName)
        {
            _spaceName = spaceName;
        }
        public void on()
        {
            Console.WriteLine($"{_spaceName} Light is On ...");
        }
        public void off()
        {
            Console.WriteLine($"{_spaceName} Light is Off ...");
        }
    }
}
