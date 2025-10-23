namespace CommandPattern.Interfaces;

internal interface Command
{
    public void Execute();
    public void Undo();
}