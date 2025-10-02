using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks;

internal class RobotDuck() : Duck(new Squeak(), new FlyNoWay(), new SinkRegular())
{
    public override void Display()
    {
        Console.WriteLine("I'm a Robot Duck");
    }
}