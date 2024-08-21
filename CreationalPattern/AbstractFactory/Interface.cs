using AbstractFactory.A;
using AbstractFactory.B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public interface IAbstractFactory
    {
        public ProductAxe CreateProductA();

        public ProductSword CreateProductB();
    }
}
