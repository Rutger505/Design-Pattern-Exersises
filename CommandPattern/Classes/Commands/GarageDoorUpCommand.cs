using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class GarageDoorUpCommand : Command
{
    private GarageDoor garageDoor;

    public GarageDoorUpCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
        garageDoor.Up();
    }

    public void Undo()
    {
        garageDoor.Down();
    }
}