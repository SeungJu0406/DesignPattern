using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class ClientClass
    {
        public string name {  get; private set; }
        private IClientInterface clientInterface;
        public ClientClass(Adaptee adaptee) 
        {
            clientInterface = new Adapter(adaptee);
        }

        public void Method()
        {
            clientInterface.Method();
        }
    }
}
