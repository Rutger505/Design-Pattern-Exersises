using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Interfaces
{
    internal interface Observer
    {
        void Update(float newTemperature, float humidity, float pressure);
    }
}