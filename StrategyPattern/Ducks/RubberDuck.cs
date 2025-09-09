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
    internal class RubberDuck() : Duck(new Squeak(), new FlyNoWay(), new SinkNever())
    {
        public override void Display()
        {
            Console.WriteLine("I'm a Rubber Duck");
        }
    }
}