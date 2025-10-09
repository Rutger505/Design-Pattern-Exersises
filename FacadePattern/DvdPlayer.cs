using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class DvdPlayer
    {
        private Amplifier _amplifier;
        public DvdPlayer(Amplifier amplifier)
        {
            _amplifier = amplifier;
        }

        public void On()
        {
            Console.WriteLine("DvdPlayer -> On called!");
        }
        public void Off()
        {
            Console.WriteLine("DvdPlayer -> Off called!");
        }
        public void Eject()
        {
            Console.WriteLine("DvdPlayer -> Eject called!");
        }
        public void Pause()
        {
            Console.WriteLine("DvdPlayer -> Pause called!");
        }
        public void Play(string movie)
        {
            Console.WriteLine("DvdPlayer -> Play called!");
        }
        public void SetSurroundAudio()
        {
            Console.WriteLine("DvdPlayer -> SetSurroundAudio called!");
        }
        public void SetTWoChannelAudio()
        {
            Console.WriteLine("DvdPlayer -> SetTWoChannelAudio called!");
        }
        public void Stop()
        {
            Console.WriteLine("DvdPlayer -> Stop called!");
        }
    }
}
