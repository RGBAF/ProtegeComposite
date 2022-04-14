using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class Class : Component
    {

        protected List<Component> _classes = new List<Component>();

        public Class(string name): base(name)
        {
        }

        public override void Add(Component component)
        {
            _classes.Add(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        internal void Display()
        {
            throw new NotImplementedException();
        }

        public override void Insert(string name, string newClassName)
        {
            foreach (var component in _classes)
            {
                if (component.IsComposite())
                {
                    if (component.Name == name)
                    {
                        component.Add(new Class(newClassName));
                    }
                    else if (component.Name != name)
                    {
                        component.Insert(name, newClassName);
                    }
                }
            }
           
        }  

        public override void Remove()
        {
            base.Remove();
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+Name);
            foreach(var component in _classes)
            {
                component.Display(depth+2);
            }
        }
    }
}
