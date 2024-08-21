using AbstractFactory.A;
using AbstractFactory.B;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Client
    {
        private IAbstractFactory factory;

        public Client(IAbstractFactory abstractFactory)
        {
           factory = abstractFactory;
        }
        public void AxeOperation()
        {
            ProductAxe A = factory.CreateProductA();

            Console.WriteLine($"{A.name}{A.type}");
        }
        public void SwordOperation()
        {
            ProductSword B = factory.CreateProductB();

            Console.WriteLine($"{B.name}{B.type}");
        }
    }
}
