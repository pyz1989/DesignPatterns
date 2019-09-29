using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public abstract class AbstractMediator
    {
        public abstract void Send(string userName, string message);

        public abstract void Add(AbstractColleague colleague);
    }
}
