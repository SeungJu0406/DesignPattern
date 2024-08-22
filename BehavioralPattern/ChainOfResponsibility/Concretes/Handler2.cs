using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concretes
{
    public class Handler2 : BaseHandler
    {
        public override void Handle(string food)
        {
            if (CanHandle(food))
            {
                Console.WriteLine($"{food}은 채소입니다");
            }
            else
            {
                Console.WriteLine($"{food}은 채소가 아닙니다");
                base.Handle(food);
            }
        }
        private bool CanHandle(string food)
        {
            if (food.Equals("토마토"))
            {
                return true;
            }
            return false;
        }
    }
}
