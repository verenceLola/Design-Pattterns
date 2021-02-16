using System;

namespace RemoteControlAPI.Devices
{
    public class Light
    {
        public string name = "Light";
        public void on()
        {
            Console.WriteLine("Light is On ...");
        }
        public void off()
        {
            Console.WriteLine("Light is Off ...");
        }
    }
}
