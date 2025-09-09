using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SinkBehaviour;

internal class SinkNever : SinkBehaviour
{
    public void Sink()
    {
        Console.WriteLine("I never sink!");
    }
}