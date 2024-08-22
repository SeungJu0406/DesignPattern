using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility.Concretes
{
    public class Handler1 : BaseHandler
    {
        public override void Handle(string food)
        {
            if (CanHandle(food))
            {
                Console.WriteLine($"{food}은 과일입니다");
            }
            else
            {
                Console.WriteLine($"{food}은 과일이 아닙니다");
                base.Handle(food);
            }
        }
        private bool CanHandle(string food) 
        {
            if (food.Equals("바나나"))
            {
                return true;
            }
            return false;
        }
    }
}
