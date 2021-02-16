using System;


namespace RemoteControlAPI.Devices
{
    public class CeilingFan
    {
        private string _spaceName;
        public CeilingFan(string spaceName)
        {
            _spaceName = spaceName;
        }
        public void on()
        {
            Console.WriteLine($"{_spaceName} Ceiling Fan is On");
        }
        public void off()
        {
            Console.WriteLine($"{_spaceName} Ceiling Fan is Off");
        }
    }
}
