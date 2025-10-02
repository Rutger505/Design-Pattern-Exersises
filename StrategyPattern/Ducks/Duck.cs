using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks;

internal abstract class Duck(
    QuackBehavior _quackBehavior,
    FlyBehavior _flyBehavior,
    SinkBehaviour _sinkBehavior)
{
    public QuackBehavior QuackBehavior { private get; set; } = _quackBehavior;
    public FlyBehavior FlyBehavior { private get; set; } = _flyBehavior;
    public SinkBehaviour SinkBehavior { private get; set; } = _sinkBehavior;

    public abstract void Display();

    public void PerformQuack()
    {
        QuackBehavior.Quack();
    }

    public void PerformSink()
    {
        SinkBehavior.Sink();
    }

    public void PerformFly()
    {
        FlyBehavior.Fly();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float, even decoys!");
    }
}