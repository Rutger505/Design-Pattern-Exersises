using StrategyPattern.Interfaces.FlyBehavior;
using StrategyPattern.Interfaces.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.Interfaces.SinkBehaviour;

namespace StrategyPattern.Ducks
{
    internal abstract class Duck(
        QuackBehavior _quackBehavior,
        FlyBehavior _flyBehavior,
        SinkBehaviour _sinkBehavior)
    {
        public QuackBehavior QuackBehavior { private get; set; } = _quackBehavior;
        public FlyBehavior FlyQBehavior { get; } = _flyBehavior;
        public SinkBehaviour SinkBehavior { get; } = _sinkBehavior;

        public abstract void Display();

        public void PerformQuack()
        {
            QuackBehavior.Quack();
        }

        public void PerformSink()
        {
            SinkBehavior.Sink();
        }

        public void PerformFly()
        {
            FlyQBehavior.Fly();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}