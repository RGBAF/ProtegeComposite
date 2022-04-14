using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class ConcerteAggregate : Aggregate
    {
        private readonly List<Component> _items = new List<Component>();
        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }
        public override int Count { get { return _items.Count; } protected set { } }
        public override Component this[int index] { get => _items[index]; set => _items.Insert(index, value);}

    }
}
