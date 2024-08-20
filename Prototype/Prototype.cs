using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    public class Prototype : IPrototype
    {
        public string field1 {  get; private set; }

        public Prototype()
        {
            this.field1 = "도라에몽";
        }



        public Prototype(Prototype prototype)
        {
            this.field1 = prototype.field1;
        }

        public Prototype Clone()
        {
            return new Prototype(this);
        }
    }
}
