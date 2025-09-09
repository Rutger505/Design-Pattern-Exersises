using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.Interfaces.SinkBehaviour;

internal class SinkRegular : SinkBehaviour
{
    public void Sink()
    {
        Console.WriteLine("I am sinking!!");
    }
}