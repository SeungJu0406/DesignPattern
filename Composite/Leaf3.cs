using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    internal class Leaf3 : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("3번 잎");
        }
    }
}
