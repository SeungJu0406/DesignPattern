using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    internal class Context 
    {
        UniqueState uniqueState;
        Flyweight flyweight;
        FlyweightFactory flyweightFactory;

        public Context(RepeatingState repeatingState,UniqueState uniqueStatem) 
        {
            flyweightFactory = new FlyweightFactory();
            this.uniqueState = uniqueStatem;
            flyweight= flyweightFactory.GetFlyweight(repeatingState);
        }
        public void Operation()
        {
            flyweight.operation(uniqueState);
        }
    }
}
