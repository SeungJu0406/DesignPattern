using AbstractFactory.A;
using AbstractFactory.B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.Factory
{
    public class GoldFactory : IAbstractFactory
    {
        public ProductAxe CreateProductA()
        {
            ProductAxe A = new ProductAxe1();
            A.name = "금";
            A.type = "도끼";
            return A;
        }

        public ProductSword CreateProductB()
        {
            ProductSword B = new ProductSword1();
            B.name = "금";
            B.type = "검";
            return B;
        }
    }
}
