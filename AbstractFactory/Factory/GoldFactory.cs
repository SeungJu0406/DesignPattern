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
            ProductAxe axe = new ProductAxe1();
            axe.name = "금";
            axe.type = "도끼";
            return axe;
        }

        public ProductSword CreateProductB()
        {
            ProductSword sword = new ProductSword1();
            sword.name = "금";
            sword.type = "검";
            return sword;
        }
    }
}
