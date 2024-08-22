using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class BaseHandler : IHandler
    {
        private IHandler next;

        public void SetNext(IHandler handler)
        {
           this.next = handler;
        }
        public virtual void Handle(string food)
        {
            if(next != null)
            {
                next.Handle(food);
            }
        }
    }
}
