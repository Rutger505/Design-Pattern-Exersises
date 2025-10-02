using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks;

internal class MallardDuck() : Duck(new RegularQuack(), new FlyWithWings(), new SinkNever())
{
    public override void Display()
    {
        Console.WriteLine("I'm a Mallard Duck");
    }
}