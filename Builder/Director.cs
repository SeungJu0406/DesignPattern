using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Director
    {
        public Ibuilder Ibuilder;

        public void ChangeBuilder(Ibuilder Ibuilder)
        {
            this.Ibuilder = Ibuilder;
        }
        public void Make(IsPhoneNumber isPhoneNumber)
        {
            Ibuilder.Reset();
            Ibuilder.BuildStepA();
            Ibuilder.BuildStepB();
            if(isPhoneNumber == IsPhoneNumber.Yes)
            {
                Ibuilder.BuildStepC();
            }
        }

    }
}
