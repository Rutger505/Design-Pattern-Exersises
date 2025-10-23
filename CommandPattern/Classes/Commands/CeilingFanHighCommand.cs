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
        prevSpeed = ceilingFan.GetSpeed();
        ceilingFan.High();
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