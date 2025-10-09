using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class CdPlayer
    {
        private Amplifier _amplifier;
        public CdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("CdPlayer -> On called!");
        }
        public void Off()
        {
            Console.WriteLine("CdPlayer -> Off called!");
        }
        public void Eject()
        {
            Console.WriteLine("CdPlayer -> Eject called!");
        }
        public void Pause()
        {
            Console.WriteLine("CdPlayer -> Pause called!");
        }
        public void Play()
        {
            Console.WriteLine("CdPlayer -> Play called!");
        }
        public void Stop()
        {
            Console.WriteLine("CdPlayer -> Stop called!");
        }
    }
}
