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
            this._classes.Add(component);
        }

        public override bool IsComposite()
        {
            return true;
        }

        public override string Operation()
        {
            int i = 0;
            string result = Name + "(";
            foreach (Component component in this._classes)
            {
                result += component.Operation();
                if (i != this._classes.Count - 1)
                {
                    result += "+";
                }
                i++;

            }
            return result + ")";
        }
        public override void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Класс: " + Name);
            Console.WriteLine("Инстанция: ");
            for (int i = 0; i < _classes.Count; i++)
            {
                _classes[i].Print();
            }
            
        }
        public int ComponentSearch(string name)
        {
            for (int i = 0; i < _classes.Count; i++)
            {
                
                if(_classes[i].Name == name)
                {
                    return i;
                }
            }
            return 0;
        }  
        public override void Insert(string name, string name2)
        {
            _classes[ComponentSearch(name)].Add(new Class(name2));
        }

        public override void Remove()
        {
            base.Remove();
        }
    }
}
