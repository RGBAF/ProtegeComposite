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
        public List<Slots> slots { get; set; } 
        protected Component(string name)
        {
            _name = name;
        }
        public virtual void Insert(string name, string newClassName)
        {
            throw new NotImplementedException("Нельзя добавить класс в инстанцию");
        }
        public Component() { }
        
        public virtual void Add(Component component)
        {
            throw new NotImplementedException();
        }
        public virtual void Remove()
        {
            throw new NotImplementedException();
        }
        public virtual void InsertInstance(string name, string newInstanceName)
        {
            throw new NotImplementedException("Нельзя добавить инстанцию в инстанцию");
        }
        public virtual bool IsComposite()
        {
            return true;
        }
        public abstract void Display(int depth);
        public abstract void addSlot(string name,string slotName);
    }
}
