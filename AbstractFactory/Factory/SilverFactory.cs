using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.A;
using AbstractFactory.B;

namespace AbstractFactory.Factory
{
    public class SilverFactory : IAbstractFactory
    {
        public ProductAxe CreateProductA()
        {
            ProductAxe A = new ProductAxe2();
            A.name = "은";
            A.type = "도끼";
            return A;
        }

        public ProductSword CreateProductB()
        {
            ProductSword B = new ProductSword2();
            B.name = "은";
            B.type = "검";
            return B;
        }
    }
}
