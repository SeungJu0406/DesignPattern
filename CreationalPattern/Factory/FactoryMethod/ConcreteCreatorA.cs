using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPettern.FactoryMethod
{
    public class ConcreteCreatorA : Creator
    {
        public override IProduct CreateProduct()
        {
            ConcreteProductA A = new ConcreteProductA();
            A.name = "바나나";
            return A;
        }
    }
}
