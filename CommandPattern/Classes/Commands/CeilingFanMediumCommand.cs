using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class CeilingFanMediumCommand : Command
{
    private CeilingFan ceilingFan;
    private int prevSpeed;

    public CeilingFanMediumCommand(CeilingFan ceilingFan)
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