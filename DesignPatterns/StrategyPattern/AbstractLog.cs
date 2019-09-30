using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public abstract class AbstractLog
    {
        public abstract void Write(string msg);
    }
}
