using StrategyPattern.Ducks;
using StrategyPattern.Interfaces.FlyBehavior;

namespace StrategyPattern
{
    internal class Program
    {
        static void Main(string[] args)
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
        }

        static void TestDuck(Duck duck)
        {
            duck.Display();
            duck.PerformQuack();
            duck.PerformFly();
            duck.PerformSink();
            duck.Swim();
            Console.WriteLine();
        }
    }
}