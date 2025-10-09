﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class TheaterLights
    {
        public void On()
        {
            Console.WriteLine("TheaterLights -> On called!");
        }

        public void Off()
        {
            Console.WriteLine("TheaterLights -> Off called!");
        }

        public void Dim(int value)
        {
            Console.WriteLine("TheaterLights -> Dim called!");
        }
    }
}
