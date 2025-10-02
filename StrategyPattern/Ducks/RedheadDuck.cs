using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks;

internal class RedheadDuck() : Duck(new RegularQuack(), new FlyWithWings(), new SinkNever())
{
    public override void Display()
    {
        Console.WriteLine("I'm a RedHead Duck");
    }
}