using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Composite : IComponent
    {
        private List<IComponent> children;

        public Composite()
        {
            children = new List<IComponent>();
        }
        public void Add(IComponent c)
        {
            children.Add(c);
        }
        public void Remove(IComponent c) 
        {
            children.Remove(c);
        }
        public List<IComponent> GetChildren()
        {
            return children;
        }
        public void Execute()
        {
            foreach (IComponent c in children)
            {
                c.Execute();
            }
        }
    }
}
