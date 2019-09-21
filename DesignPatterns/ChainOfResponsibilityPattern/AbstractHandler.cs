using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern
{
    public abstract class AbstractHandler
    {
        public AbstractHandler handler = null;

        public void SetHandler(AbstractHandler handler)
        {
            this.handler = handler;
        }
        public abstract void Request(int state);
    }
}
