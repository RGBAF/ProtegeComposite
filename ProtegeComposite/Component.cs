using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    abstract class Component
    {
        private string _name;
        public string Name { get =>_name;  set => Name = _name; }

        protected Component(string name)
        {
            _name = name;
        }
        public abstract void Insert(string name, string newClassName);
        public Component() { }
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove()
        {
            throw new NotImplementedException();
        }
        public virtual bool IsComposite()
        {
            return true;
        }
        public abstract void Display(int depth);
    }
}
