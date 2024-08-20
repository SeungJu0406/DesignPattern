using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPettern.FactoryMethod
{
    public abstract class Creator
    {
        public void SomeOperation()
        {
            IProduct p = CreateProduct();
            p.DoStuff();
        }
        public abstract IProduct CreateProduct();
    }
}
