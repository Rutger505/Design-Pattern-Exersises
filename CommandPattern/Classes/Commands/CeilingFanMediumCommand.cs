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
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.Medium();
    }

    public void Undo()
    {
        if (prevSpeed == ceilingFan.HIGH)
            ceilingFan.High();
        else if (prevSpeed == ceilingFan.MEDIUM)
            ceilingFan.Medium();
        else if (prevSpeed == ceilingFan.LOW)
            ceilingFan.Low();
        else if (prevSpeed == ceilingFan.OFF)
            ceilingFan.Off();
    }
}