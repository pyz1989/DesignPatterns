using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern
{
    public abstract class PhoneBrand
    {
        private Soft soft;
        public abstract void Run();
        public void SetSoft(Soft soft)
        {
            this.soft = soft;
        }
    }
}
