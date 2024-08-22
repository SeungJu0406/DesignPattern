using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Service : IService
    {
        public void Operation()
        {
            Console.WriteLine("프록시");
        }
    }
}
