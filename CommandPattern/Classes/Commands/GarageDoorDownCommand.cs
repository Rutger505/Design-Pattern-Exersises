using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class GarageDoorDownCommand : Command
{
    private GarageDoor garageDoor;

    public GarageDoorDownCommand(GarageDoor garageDoor)
    {
        this.garageDoor = garageDoor;
    }

    public void Execute()
    {
    }

    public void Undo()
    {
    }
}