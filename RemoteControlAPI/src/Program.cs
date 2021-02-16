using System;
using RemoteControlAPI.Devices;
using RemoteControlAPI.Commands;

namespace RemoteControlAPI
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            SimpleRemoteControl remoteControl = new SimpleRemoteControl();
            Light light = new Light();
            GarageDoor garageDoor = new GarageDoor();

            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor: garageDoor);
            LightOnCommand lightOn = new LightOnCommand(light: light);

            remoteControl.setCommand(lightOn);
            remoteControl.buttonWasPressed();

            remoteControl.setCommand(garageDoorOpen);
            remoteControl.buttonWasPressed();
        }
    }
}
