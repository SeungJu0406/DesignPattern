using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    public class Abstraction
    {
        private IImplementation i;

        public Abstraction(IImplementation i)
        {
            this.i = i;
        }

        public void ChangeImplementation(IImplementation i)
        {
            this.i = i;
        }
        public void Feature1()
        {
            i.Method1();
        }

        public void Feature2() 
        {
            i.Method2();
        }
    }
}
