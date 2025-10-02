namespace StrategyPattern.Interfaces.SinkBehaviour;

internal class SinkRegular : SinkBehaviour
{
    public void Sink()
    {
        Console.WriteLine("I am sinking!!");
    }
}