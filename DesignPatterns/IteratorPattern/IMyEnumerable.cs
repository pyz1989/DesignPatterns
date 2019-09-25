using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorPattern
{
    public interface IMyEnumerable
    {
        int Current { get; }

        bool MoveNext();

    }
}
