using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class LightOffCommand : Command
{
    private Light light;

    public LightOffCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
    }

    public void Undo()
    {
    }
}