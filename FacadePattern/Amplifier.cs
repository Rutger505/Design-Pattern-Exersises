using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class Amplifier
    {
        private Tuner _tuner;
        private DvdPlayer _dvdPlayer;
        private CdPlayer _cdPlayer;

        public void On()
        {
            Console.WriteLine("Amplifier -> On called!");
        }

        public void Off()
        {
            Console.WriteLine("Amplifier -> Off called!");
        }
        public void SetCd(CdPlayer cdPlayer)
        {
            Console.WriteLine("Amplifier -> SetCd called!");
            this._cdPlayer = cdPlayer;
        }
        public void SetDvd(DvdPlayer dvdPlayer)
        {
            Console.WriteLine("Amplifier -> SetDvd called!");
            this._dvdPlayer = dvdPlayer;
        }
        public void SetStereoSound()
        {
            Console.WriteLine("Amplifier -> SetStereoSound called!");
        }
        public void SetSurroundSound()
        {
            Console.WriteLine("Amplifier -> SetSurroundSound called!");
        }
        public void SetTuner(Tuner tuner)
        {
            Console.WriteLine("Amplifier -> SetTuner called!");
            this._tuner = tuner;
        }
        public void SetVolume(int volume)
        {
            Console.WriteLine("Amplifier -> SetVolume called!");
        }

    }
}
