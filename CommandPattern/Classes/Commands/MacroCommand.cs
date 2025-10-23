using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class MacroCommand : Command
{
    private readonly Command[] commands;

    public MacroCommand(Command[] commands)
    {
        this.commands = commands;
    }

    public void Execute()
    {
        foreach (var c in commands) c.Execute();
    }

    public void Undo()
    {
        foreach (var c in commands) c.Undo();
    }
}