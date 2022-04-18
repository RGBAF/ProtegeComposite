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
        public List<Instance> _instances;

        public Dictionary<string, string> _slots;
        
        protected Component(string name)
        {
            _name = name;
            _slots = new Dictionary<string, string>();
            _instances = new List<Instance>();
        }
        public virtual void Insert(string name, string newClassName)
        {
            throw new NotImplementedException("Нельзя добавить класс в инстанцию");
        }
        public Component() { }
        
        public virtual void Add(Component component,Dictionary<string,string> slots)
        {
            throw new NotImplementedException();
        }
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove()
        {
            throw new NotImplementedException();
        }
        public virtual void InsertInstance(string name)
        {
            throw new NotImplementedException("Нельзя добавить инстанцию в инстанцию");
        }
        public abstract void addSlotComponent( Component component, string slotName);
        
        public virtual bool IsComposite()
        {
            return true;
        }
        public virtual void displayInstance(string name)
        {
            throw new NotImplementedException();
        }
        public abstract void Display(int depth);
        
        public abstract void addSlot(string name,string slotName);

    }
}
