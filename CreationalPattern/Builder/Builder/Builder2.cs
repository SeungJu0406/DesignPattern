using Builder.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder.Builder
{
    public class Builder2 : Ibuilder
    {
        private Product2 result;

        public void Reset()
        {
            result = new Product2();
        }
        public void BuildStepA()
        {
            result.name = "짱구";
        }

        public void BuildStepB()
        {
            result.age = 5;
        }

        public void BuildStepC()
        {
            result.phoneNumber = "010-6789-6789";
        }


        public Product2 GetResult()
        {
            return this.result;
        }
    }
}
