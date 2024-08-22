using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Proxy : IService
    {
        private Service realService;

        public Proxy(Service service)
        {
            this.realService = service;
        }

        public bool CheckAccess()
        {
            Console.WriteLine("연결 중");
            Console.WriteLine("연결 됨!");
            return true;
        }

        public void Operation()
        {
            if (CheckAccess())
            {
                realService.Operation();
            }
        }
    }
}
