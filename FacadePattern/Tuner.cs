using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Tuner
    {
        private Amplifier _amplifier;
        public Tuner(Amplifier amplifier)
        {
            this._amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("Tuner -> On called!");
        }

        public void Off()
        {
            Console.WriteLine("Tuner -> Off called!");
        }

        public void setAM()
        {
            Console.WriteLine("Tuner -> setAM called!");
        }

        public void setFM()
        {
            Console.WriteLine("Tuner -> setFM called!");
        }

        public void setFrequency()
        {
            Console.WriteLine("Tuner -> setFrequency called!");
        }

    }
}
