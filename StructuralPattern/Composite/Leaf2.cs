﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Leaf2 : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("2번 잎");
        }
    }
}
