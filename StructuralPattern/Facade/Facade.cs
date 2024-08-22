using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Facade.SubClass;

namespace Facade
{
    public class Facade
    {
        SubClass1 sub1;
        SubClass2 sub2;
        SubClass3 sub3;
        private AdditionalFacade additional;
        public Facade()
        {
            this.sub1 = new SubClass1();
            this.sub2 = new SubClass2();
            this.sub3 = new SubClass3();
        }
        public void SubClassOperation()
        {
            sub1.PrintFacade();
            sub2.PrintFacade();
            sub3.PrintFacade();
        }           
    }
}
