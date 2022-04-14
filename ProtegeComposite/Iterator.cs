using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProtegeComposite
{
    internal abstract class Iterator
    {
        public abstract Component Next();
        public abstract Component First();
        public abstract bool IsDone();
        public abstract Component CurrentItem();
        

    }
}
