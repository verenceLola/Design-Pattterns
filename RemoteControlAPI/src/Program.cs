using System;
using RemoteControlAPI.Devices;


namespace RemoteControlAPI
{
    class RemoteLoader
    {
        public static void Main(string[] args)
        {
            RemoteControl remoteControl = new RemoteControl();

            Light livingRoomLight = new Light(spaceName: "Living Room");
            Light kitchenLight = new Light(spaceName: "Kitchen");
            CeilingFan ceilingFan = new CeilingFan(spaceName: "living Room");
            GarageDoor garageDoor = new GarageDoor(spaceName: "Garage");
            Stereo stereo = new Stereo(spaceName: "Living Room");

            remoteControl.setCommand(0, () => livingRoomLight.on(), () => livingRoomLight.off());
            remoteControl.setCommand(1, () => kitchenLight.on(), () => kitchenLight.off());
            remoteControl.setCommand(2, () => ceilingFan.on(), () => ceilingFan.off());
            remoteControl.setCommand(3, () => stereo.on(), () => stereo.off());

            remoteControl.onButtonWasPushed(0);
            remoteControl.offButtonWasPushed(0);
            remoteControl.onButtonWasPushed(1);
            remoteControl.offButtonWasPushed(1);
            remoteControl.onButtonWasPushed(2);
            remoteControl.offButtonWasPushed(2);
            remoteControl.onButtonWasPushed(3);
            remoteControl.offButtonWasPushed(3);

        }
    }
}
