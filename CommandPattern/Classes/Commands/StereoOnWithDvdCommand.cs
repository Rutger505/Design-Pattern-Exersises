using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class StereoOnWithDvdCommand : Command
{
    private Stereo stereo;

    public StereoOnWithDvdCommand(Stereo stereo)
    {
        this.stereo = stereo;
    }

    public void Execute()
    {
    }

    public void Undo()
    {
    }
}