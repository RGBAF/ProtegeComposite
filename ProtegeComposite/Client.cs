using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class Client
    {
        public void ClientCode(Component _class, Component _instance) {
            if (_class.IsComposite())
            {
                _class.Add(_instance);
            }
            Console.WriteLine($"Result:{_class.Operation()}");
        }
    }
}
