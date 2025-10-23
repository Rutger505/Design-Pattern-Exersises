using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class CeilingFanOffCommand : Command
{
    private CeilingFan ceilingFan;
    private int prevSpeed;

    public CeilingFanOffCommand(CeilingFan ceilingFan)
    {
    }

    public void Execute()
    {
    }

    public void Undo()
    {
    }
}