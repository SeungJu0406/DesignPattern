using Facade.SubClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class AdditionalFacade
    {
        private SubClass4 SubClass4;
        private SubClass5 SubClass5;

        public AdditionalFacade()
        {
            SubClass4 = new SubClass4();
            SubClass5 = new SubClass5();
        }

        public void AnotherOperation()
        {
            SubClass4.PrintFacade();
            SubClass5.PrintFacade();
        }
    }
}
