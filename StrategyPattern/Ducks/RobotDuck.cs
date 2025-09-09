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
            SetQuackBehavior(new Squeak());
            SetFlyBehavior(new FlyNoWay());
            SetSinkBehavior(new SinkRegular());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Robot Duck");
        }
    }
}