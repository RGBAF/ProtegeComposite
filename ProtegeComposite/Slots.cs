using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    public class Slots
    {
        private string _name { get; set; }
        public string Name { get { return _name; } set { _name = value; } }
        private string _value{ get; set; }
        public string Value { get { return _value; } set { _value = value; } }
        public Slots()
        {

        }
        public Slots(string name)
        {
            Name = name;
        }

    }
}
