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
        //Добавление элемента в класс
        public override void Add(Component component)
        {
            _classes.Add(component);
        }
        // Проверка являеется ли объект классом, а не инстанцией
        public override bool IsComposite()
        {
            return true;
        }
        
        //Вставка элемента в класс
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
        //Удаление элемента
        public override void Remove()
        {
            base.Remove();
        }
        //Вывод икрархии
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth)+Name);
            foreach(var component in _classes)
            {
                component.Display(depth+2);
            }
        }
        //Создание слота
        public override void createSlot(Component component,string slotName)
        {
            component.slots.Add(new Slots(slotName));
        }
        //Добавление слота
        public override void addSlot(string name)
        {

            foreach (var component in _classes)
            {
                if (component.Name == name)
                {
                    foreach (var slot in slots)
                    {
                        component.slots.Add(slot);
                    }
                }
                else
                {
                    foreach(var slot in slots)  
                    component.slots.Add(slot);
                }
                
            }
        }
    }
}
