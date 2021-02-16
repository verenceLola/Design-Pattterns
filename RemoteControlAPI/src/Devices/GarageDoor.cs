using System;

namespace RemoteControlAPI.Devices
{
    public class GarageDoor
    {
        private string _spaceName;
        public GarageDoor(string spaceName)
        {
            _spaceName = spaceName;
        }
        public void up()
        {
            Console.WriteLine($"{_spaceName} Garage Door is Open");
        }
        public void down()
        {
            Console.WriteLine($"{_spaceName} Garage Door is Closed");
        }
        public void stop()
        {
            Console.WriteLine($"{_spaceName} Garage Door is Stopped");
        }
    }
}
