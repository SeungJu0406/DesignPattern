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
            ProductAxe axe = new ProductAxe2();
            axe.name = "은";
            axe.type = "도끼";
            return axe;
        }

        public ProductSword CreateProductB()
        {
            ProductSword sword = new ProductSword2();
            sword.name = "은";
            sword.type = "검";
            return sword;
        }
    }
}
