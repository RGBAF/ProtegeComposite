using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal interface IEnumerable
    {
        bool MoveNext();
        Component Current { get; }
        void Reset();

    }
}
