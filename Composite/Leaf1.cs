using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Leaf1 : IComponent
    {
        public void Execute()
        {
            Console.WriteLine("1번 잎");
        }
    }
}
