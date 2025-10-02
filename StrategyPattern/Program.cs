using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern;

internal class Program
{
    private static void Main(string[] args)
    {
        Duck mallardDuck = new MallardDuck();
        Duck redheadDuck = new RedheadDuck();
        Duck decoyDuck = new DecoyDuck();
        Duck rubberDuck = new RubberDuck();
        Duck robotDuck = new RobotDuck();

        TestDuck(mallardDuck);
        TestDuck(redheadDuck);
        TestDuck(decoyDuck);
        TestDuck(rubberDuck);
        TestDuck(robotDuck);

        Console.WriteLine(
            "Changing RobotDuck's behaviors to FlyWithWings, RegularQuack, and SinkNever at runtime:"
        );
        robotDuck.FlyBehavior = new FlyWithWings();
        robotDuck.QuackBehavior = new RegularQuack();
        robotDuck.SinkBehavior = new SinkNever();
        TestDuck(robotDuck);
    }

    private static void TestDuck(Duck duck)
    {
        duck.Display();
        duck.PerformQuack();
        duck.PerformFly();
        duck.PerformSink();
        duck.Swim();
        Console.WriteLine();
    }
}