﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    internal class PopcornPopper
    {
        public void On()
        {
            Console.WriteLine("PopcornPopper -> On called!");
        }

        public void Off()
        {
            Console.WriteLine("PopcornPopper -> Off called!");
        }

        public void Pop()
        {
            Console.WriteLine("PopcornPopper -> Pop called!");
        }
    }
}
