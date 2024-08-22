using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class BaseDecprator : IComponent
    {
        private IComponent wrappee;

        public BaseDecprator(IComponent component)
        {
            this.wrappee = component;
        }
        public virtual void Execute()
        {
            wrappee.Execute();
        }
    }
}
