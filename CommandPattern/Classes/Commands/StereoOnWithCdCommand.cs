using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class StereoOnWithCdCommand : Command
{
    private Stereo stereo;

    public StereoOnWithCdCommand(Stereo stereo)
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