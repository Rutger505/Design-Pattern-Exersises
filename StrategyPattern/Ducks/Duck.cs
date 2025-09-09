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
    internal abstract class Duck
    {
        private QuackBehavior quackBehavior;
        private FlyBehavior flyBehavior;
        private SinkBehaviour sinkBehavior;

        public abstract void Display();

        public void PerformQuack()
        {
            quackBehavior.Quack();
        }

        public void PerformSink()
        {
            sinkBehavior.Sink();
        }

        public void PerformFly()
        {
            flyBehavior.Fly();
        }

        protected void SetFlyBehavior(FlyBehavior fb)
        {
            flyBehavior = fb;
        }

        protected void SetQuackBehavior(QuackBehavior qb)
        {
            quackBehavior = qb;
        }

        protected void SetSinkBehavior(SinkBehaviour sb)
        {
            sinkBehavior = sb;
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys!");
        }
    }
}