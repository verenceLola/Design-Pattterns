using System;

namespace RemoteControlAPI.Devices
{
    public class GarageDoor
    {
        public GarageDoor() { }
        public string name = "Garage Door";
        public void up()
        {
            Console.WriteLine("Garage Door is Open");
        }
        public void down()
        {
            Console.WriteLine("Garage Door is Closed");
        }
        public void stop()
        {
            Console.WriteLine("Garage Door is Stopped");
        }
    }
}
