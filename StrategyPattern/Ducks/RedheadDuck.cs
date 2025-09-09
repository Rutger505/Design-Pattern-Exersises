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
    internal class RedheadDuck : Duck
    {
        public RedheadDuck()
        {
            quackBehavior = new RegularQuack();
            flyBehavior = new FlyWithWings();
            sinkBehaviour = new SinkNever();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a RedHead Duck");
        }
    }
}