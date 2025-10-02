using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks;

internal class DecoyDuck() : Duck(new MuteQuack(), new FlyNoWay(), new SinkNever())
{
    public override void Display()
    {
        Console.WriteLine("I'm a Decoy Duck");
    }
}