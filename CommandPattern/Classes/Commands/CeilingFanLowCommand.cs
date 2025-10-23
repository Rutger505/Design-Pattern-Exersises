using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class CeilingFanLowCommand : Command
{
    private CeilingFan ceilingFan;
    private int prevSpeed;

    public CeilingFanLowCommand(CeilingFan ceilingFan)
    {
    }

    public void Execute()
    {
    }

    public void Undo()
    {
    }
}