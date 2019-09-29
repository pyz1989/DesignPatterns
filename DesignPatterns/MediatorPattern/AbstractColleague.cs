using System;
using System.Collections.Generic;
using System.Text;

namespace MediatorPattern
{
    public abstract class AbstractColleague
    {
        public string UserName { get; set; }
        public abstract void Send(string userName, string message);

        public abstract void Receive(string message);
    }
}
