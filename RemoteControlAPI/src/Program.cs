using System;
using RemoteControlAPI.Devices;
using RemoteControlAPI.Commands;
using RemoteControlAPI.Interfaces;


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

            // remoteControl.setCommand(0, () => livingRoomLight.on(), () => livingRoomLight.off());
            // remoteControl.setCommand(1, () => kitchenLight.on(), () => kitchenLight.off());
            // remoteControl.setCommand(2, () => ceilingFan.on(), () => ceilingFan.off());
            // remoteControl.setCommand(3, () => stereo.on(), () => stereo.off());

            // remoteControl.onButtonWasPushed(0);
            // remoteControl.offButtonWasPushed(0);
            // remoteControl.onButtonWasPushed(1);
            // remoteControl.offButtonWasPushed(1);
            // remoteControl.onButtonWasPushed(2);
            // remoteControl.offButtonWasPushed(2);
            // remoteControl.onButtonWasPushed(3);
            // remoteControl.offButtonWasPushed(3);
            LightOnCommand lightOn = new LightOnCommand(livingRoomLight);
            StereoOnWithCDCommand stereoOn = new StereoOnWithCDCommand(stereo);
            GarageDoorOpenCommand garageDoorOpen = new GarageDoorOpenCommand(garageDoor);

            LightOffCommand lightOff = new LightOffCommand(livingRoomLight);
            StereoOffCommand stereoOff = new StereoOffCommand(stereo);
            GarageDoorCloseCommand garageDoorClose = new GarageDoorCloseCommand(garageDoor);

            Command[] partyOn = { lightOn, stereoOn, garageDoorOpen };
            Command[] partyOff = { lightOff, stereoOff, garageDoorClose };

            MacroCommand partyOnMacro = new MacroCommand(partyOn);
            MacroCommand partOffMacro = new MacroCommand(partyOff);

            remoteControl.setCommand(0, partyOnMacro, partOffMacro);

            Console.WriteLine("------Pushing Macro On -------");
            Console.WriteLine();
            remoteControl.onButtonWasPushed(0);
            Console.WriteLine();
            Console.WriteLine("------Pushing Macro Off ------");
            Console.WriteLine();
            remoteControl.offButtonWasPushed(0);
        }
    }
}
