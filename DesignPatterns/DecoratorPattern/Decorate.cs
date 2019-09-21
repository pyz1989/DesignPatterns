using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Decorate: Phone
    {
        private Phone phone;
        
        public void SetDecorate(Phone phone)
        {
            this.phone = phone;
        }
    }
}
