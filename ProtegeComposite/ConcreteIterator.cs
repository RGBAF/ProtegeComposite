using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal class ConcreteIterator: Iterator
    {
        private readonly Aggregate _aggregate;
        private int _current;

        public ConcreteIterator(Aggregate aggregate)
        {
            this._aggregate = aggregate;
        }
        public override Component First()
        {
            return _aggregate[0];
        }
        public override Component Next()
        {
            Component ret = null;
            _current++;
            if (_current < _aggregate.Count)
            {
                ret = _aggregate[_current];
            }
            return ret;
        }
        public override Component CurrentItem()
        {
            return _aggregate[_current];
        }
        public override bool IsDone()
        {
            return _current <= _aggregate.Count;
        }
    }
}
