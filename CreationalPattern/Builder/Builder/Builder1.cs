using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class Builder1 : Ibuilder
    {
        private Product1 result;

        public void Reset()
        {
            result = new Product1();
        }
        public void BuildStepA()
        {
            result.name = "철수";
        }

        public void BuildStepB()
        {
            result.age = 20;
        }

        public void BuildStepC()
        {
            result.phoneNumber = "010-1234-1234";
        }


        public Product1 GetResult()
        {
            return this.result;
        }
    }
}
