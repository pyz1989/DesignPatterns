using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderPattern
{
    public abstract class AbstractPerson
    {
        public abstract void CreateHead();
        public abstract void CreateBody();
        public abstract void CreateHand();
        public abstract void CreateLeg();
    }
}
