using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace StrategyPattern.RealProject
{
    public abstract class AbstractSetup
    {
        public abstract void Step(LeafletEntity leaflet, DataRow row);
    }
}
