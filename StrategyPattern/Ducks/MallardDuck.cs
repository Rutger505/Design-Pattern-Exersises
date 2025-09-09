using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks
{
    internal class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetQuackBehavior(new RegularQuack());
            SetFlyBehavior(new FlyWithWings());
            SetSinkBehavior(new SinkNever());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Mallard Duck");
        }
    }
}