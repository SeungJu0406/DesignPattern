using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Flyweight
    {
        public RepeatingState repeatingState {  get; private set; }
        
        public Flyweight(RepeatingState repeatingState)
        {
            this.repeatingState = repeatingState;            
        }

        public void operation(UniqueState uniqueState)
        {
            uniqueState.Method();
        }
    }
}
