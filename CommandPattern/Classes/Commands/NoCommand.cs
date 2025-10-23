using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class NoCommand : Command
{
    public void Execute()
    {
    }

    public void Undo()
    {
    }
}