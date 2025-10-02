namespace StrategyPattern.Interfaces.SinkBehaviour;

internal class SinkNever : SinkBehaviour
{
    public void Sink()
    {
        Console.WriteLine("I never sink!");
    }
}