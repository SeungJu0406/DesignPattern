using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class TestClass : IImplementation
    {
        public void Method1()
        {
            Console.WriteLine("테스트 1번");
        }

        public void Method2()
        {
            Console.WriteLine("테스트 2번");
        }
    }
}
