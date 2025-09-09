using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks
{
    internal class RobotDuck : Duck
    {
        public RobotDuck()
        {
            quackBehavior = new Squeak();
            flyBehavior = new FlyNoWay();
            sinkBehaviour = new SinkRegular();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}