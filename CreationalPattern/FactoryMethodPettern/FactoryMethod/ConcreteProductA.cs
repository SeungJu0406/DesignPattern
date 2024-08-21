using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPettern.FactoryMethod
{
    public class ConcreteProductA : IProduct
    {
        public string name { get; set; }
        public void DoStuff()
        {
            Console.WriteLine($"{name}");
        }
    }
}
