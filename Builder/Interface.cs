using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface Ibuilder
    {
        public void Reset();
        public void BuildStepA();
        public void BuildStepB();
        public void BuildStepC();
    }
}
