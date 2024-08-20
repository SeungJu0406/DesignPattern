using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPettern.FactoryMethod
{
    public class ConcreteCreatorB : Creator
    {
        public override IProduct CreateProduct()
        {
            ConcreteProductB B = new ConcreteProductB();
            B.name = "사과";
            return B;
        }
    }
}
