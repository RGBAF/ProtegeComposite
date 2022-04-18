using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class Instance: Component
    {
        Dictionary<string, string> _instSlots = new Dictionary<string, string>();

        public Instance(Dictionary<string,string> slots) { 
            _instSlots = slots;
        }
        public Instance(string name):base(name){
            _instSlots = _slots;
        }

        public override bool IsComposite()
        {
            return false;
        }
        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + "Instance: " + Name);
        }
        public void displayInstance()
        {
            Console.WriteLine("Инстанция:");
            foreach(var slot in _instSlots)
            {
                Console.WriteLine($"{slot.Key}: {slot.Value}");
            }
        }
        public override void addSlotComponent(Component component,string slotName)
        {
            
        }
        public override void addSlot(string name, string slotName)
        {
            
        }
    }
}
