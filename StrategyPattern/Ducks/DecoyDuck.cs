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
    internal class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            SetQuackBehavior(new MuteQuack());
            SetFlyBehavior(new FlyNoWay());
            SetSinkBehavior(new SinkNever());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a Decoy Duck");
        }
    }
}