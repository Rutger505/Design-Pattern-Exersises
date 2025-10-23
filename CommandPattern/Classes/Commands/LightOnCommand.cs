using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class LightOnCommand : Command
{
    private Light light;

    public LightOnCommand(Light light)
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