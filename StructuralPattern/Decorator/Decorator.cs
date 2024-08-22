using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Decorator : BaseDecprator
    {
        public Decorator(IComponent component) : base(component) { }

        public override void Execute()
        {
            base.Execute();
            Extra();
        }
        public void Extra() 
        {
            Console.WriteLine("데코레이터");
        }

    }
}
