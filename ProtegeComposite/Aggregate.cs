using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
        public abstract int Count { get; protected set; }
        public abstract Component this[int index] { get; set; }
    }
}
