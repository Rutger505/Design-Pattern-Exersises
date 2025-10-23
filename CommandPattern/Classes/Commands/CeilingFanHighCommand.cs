using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class CeilingFanHighCommand : Command
{
    private CeilingFan ceilingFan;
    private int prevSpeed;

    public CeilingFanHighCommand(CeilingFan ceilingFan)
    {
        this.ceilingFan = ceilingFan;
    }

    public void Execute()
    {
    }

    public void Undo()
    {
    }
}