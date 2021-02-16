using RemoteControlAPI.Interfaces;

namespace RemoteControlAPI.Devices
{
    public class SimpleRemoteControl
    {
        public SimpleRemoteControl() { }
        Command slot;
        public void setCommand(Command command)
        {
            slot = command;
        }
        public void buttonWasPressed()
        {
            slot.execute();
        }
    }
}
