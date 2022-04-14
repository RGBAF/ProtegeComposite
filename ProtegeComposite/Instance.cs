using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class Instance: Component
    {
       

        public Instance(string name):base(name){}

        
        public override bool IsComposite()
        {
            return false;
        }
       

        public override void Insert(string name, string name2)
        {
            throw new NotImplementedException();
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + Name);
        }
        
    }
}
