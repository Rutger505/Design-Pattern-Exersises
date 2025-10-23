using CommandPattern.Interfaces;

namespace CommandPattern.Classes.Commands;

internal class StereoOnWithRadioCommand : Command
{
    private Stereo stereo;

    public StereoOnWithRadioCommand(Stereo stereo)
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