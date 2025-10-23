using System.Text;
using CommandPattern.Classes.Commands;
using CommandPattern.Interfaces;

namespace CommandPattern.Classes;

internal class RemoteControl
{
    private readonly Command[] offCommands = new Command[7];
    private readonly Command[] onCommands = new Command[7];
    private Command undoCommand;
    private readonly Stack<Command> undoHistory = new();

    public RemoteControl()
    {
        Command noCommand = new NoCommand();
        for (var i = 0; i < onCommands.Length; i++)
        {
            onCommands[i] = new NoCommand();
            offCommands[i] = new NoCommand();
        }

        undoCommand = noCommand;
    }

    // This method must set the On and Off command to the slot provided
    public void SetCommand(int slot, Command onCommand, Command offCommand)
    {
        onCommands[slot] = onCommand;
        offCommands[slot] = offCommand;
    }

    // This method must call the OnCommand.Execute() method of the slot provided
    public void OnButtonWasPushed(int slot)
    {
        onCommands[slot].Execute();
        undoCommand = onCommands[slot];
        undoHistory.Push(onCommands[slot]);
    }

    // This method must call the OffCommand.Execute() method of the slot provided
    public void OffButtonWasPushed(int slot)
    {
        offCommands[slot].Execute();
        undoCommand = offCommands[slot];
        undoHistory.Push(offCommands[slot]);
    }

    public void UndoButtonWasPushed()
    {
        undoCommand.Undo();
        if (undoHistory.Count > 0)
        {
            undoHistory.Pop();
            undoCommand = undoHistory.Count > 0 ? undoHistory.Peek() : new NoCommand();
        }
    }

    // Overwritten ToString() to print out each slot and its corresponding command.
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.Append("\n----- Remote Control ----- \n");
        for (var i = 0; i < onCommands.Length; i++)
            sb.Append("[slot " + i + "] " + onCommands[i] + " \t\t  " + offCommands[i] + "\n");
        return sb.ToString();
    }
}