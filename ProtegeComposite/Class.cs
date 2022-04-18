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
        //Иерархия
        protected List<Component> _classes = new List<Component>();
        //Конструктор 
        public Class(string name): base(name)
        {
             
        }
        public Class(string name,Dictionary<string,string>slots) : base(name)
        {
            _slots = slots;
        }
        //Добавление элемента в класс
        /*public override void Add(Component component, Dictionary<string,string>slots)
        {
            component._slots = slots;
            _classes.Add(component);
        }*/
        public override void Add(Component component)
        {
            _classes.Add(component);
        }
        // Проверка являеется ли объект классом, а не инстанцией
        public override bool IsComposite()
        {
            return true;
        }
        
        //Вставка класса в класс 
        public override void Insert(string name, string newClassName)
        {
            
            foreach (var component in _classes)
            {
                if (component.IsComposite())
                {
                    if (component.Name == name)
                    {
                        component.Add(new Class(newClassName,component._slots));
                    }
                    else if (component.Name != name)
                    {
                        component.Insert(name, newClassName);
                    }
                }
            }
        }
        //Создание инстанции
        public override void InsertInstance(string name)
        {
            foreach (var component in _classes)
            {
                if (component.IsComposite())
                {
                    if (component.Name == name)
                    {
                        component._instances.Add(new Instance(component._slots));
                    }
                    else if (component.Name != name)
                    {
                        component.InsertInstance(name);
                    }
                }
            }
        }

        //Удаление элемента
        public override void Remove()
        {
            base.Remove();
        }
        //Вывод икрархии
        public override void Display(int depth)
        {
            if (IsComposite())
            {
                if (Name == "Tree")
                {
                    Console.WriteLine("Ontolоgy:");
                    foreach (var component in _classes)
                    {
                        component.Display(depth + 5);
                    }
                }
                else
                {
                    Console.WriteLine(new string('-', depth) + "Class: " + Name);
                    foreach (var component in _classes)
                    {

                        component.Display(depth + 5);
                    }
                }
            }
            
        }
        public override void addSlotComponent(Component components, string slotName)
        {

           
            foreach(var component in _classes)
            {
                component._slots.Add(slotName, null);
                component.addSlotComponent(components, slotName);
            }
        }
       
        //Добавление слота
        public override void addSlot(string name, string slotName)
        {
            foreach (var component in _classes)
            {
                if (component.Name == name)
                {   component._slots.Add(slotName, null);
                    component.addSlotComponent(component, slotName);
                }
                else
                {
                    component.addSlot(name, slotName);
                }
            }
        }
        public override void displayInstance(string name)
        {
            if (IsComposite())
            {
                foreach (var component in _classes )
                {
                    if (component.Name == name)
                    {
                        foreach (var instance in component._instances)
                        {
                            instance.displayInstance();
                        }
                    }
                    else
                    {
                        component.displayInstance(name);
                    }
                }
            }
        }
    }
    
}
